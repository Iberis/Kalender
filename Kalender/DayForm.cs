using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender
{
    public partial class DayForm : Form, IEquatable<DayForm>
    {
        public readonly DateTime date;

        // Stores any deleted Task for later sync with the MyCalendar owner Form
        private List<Task> deletedTasks = new List<Task>();

        // These fields store the text with which textBoxNewName and richTextBoxNewNotes are initialised,
        // to allow these text boxes to be reset properly.
        private readonly string defaultNameText;
        private readonly string defaultNotesText;

        public DayForm(DateTime date, Task[] savedTasks)
        {
            this.date = date;
            InitializeComponent();
            foreach (Task element in savedTasks)
                listBoxTasks.Items.Add(element);

            defaultNameText = textBoxNewName.Text;
            defaultNotesText = richTextBoxNewNotes.Text;
        }

        private void DayForm_Load(object sender, EventArgs e)
        {
            Text = date.ToLongDateString();
            // Set new-Task dateTimePickers
            int hourNow = DateTime.Now.Hour;
            DateTime startTime = new DateTime(date.Year, date.Month, date.Day, hourNow, 0, 0);
            DateTime endTime = new DateTime(date.Year, date.Month, date.Day, hourNow + 1, 0, 0);
            dateTimePickerStartTime.Value = startTime;
            dateTimePickerEndTime.Value = endTime;
        }

        private void ActivateItalics(TextBoxBase textBox)
        {
            textBox.Font = new Font(textBox.Font.Name, textBox.Font.SizeInPoints, 
                FontStyle.Italic, textBox.Font.Unit, textBox.Font.GdiCharSet);
        }

        private void DisableItalics(TextBoxBase textBox)
        {
            textBox.Font = new Font(textBox.Font.Name, textBox.Font.SizeInPoints,
                FontStyle.Regular, textBox.Font.Unit, textBox.Font.GdiCharSet);
        }

        public bool Equals(DayForm other)
        {
            if (other == null)
                return false;
            
            return date.Equals(other.date);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            return Equals(obj as DayForm);
        }

        public override int GetHashCode()
        {
            return date.GetHashCode();
        }

        // Checks if the values for a new tasks are legal
        private bool CheckValuesForNew()
        {
            if (textBoxNewName.Text == string.Empty || textBoxNewName.Text.Equals(defaultNameText))
            {
                MessageBox.Show("Name cannot be empty");
                return false;
            }

            TimeSpan duration = dateTimePickerEndTime.Value.Subtract(dateTimePickerStartTime.Value);
            if (duration.TotalMinutes < 0)
            {
                MessageBox.Show("End Time must be later than Start Time");
                return false;
            }

            return true;
        }

        // === EVENTS ===
        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            if (!CheckValuesForNew())
                return;

            string notes = richTextBoxNewNotes.Text;
            if (notes.Equals(defaultNotesText))
                notes = "";
            Task newTask = new Task(textBoxNewName.Text, notes, 
                dateTimePickerStartTime.Value, dateTimePickerEndTime.Value);

            listBoxTasks.Items.Add(newTask);
            if (listBoxTasks.SelectedIndex < 0)
                listBoxTasks.SelectedIndex = 0;

            // Reset the text boxes for new tasks
            textBoxNewName.Text = defaultNameText;
            ActivateItalics(textBoxNewName);
            richTextBoxNewNotes.Text = defaultNotesText;
            ActivateItalics(richTextBoxNewNotes);
        }

        private void ListBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!((sender as ListBox).SelectedItem is Task task))
            {
                return;
            }
            richTextBoxNotes.Text = task.Notes;
            buttonSaveNotes.Enabled = false;
            buttonDelete.Enabled = true;
        }

        private void RichTextBoxNotes_TextChanged(object sender, EventArgs e)
        {
            buttonSaveNotes.Enabled = true;
        }

        // Clones the edited Task and saves the new notes value.
        private void ButtonSaveNotes_Click(object sender, EventArgs e)
        {
            Task selectedTask = listBoxTasks.SelectedItem as Task;
            deletedTasks.Add(selectedTask);
            listBoxTasks.Items.Remove(selectedTask);

            Task newTask = new Task(selectedTask.Name, richTextBoxNotes.Text, selectedTask.StartTime, selectedTask.EndTime);
            listBoxTasks.Items.Add(newTask);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection indices = listBoxTasks.SelectedIndices;

            for (int i = listBoxTasks.Items.Count; i >= 0; i--)
            {
                if (indices.Contains(i))
                {
                    deletedTasks.Add(listBoxTasks.Items[i] as Task);
                    listBoxTasks.Items.RemoveAt(i);
                }
            }
        }

        private void DayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Task[] tasks = new Task[listBoxTasks.Items.Count];
            listBoxTasks.Items.CopyTo(tasks, 0);
            Task[] deletedTasks = new Task[this.deletedTasks.Count];
            this.deletedTasks.CopyTo(deletedTasks);
            (Owner as MyCalendar).ReceiveTasks(this, tasks, deletedTasks);
        }

        private void TextBoxNewName_Enter(object sender, EventArgs e)
        {
            if (textBoxNewName.Font.Italic)
            {
                textBoxNewName.Clear();
                DisableItalics(textBoxNewName);
            }
        }

        private void RichTextBoxNewNotes_Enter(object sender, EventArgs e)
        {
            if (richTextBoxNewNotes.Font.Italic)
            {
                richTextBoxNewNotes.Clear();
                DisableItalics(richTextBoxNewNotes);
            }
        }

        private void TextBoxNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ButtonAddNew_Click(sender, e);
        }
    }
}