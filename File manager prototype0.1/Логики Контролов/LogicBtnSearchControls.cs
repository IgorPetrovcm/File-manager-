using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager_prototype0._1
{
    public class LogicBtnSearchControls
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
        public DirectoryInfo[] ListDirectories(string path)
        {
            var dir = new DirectoryInfo(path);
            DirectoryInfo[] dirArr = dir.GetDirectories();
            return dirArr;
        }
        public FileInfo[] ListFiles(string path)
        {
            var dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            return files;
        }
    }
}
