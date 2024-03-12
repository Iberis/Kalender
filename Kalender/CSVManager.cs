using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    class CSVManager
    {
        private static readonly string defaultFilePath = Directory.GetCurrentDirectory() + @"\savedata.csv";
        public static Encoding encoding = Encoding.UTF8;

        public static List<Task> LoadFromCSV(string filePath)
        {
            List<Task> taskList = new List<Task>();
            if (!File.Exists(filePath))
                return taskList;

            string toParse = "";
            using (StreamReader reader = new StreamReader(filePath, encoding))
            {
                toParse = reader.ReadToEnd();
            }

            string[] lines = toParse.Split('\n');
            foreach (string element in lines)
            {
                taskList.Add(Task.FromCSV(element));
            }

            return taskList;
        }

        public static List<Task> LoadFromCSV()
        {
            return LoadFromCSV(defaultFilePath);
        }

        public static void SaveToCSV(string filePath, Task[] tasksToSave)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, encoding))
            {
                foreach (Task element in tasksToSave)
                    writer.Write(element.ToCSV());
            }                
        }

        public static void SaveToCSV(Task[] tasksToSave)
        {
            SaveToCSV(defaultFilePath, tasksToSave);
        }
    }
}
