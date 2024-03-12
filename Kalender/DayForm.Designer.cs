namespace Kalender
{
    partial class DayForm
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
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelNewTask = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.richTextBoxNewNotes = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.buttonSaveNotes = new System.Windows.Forms.Button();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Location = new System.Drawing.Point(13, 13);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTasks.Size = new System.Drawing.Size(205, 212);
            this.listBoxTasks.Sorted = true;
            this.listBoxTasks.TabIndex = 0;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.ListBoxTasks_SelectedIndexChanged);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(163, 376);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.ButtonAddNew_Click);
            // 
            // labelNewTask
            // 
            this.labelNewTask.AutoSize = true;
            this.labelNewTask.Location = new System.Drawing.Point(13, 268);
            this.labelNewTask.Name = "labelNewTask";
            this.labelNewTask.Size = new System.Drawing.Size(84, 13);
            this.labelNewTask.TabIndex = 2;
            this.labelNewTask.Text = "Add a new task:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(13, 286);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(144, 20);
            this.textBoxNewName.TabIndex = 3;
            this.textBoxNewName.Text = "Name";
            this.textBoxNewName.Enter += new System.EventHandler(this.TextBoxNewName_Enter);
            this.textBoxNewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewName_KeyPress);
            // 
            // richTextBoxNewNotes
            // 
            this.richTextBoxNewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNewNotes.Location = new System.Drawing.Point(13, 312);
            this.richTextBoxNewNotes.Name = "richTextBoxNewNotes";
            this.richTextBoxNewNotes.Size = new System.Drawing.Size(144, 91);
            this.richTextBoxNewNotes.TabIndex = 6;
            this.richTextBoxNewNotes.Text = "Notes";
            this.richTextBoxNewNotes.Enter += new System.EventHandler(this.RichTextBoxNewNotes_Enter);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(16, 231);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(163, 286);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(58, 13);
            this.labelStartTime.TabIndex = 8;
            this.labelStartTime.Text = "Start Time:";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(163, 325);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(55, 13);
            this.labelEndTime.TabIndex = 9;
            this.labelEndTime.Text = "End Time:";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(225, 13);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(208, 212);
            this.richTextBoxNotes.TabIndex = 10;
            this.richTextBoxNotes.Text = "";
            this.richTextBoxNotes.TextChanged += new System.EventHandler(this.RichTextBoxNotes_TextChanged);
            // 
            // buttonSaveNotes
            // 
            this.buttonSaveNotes.Enabled = false;
            this.buttonSaveNotes.Location = new System.Drawing.Point(225, 230);
            this.buttonSaveNotes.Name = "buttonSaveNotes";
            this.buttonSaveNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNotes.TabIndex = 11;
            this.buttonSaveNotes.Text = "Save Notes";
            this.buttonSaveNotes.UseVisualStyleBackColor = true;
            this.buttonSaveNotes.Click += new System.EventHandler(this.ButtonSaveNotes_Click);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "HH\':\'mm";
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(166, 302);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.ShowUpDown = true;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerStartTime.TabIndex = 12;
            this.dateTimePickerStartTime.Value = new System.DateTime(2023, 3, 1, 9, 59, 7, 0);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "HH\':\'mm";
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(166, 341);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerEndTime.TabIndex = 13;
            this.dateTimePickerEndTime.Value = new System.DateTime(2023, 3, 1, 9, 59, 7, 0);
            // 
            // DayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 415);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.buttonSaveNotes);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.richTextBoxNewNotes);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelNewTask);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.listBoxTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 454);
            this.MinimumSize = new System.Drawing.Size(461, 454);
            this.Name = "DayForm";
            this.ShowInTaskbar = false;
            this.Text = "DayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DayForm_FormClosing);
            this.Load += new System.EventHandler(this.DayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label labelNewTask;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.RichTextBox richTextBoxNewNotes;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Button buttonSaveNotes;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
    }
}