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
        public void OutputDirectory(string path, out FileInfo[] files, out DirectoryInfo[] directories)
        {
            path = logicSearch.ChekingTheCorrectnessPath(path);
            if (path != null)
            {
                files = logicSearch.ListFiles(path);
                directories = logicSearch.ListDirectories(path);
            }
            else { files = null; directories = null; }
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


        LogicFilesBox logicFilesBox = new LogicFilesBox();
        public string AddToPath(string path, string directory)
        {
            path = logicFilesBox.AddToPath_OneClick(path, directory);
            return path;
        }


    }
}
