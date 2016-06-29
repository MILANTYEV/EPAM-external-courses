using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2
{
    class WatchingMode
    {
        private static FileSystemWatcher watcher;
        
        public WatchingMode(string folderPath)
        {
            try
            {
                watcher = new FileSystemWatcher(folderPath, "*.txt");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
            }
        }
        
        public void Run()
        {
            watcher.IncludeSubdirectories = true;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
        }
        
        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;  //Для единократного вывода события изменения.
            watcher.EnableRaisingEvents = true;
            string path = GetLogFolderPath(e);
            var dir = Directory.CreateDirectory(path);
            var logFileName = GetLogFileName(e);
            File.Copy(e.FullPath, dir.FullName + logFileName);
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        public static string GetLogFolderPath(FileSystemEventArgs file) //Вернёт путь для создаваемой папки в нужном нам виде, без лишнего.
        {
            string trackingFolder = watcher.Path;
            string[] trackingPathFolders = trackingFolder.Split(new char[] { '\\' });
            string trackingFolderShortName = trackingPathFolders[trackingPathFolders.Length - 1] == ""
                ? trackingPathFolders[trackingPathFolders.Length - 2]
                : trackingPathFolders[trackingPathFolders.Length - 1];
            string filePath;
            if (file is RenamedEventArgs)
            {
                filePath = (file as RenamedEventArgs).OldFullPath;
            }
            else
            {
                filePath = file.FullPath;
            }
            string[] fileDirectories = filePath.Split(new char[] { '\\' });
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < fileDirectories.Length - 1; i++)
            {
                if (fileDirectories[i] == trackingFolderShortName) //ищем в пути к измененному файлу корневую отслеживаемую папку
                {                                                                              
                    strB.Append("log");
                }
                strB.Append(fileDirectories[i]);
                strB.Append("/");
            }
            return strB.ToString();
        }

        public static string GetLogFileName(FileSystemEventArgs file)
        {
            var directories = file.FullPath.Split(new char[] { '\\' });
            StringBuilder strB = new StringBuilder();
            strB.Append(DateTime.Now.Year + "-");
            strB.Append(DateTime.Now.Month + "-");
            strB.Append(DateTime.Now.Day + "-");
            strB.Append(DateTime.Now.Hour + "-");
            strB.Append(DateTime.Now.Minute + "-");
            strB.Append(DateTime.Now.Second + "-");
            strB.Append(DateTime.Now.Millisecond + "-");
            strB.Append(directories[directories.Length - 1]);
            return strB.ToString();
        }

        public static string GetFileNameWithoutPath(string fullFileName)
        {
            string[] FileNameParts = fullFileName.Split(new char[] {'\\'});
            return FileNameParts[FileNameParts.Length - 1];
        }
        
        static string GetLogFileOldDateTime(string logFileName) //Выделить дату и время из имени слогированного файла
        {
            string[] nameParts = logFileName.Split(new char[] { '-' });
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < nameParts.Length - 1; i++)
            {
                strB.Append(nameParts[i]);
                strB.Append("-");
            }
            return strB.ToString();
        }
        
        public static void OnRenamed(object source, RenamedEventArgs e)
        {
            string path = GetLogFolderPath(e);
            DirectoryInfo logDirectory = new DirectoryInfo(path);
            foreach (var file in logDirectory.GetFiles())
            {
                string logFileName = GetFileNameWithoutPath(file.Name);
                string oldFileName = GetFileNameWithoutPath(e.OldName);
                if (Regex.IsMatch(logFileName,"-" + oldFileName))
                {
                    string logTime = GetLogFileOldDateTime(logFileName);
                    string newFileName = GetFileNameWithoutPath(e.Name);
                    file.MoveTo(path + logTime + newFileName);
                }
            }
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}
