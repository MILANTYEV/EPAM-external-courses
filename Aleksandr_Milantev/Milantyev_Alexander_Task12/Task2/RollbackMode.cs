using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Task2
{
    class RollbackMode
    {
        string _path;
        List<FileInfo> rollbackedFiles = new List<FileInfo>();

        public RollbackMode(string path)
        {
            this._path = path;
        }
    
        public void Rollback(DateTime rollbackDate)
        {
            string logFolderPath = GetLogFolderPath();
            DirectoryInfo logFolder;
            try
            {
                logFolder = new DirectoryInfo(logFolderPath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
                return;
            }
            foreach (var file in logFolder.GetFiles(".", SearchOption.AllDirectories))
            {
                string fileName = WatchingMode.GetFileNameWithoutPath(file.FullName);
                if (Regex.IsMatch(file.FullName, ".txt") && isSmallerDate(file, rollbackDate))
                {
                    var rollbackedFile = file;
                    foreach (var comparedFile in logFolder.GetFiles(".", SearchOption.AllDirectories))
                    {
                        
                        if (WatchingMode.GetFileNameWithoutPath(comparedFile.FullName) == WatchingMode.GetFileNameWithoutPath(rollbackedFile.FullName)
                            && isSmallerDate(comparedFile, rollbackDate)
                            && (comparedFile.CreationTime > rollbackedFile.CreationTime))
                        {
                            rollbackedFile = comparedFile;
                        }
                    }
                    rollbackedFiles.Add(rollbackedFile);
                }
            }
            ReplaceRollbackFiles();
        }

        
        private void ReplaceRollbackFiles()
        {
            foreach (var file in rollbackedFiles)
            {
                string name = GetShortNameWithoutTime(file);
                file.MoveTo(file.DirectoryName + "\\" + name);
                File.Delete(Regex.Replace(file.FullName, "log", ""));
                file.MoveTo(Regex.Replace(file.FullName, "log", ""));
            }
        }
        
        private string GetShortNameWithoutTime(FileInfo file)
        {
            string[] parts = file.FullName.Split(new char[] { '\\' });
            string[] fileNameParts = parts[parts.Length - 1].Split(new char[] { '-' });
            return fileNameParts[fileNameParts.Length - 1];
        }
        
        bool isSmallerDate(FileInfo file, DateTime rollbackDate/*string fileName, int year, int month, int day, int hour, int minute, int second*/)
        {
            return file.CreationTime < rollbackDate;
        }

        private string GetLogFolderPath()
        {
            string[] trackingPathFolders = _path.Split(new char[] { '\\' });
            if (trackingPathFolders[trackingPathFolders.Length - 1] != "")
            {
                trackingPathFolders[trackingPathFolders.Length - 1] = "log" + trackingPathFolders[trackingPathFolders.Length - 1];
            }
            else
            {
                trackingPathFolders[trackingPathFolders.Length - 2] = "log" + trackingPathFolders[trackingPathFolders.Length - 2];
            }
            StringBuilder logFolderPath = new StringBuilder();
            foreach (var folder in trackingPathFolders)
            {
                logFolderPath.Append(folder);
                logFolderPath.Append('/');
            }
            return logFolderPath.ToString();
        }
    }
}
