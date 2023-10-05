using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager_prototype0._1
{
    public class CompositeLogicControls
    {
        LogicBtnSearchControls logicSearch = new LogicBtnSearchControls();

        public List<string> OutputDirectories(string path, out FileInfo[] files)
        {
            path = logicSearch.ChekingTheCorrectnessPath(path);
            if (path != null)
            {
                files = logicSearch.ListFiles(path);
                List<string> directories = logicSearch.ListDirectories(path);

                return directories;
            }
            else { files = null; return null; }
        }

        protected class LogicBtnSearchControls
        {
            public LogicBtnSearchControls() { }
            public string ChekingTheCorrectnessPath(string path)
            {
                if (Directory.Exists(path) == true)
                {
                    return path;
                }
                else { return null; }
            }
            public List<string> ListDirectories(string path)
            {
                var dir = new DirectoryInfo(path);
                DirectoryInfo[] dirArr = dir.GetDirectories();
                List<string> dirsNames = new List<string>();
                foreach (var name in dirArr)
                {
                    if ((name.Attributes & FileAttributes.Hidden) == 0)
                    {
                        dirsNames.Add(name.Name);
                    }
                }
                return dirsNames;
            }
            public FileInfo[] ListFiles(string path)
            {
                var dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles();
                return files;
            }

        }

        LogicBtnPathBack logicPathBack = new LogicBtnPathBack();
        public string PathBack(string path)
        {
            if (Directory.Exists(path))
            {
                path = logicPathBack.PathRemove(path, 1);
                return path;
            }
            else return null;
        }
        protected class LogicBtnPathBack
        {
            public LogicBtnPathBack() { }
            public string PathRemove(string path, int numberDeletions)
            {
                char[] dividedPathIntoChar = new char[path.Length];
                int count = 0;
                foreach (char unit in path)
                {
                    dividedPathIntoChar[count] = unit;
                    count++;
                }

                int countSlash = 0;
                for (int i = dividedPathIntoChar.Length - 1; i >= 0; i--)
                {
                    if (countSlash >= numberDeletions)
                    {
                        if (dividedPathIntoChar[i] != '\\') { dividedPathIntoChar[i] = '+'; }
                        else break;
                    }
                    else
                    {
                        if (dividedPathIntoChar[i] == '\\') { countSlash++; dividedPathIntoChar[i] = '+'; }
                    }
                }

                string removePath = "";
                foreach (char unit in dividedPathIntoChar)
                {
                    if (unit == '+') break;
                    removePath += unit;
                }

                return removePath;
            }
        }

        LogicFilesBox logicFilesBox = new LogicFilesBox();
        public string AddToPath(string path, string directory)
        {
            path = logicFilesBox.AddToPath_OneClick(path, directory);
            return path;
        }
        protected class LogicFilesBox
        {
            public LogicFilesBox() { }
            public string AddToPath_OneClick(string path, string directory)
            {
                path += directory + @"\";
                if (Directory.Exists(path) == false)
                {
                    LogicBtnPathBack logicPathBack = new LogicBtnPathBack();
                    path = logicPathBack.PathRemove(path, 2);
                    path += directory + @"\";

                    return path;
                }
                else return path;

            }
        }

        LogicCmbDrivesBox logicCmbDrivesBox = new LogicCmbDrivesBox();
        public List<string> AddDrivesInLoadForm()
        {
            List<string> names = logicCmbDrivesBox.AddDrivesToDrivesBox();
            return names;
        }
        protected class LogicCmbDrivesBox
        {
            public LogicCmbDrivesBox() { }
            public List<string> AddDrivesToDrivesBox()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                List<string> drivesToBoxName = new List<string>();
                foreach (DriveInfo name in drives)
                {
                    drivesToBoxName.Add(name.Name);
                }
                return drivesToBoxName;
            }
        }
    }
}
