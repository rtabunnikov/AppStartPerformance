namespace TelerikSpreadsheetRibbonDesigntime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Windows.Documents.Spreadsheet.Model.Workbook workbook2 = new Telerik.Windows.Documents.Spreadsheet.Model.Workbook();
            this.radSpreadsheet1 = new Telerik.WinControls.UI.RadSpreadsheet();
            this.radSpreadsheetRibbonBar1 = new Telerik.WinControls.UI.RadSpreadsheetRibbonBar();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheetRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radSpreadsheet1
            // 
            this.radSpreadsheet1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSpreadsheet1.Location = new System.Drawing.Point(0, 207);
            this.radSpreadsheet1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSpreadsheet1.Name = "radSpreadsheet1";
            // 
            // 
            // 
            this.radSpreadsheet1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 480, 320);
            this.radSpreadsheet1.Size = new System.Drawing.Size(1067, 347);
            this.radSpreadsheet1.TabIndex = 0;
            workbook2.ActiveTabIndex = -1;
            workbook2.Name = "Book1";
            workbook2.WorkbookContentChangedInterval = System.TimeSpan.Parse("00:00:00.0300000");
            this.radSpreadsheet1.Workbook = workbook2;
            // 
            // radSpreadsheetRibbonBar1
            // 
            this.radSpreadsheetRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.radSpreadsheetRibbonBar1.AssociatedSpreadsheet = this.radSpreadsheet1;
            this.radSpreadsheetRibbonBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // 
            // 
            // 
            // 
            // 
            this.radSpreadsheetRibbonBar1.ExitButton.ButtonElement.UseCompatibleTextRendering = false;
            this.radSpreadsheetRibbonBar1.ExitButton.Text = "Exit";
            this.radSpreadsheetRibbonBar1.ExitButton.UseCompatibleTextRendering = false;
            this.radSpreadsheetRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
            this.radSpreadsheetRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radSpreadsheetRibbonBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSpreadsheetRibbonBar1.Name = "radSpreadsheetRibbonBar1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.radSpreadsheetRibbonBar1.OptionsButton.ButtonElement.UseCompatibleTextRendering = false;
            this.radSpreadsheetRibbonBar1.OptionsButton.Text = "Options";
            this.radSpreadsheetRibbonBar1.OptionsButton.UseCompatibleTextRendering = false;
            // 
            // 
            // 
            this.radSpreadsheetRibbonBar1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 1412, 310);
            this.radSpreadsheetRibbonBar1.RootElement.StretchVertically = true;
            this.radSpreadsheetRibbonBar1.ShowLayoutModeButton = true;
            this.radSpreadsheetRibbonBar1.SimplifiedHeight = 140;
            this.radSpreadsheetRibbonBar1.Size = new System.Drawing.Size(1067, 207);
            this.radSpreadsheetRibbonBar1.TabIndex = 0;
            this.radSpreadsheetRibbonBar1.Text = "Form1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.radSpreadsheet1);
            this.Controls.Add(this.radSpreadsheetRibbonBar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheetRibbonBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSpreadsheet radSpreadsheet1;
        private Telerik.WinControls.UI.RadSpreadsheetRibbonBar radSpreadsheetRibbonBar1;
    }
}

