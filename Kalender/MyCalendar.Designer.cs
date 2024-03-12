namespace Kalender
{
    partial class MyCalendar
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MonthSelection = new System.Windows.Forms.ComboBox();
            this.DayDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.YearSelection = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.YearSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthSelection
            // 
            this.MonthSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.MonthSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MonthSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MonthSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthSelection.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MonthSelection.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthSelection.Location = new System.Drawing.Point(12, 12);
            this.MonthSelection.MaxDropDownItems = 12;
            this.MonthSelection.MaxLength = 50;
            this.MonthSelection.Name = "MonthSelection";
            this.MonthSelection.Size = new System.Drawing.Size(121, 32);
            this.MonthSelection.TabIndex = 2;
            this.MonthSelection.SelectedIndexChanged += new System.EventHandler(this.MonthSelection_SelectedIndexChanged);
            this.MonthSelection.Leave += new System.EventHandler(this.MonthSelection_Leave);
            // 
            // DayDisplay
            // 
            this.DayDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DayDisplay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DayDisplay.Location = new System.Drawing.Point(12, 50);
            this.DayDisplay.Name = "DayDisplay";
            this.DayDisplay.Size = new System.Drawing.Size(455, 230);
            this.DayDisplay.TabIndex = 1;
            // 
            // YearSelection
            // 
            this.YearSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YearSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSelection.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.YearSelection.Location = new System.Drawing.Point(139, 15);
            this.YearSelection.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.YearSelection.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.YearSelection.Name = "YearSelection";
            this.YearSelection.Size = new System.Drawing.Size(120, 29);
            this.YearSelection.TabIndex = 3;
            this.YearSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YearSelection.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.YearSelection.ValueChanged += new System.EventHandler(this.YearSelection_ValueChanged);
            // 
            // MyCalendar
            // 
            this.ClientSize = new System.Drawing.Size(479, 292);
            this.Controls.Add(this.YearSelection);
            this.Controls.Add(this.DayDisplay);
            this.Controls.Add(this.MonthSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 331);
            this.MinimumSize = new System.Drawing.Size(495, 331);
            this.Name = "MyCalendar";
            this.Text = "MyCalendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyCalendar_FormClosing);
            this.Load += new System.EventHandler(this.MyCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.ComboBox MonthSelection;
        private System.Windows.Forms.FlowLayoutPanel DayDisplay;
        private System.Windows.Forms.NumericUpDown YearSelection;
    }
}

