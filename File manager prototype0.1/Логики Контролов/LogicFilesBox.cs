using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager_prototype0._1
{
    public class LogicFilesBox
    {
        public LogicFilesBox() { }
        public string AddToPath_OneClick(string path, string directory)
        {
            if (path == "")
            {
                path += directory;
                return path;
            }
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (path == drive.Name)
                {
                    foreach (DriveInfo drive2 in drives)
                    {
                        if (directory == drive2.Name)
                        {
                            path = directory;
                            return path;
                        }
                    }
                }
            }

            path += directory + @"\";

            if (Directory.Exists(path) == false)
            {
                LogicBtnPathBack logicPathBack = new LogicBtnPathBack();
                path = logicPathBack.PathRemove(path, 2);
                path += directory + @"\";

                return path;
            }
            else { return path; }

        }
    }
}
