using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    public class Task : IEquatable<Task>, IComparable<Task>
    {
        public static char CSV_Seperator = ';';
        public static char CSV_DateTime_Seperator = '-';
        public string Name { get; }
        public string Notes { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Duration { get; }

        public Task(string name, string notes, DateTime startTime, DateTime endTime)
        {
            Name = name;
            Notes = notes;
            StartTime = startTime;
            EndTime = endTime;
            Duration = endTime.Subtract(startTime);
        }

        public string ToCSV()
        {
            string returnValue = Name + "{0}" + DateTimeToCSV(StartTime) + "{0}" 
                + DateTimeToCSV(EndTime) + "{0}" + Notes + "{1}";

            return string.Format(returnValue, CSV_Seperator, '\n' );
        }

        private static string DateTimeToCSV(DateTime date)
        {
            string returnValue = date.Day.ToString() + "{0}" + date.Month.ToString() + "{0}"
                + date.Year.ToString() + "{0}" + date.Hour.ToString() + "{0}" + date.Minute.ToString();

            return string.Format(returnValue, CSV_DateTime_Seperator);
        }

        private static DateTime DateTimeFromCSV(string loadString)
        {
            string[] elements = loadString.Split(CSV_DateTime_Seperator);
            if (elements.Length == 5
                && int.TryParse(elements[0], out int day)
                && int.TryParse(elements[1], out int month)
                && int.TryParse(elements[2], out int year)
                && int.TryParse(elements[3], out int hour)
                && int.TryParse(elements[4], out int min))
                return new DateTime(year, month, day, hour, min, 0);
            else
                return DateTime.MinValue;
        }

        public static Task FromCSV(string lineToParse)
        {
            string[] elements = lineToParse.Split(CSV_Seperator);
            if (!(elements.Length == 4))
                return new Task("ERROR - DATA CORRUPT", "", DateTime.MinValue, DateTime.MinValue);

            string name = elements[0];
            DateTime startTime = DateTimeFromCSV(elements[1]);
            DateTime endTime = DateTimeFromCSV(elements[2]);
            string notes = elements[3];

            return new Task(name, notes, startTime, endTime);
        }

        public override string ToString()
        {
            string format = "{0} - {1} \"{2}\"";
            return string.Format(format, StartTime.ToShortTimeString(), EndTime.ToShortTimeString(), Name );
        }

        public bool Equals(Task other)
        {
            if (other == null)
                return false;

            return (Name.Equals(other.Name) && Notes.Equals(other.Notes)
                && StartTime.Equals(other.StartTime) && EndTime.Equals(other.EndTime));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return Equals(obj as Task);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() * Notes.GetHashCode() * StartTime.GetHashCode() * EndTime.GetHashCode();
        }

        public int CompareTo(Task other)
        {
            if (other == null) return 1;

            return StartTime.CompareTo(other.StartTime) * 10 + EndTime.CompareTo(other.EndTime);
        }

        public bool IsSameDay(DateTime date)
        {
            if (date == null)
                return false;

            return date.Year == StartTime.Year && date.Month == StartTime.Month 
                && date.Day == StartTime.Day;
        }
    }
}
