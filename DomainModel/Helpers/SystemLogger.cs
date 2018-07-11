using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.BusinessObjects;

namespace DomainModel.Helpers
{
    public static class SystemLogger
    {
        private static ObservableCollection<string> _logs = new ObservableCollection<string>();
        public static void Log(string message)
        {
            var dir = CreateDirectoryIfIsNotExist();

            var logFile = GetCurrentLogFile(dir);

            WriteLogToFile(message, logFile);

        }

        public static void Log(Exception ex)
        {
            var dir = CreateDirectoryIfIsNotExist();

            var logFile = GetCurrentLogFile(dir);
            String logMessage = ("Error: " + ex.Message + ", " + ex.StackTrace).Replace("\r\n", "");
            if (ex.InnerException != null)
                logMessage += (ex.InnerException.Message + ", " + ex.InnerException.StackTrace).Replace("\r\n", "");
            WriteLogToFile(logMessage, logFile);

        }

        private static FileInfo GetCurrentLogFile(DirectoryInfo dir)
        {
            int counter = 1;

            FileInfo[] files = dir.GetFiles();

            List<String> lastcharcters = files.Select(x => Path.GetFileNameWithoutExtension(x.Name).Last().ToString()).ToList();

            lastcharcters.ForEach(x =>
            {
                int parsedcounter;

                if (!int.TryParse(x, out parsedcounter)) return;

                if (parsedcounter > counter) counter = parsedcounter;
            });

            var logFile = GetLogFileInfo(counter);

            if (!logFile.Exists) logFile.Create().Close();

            else if (logFile.Exists && logFile.Length >= FixedValues.MaxLogFileSize) logFile = GetLogFileInfo(counter + 1);

            return logFile;
        }
        private static void WriteLogToFile(string message, FileInfo logFile)
        {
            using (FileStream stream = logFile.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture) + " :::::::::: " + message);
                    writer.WriteLine(" ============================================== ");
                    _logs.Add(DateTime.Now.ToString(CultureInfo.InvariantCulture) + " :::::::::: " + message);
                    _logs.Add(" ============================================== ");
                    writer.Close();
                    stream.Close();
                }
            }
        }
        private static FileInfo GetLogFileInfo(int counter)
        {
            return new FileInfo(FixedValues.LogFolderName + @"\" + DateTime.Now.Year + @"\" + DateTime.Now.Month + @"\" + DateTime.Now.Day + "\\Log_" + counter + ".txt");
        }
        private static DirectoryInfo CreateDirectoryIfIsNotExist()
        {
            DirectoryInfo dir =
                new DirectoryInfo(FixedValues.LogFolderName + @"\" + DateTime.Now.Year + @"\" + DateTime.Now.Month + @"\" +
                                  DateTime.Now.Day);
            if (!dir.Exists)
                dir.Create();

            return dir;
        }
        public static ObservableCollection<string> LoadLogs()
        {
            _logs = new ObservableCollection<string>();
            var dir = CreateDirectoryIfIsNotExist();

            var logFile = GetCurrentLogFile(dir);

            ReadLogs(logFile);

            return _logs;
        }
        private static void ReadLogs(FileInfo logFile)
        {
            FileStream stream = logFile.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            StreamReader reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                _logs.Add(reader.ReadLine());
            }

            reader.Close();
            stream.Close();

        }
    }
}
