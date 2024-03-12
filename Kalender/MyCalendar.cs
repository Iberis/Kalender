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
    public partial class MyCalendar : Form
    {
        private List<DayForm> activeDayForms = new List<DayForm>();
        private List<Task> globalTasks = new List<Task>();

        public MyCalendar()
        {
            InitializeComponent();
        }

        //During creation, automatically selects 
        //the current year and month.
        //Loads saved Tasks from CSV if available.
        private void MyCalendar_Load(object sender, EventArgs e)
        {
            globalTasks = CSVManager.LoadFromCSV();
            YearSelection.Value = DateTime.Today.Year;
            MonthSelection.SelectedIndex = DateTime.Today.Month - 1;
            
        }

        /*
         * The BuildDayDisplay method is responsible for populating the
         * DayDisplay form with buttons of the ButtonDay class, according
         * to the number of days in the selected month.
         * Each button is assigned the same onClick method, which is later
         * responsible for resolving the buttons identity over the sender object.
         */
        private void BuildDayDisplay()
        {
            if (!MonthIsValid())
                return;
            
            int year = (int)YearSelection.Value;
            int month = MonthSelection.SelectedIndex + 1;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            DayDisplay.Controls.Clear();
            for (int day = 1; day <= daysInMonth; day++)
            {
                ButtonDay button = new ButtonDay(day);
                button.Click += (sender, e) => Day_Click(sender, e);
                if (DayHasTask(year, month, day))
                    button.BackColor = Color.FromArgb(255, 242, 204);
                DayDisplay.Controls.Add(button);
            }
        }

        /*
         * Checks if a date has a task associated with it.
         */
        private bool DayHasTask(int year, int month, int day)
        {
            return DayHasTask(new DateTime(year, month, day));
        }
        private bool DayHasTask(DateTime date)
        {
            foreach (Task element in globalTasks)
            {
                if (element.IsSameDay(date))
                    return true;
            }
            return false;
        }

        /*
         * The method MonthIsValid checks if the currently selected Month
         * based on the MonthSelection DropBox Index is valid and returns the result.
         * If the result is invalid, resets the month and year values to the current month.
         */
        private bool MonthIsValid()
        {
            if (MonthSelection.SelectedIndex < 0 || MonthSelection.SelectedIndex >= 12)
            {
                MessageBox.Show("Invalid Month Selected");
                MonthSelection.SelectedIndex = DateTime.Today.Month - 1;
                return false;
            }
            return true;
        }

        // The method ReceiveTasks is responsible for receiving a collection
        // of tasks from the sub-windows of specific dates (DayForm), for 
        // saving.
        public void ReceiveTasks(DayForm sender, Task[] tasks, Task[] deletedTasks)
        {
            foreach (Task toDelete in deletedTasks)
            {
                if (!globalTasks.Remove(toDelete))
                    System.Diagnostics.Trace.TraceWarning("Task could not be deleted from master. " + toDelete.ToString());
            }

            foreach (Task element in tasks)
            {
                if (!globalTasks.Contains(element))
                    globalTasks.Add(element);
            }

            activeDayForms.Remove(sender);
            BuildDayDisplay();
        }


        // === EVENTS ===

        // Event triggered by all ButtonDay controls.
        // Opens a new DayForm form for the specific date.
        // If a window for the given date is already open,
        // that window is brought to the front instead.
        private void Day_Click(object sender, EventArgs e)
        {
            if (!MonthIsValid())
                return;

            int year = (int)YearSelection.Value;
            int month = MonthSelection.SelectedIndex + 1;
            int day = (sender as ButtonDay).index;
            DateTime date = new DateTime(year, month, day);

            //Retrieve tasks for the selected day from storage
            List<Task> dayTasks = new List<Task>();
            foreach (Task task in globalTasks)
            {
                if (task.IsSameDay(date))
                    dayTasks.Add(task);
            }

            DayForm dayObj = new DayForm(date, dayTasks.ToArray<Task>())
            {
                Owner = this
            };

            if (activeDayForms.Contains(dayObj))
            {
                dayObj = activeDayForms.Find(x => x.Equals(dayObj));
                dayObj.BringToFront();
            }
            else
            {
                activeDayForms.Add(dayObj);
                dayObj.Show();
            }
        }

        // If a new Month is selected, rebuild the DayDisplay.
        private void MonthSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildDayDisplay();
        }

        // Confirms, if the user deselects the MonthSelection DropBox,
        // that a valid month can be resolved.
        private void MonthSelection_Leave(object sender, EventArgs e)
        {
            MonthIsValid();
        }

        // If a new Year is selected, rebuild the DayDisplay.
        private void YearSelection_ValueChanged(object sender, EventArgs e)
        {
            BuildDayDisplay();
        }

        private void MyCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSVManager.SaveToCSV(globalTasks.ToArray());
        }
    }
}
