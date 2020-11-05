using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace AppStartPerformance {
    class Program {
        const int attempts = 10;
        static void Main(string[] args) {
            // WinForms
            MeasureStartTime("XtraSpreadsheet w/o ribbon", @"..\..\..\WinSpreadsheetNoRibbon\bin\Release\WinSpreadsheetNoRibbon.exe", attempts);
            MeasureStartTime("XtraSpreadsheet ribbon runtime", @"..\..\..\WinSpreadsheetRibbonRuntime\bin\Release\WinSpreadsheetRibbonRuntime.exe", attempts);
            MeasureStartTime("XtraSpreadsheet ribbon designtime", @"..\..\..\WinSpreadsheetRibbonDesigntime\bin\Release\WinSpreadsheetRibbonDesigntime.exe", attempts);
            // WPF
            MeasureStartTime("XpfSpreadsheet w/o ribbon", @"..\..\..\WpfSpreadsheetNoRibbon\bin\Release\WpfSpreadsheetNoRibbon.exe", attempts);
            MeasureStartTime("XpfSpreadsheet ribbon", @"..\..\..\WpfSpreadsheetRibbon\bin\Release\WpfSpreadsheetRibbon.exe", attempts);
            
            Console.WriteLine("Done! Press any key to continue...");
            Console.ReadKey();
        }

        static void MeasureStartTime(string name, string appPath, int n) {
            if (n < 1)
                throw new ArgumentException("Are you dumb?");
            Console.Write("Running {0}:", name);
            var times = new double[n];
            for (int i = 0; i < n; i++) {
                Console.Write(" {0}", i + 1);
                var time = MeasureOneRun(appPath);
                times[i] = time.TotalMilliseconds;
            }
            Console.WriteLine();
            var result = PrepareResult(name, times);
            PrintResult(result);
        }

        static TimeSpan MeasureOneRun(string appPath) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var process = Process.Start(appPath);
            process.WaitForExit(10000);
            sw.Stop();
            return sw.Elapsed;
        }

        static PerfResult PrepareResult(string name, double[] times) {
            Array.Sort(times);
            int n = times.Length;
            var result = new PerfResult() { 
                Name = name,
                Min = times[0],
                Max = times[n - 1]
            };
            double total = 0;
            for (int i = 0; i < n; i++)
                total += times[i];
            result.Mean = total / n;
            if (n == 1)
                result.Median = times[0];
            else if (n % 2 == 1)
                result.Median = times[n / 2];
            else
                result.Median = (times[n / 2] + times[n / 2 - 1]) / 2;
            return result;
        }

        static void PrintResult(PerfResult result) {
            Console.WriteLine(result.Name);
            Console.WriteLine("Min:    {0:F3} ms", result.Min);
            Console.WriteLine("Max:    {0:F3} ms", result.Max);
            Console.WriteLine("Avg:    {0:F3} ms", result.Mean);
            Console.WriteLine("Median: {0:F3} ms", result.Median);
            Console.WriteLine();
        }
    }
}
