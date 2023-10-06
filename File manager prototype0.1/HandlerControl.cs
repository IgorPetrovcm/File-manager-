using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_manager_prototype0._1
{
    public partial class HandlerControl
    {
        CompositeLogicControls logicControls = new CompositeLogicControls();

        public ListBox OutputDirectoryInAnyBox(ListBox filesBox, TextBox pathBox1 )
        {
            filesBox.Items.Clear();
            FileInfo[] files;
            DirectoryInfo[] directories;
            logicControls.OutputDirectory(pathBox1.Text, out files,out directories);

            if ((files != null) || (directories != null))
            {
                foreach (DirectoryInfo dir in directories) 
                { 
                    if ((dir.Attributes & FileAttributes.Hidden) == 0)
                    {
                        filesBox.Items.Add(dir);
                    }
                }

                foreach (var file in files) 
                {
                    if ((file.Attributes & FileAttributes.Hidden) == 0)
                    {
                        filesBox.Items.Add(file);
                    }
                }

                return filesBox;
            }
            else return null;

        }

        public ListBox OutputDrivesInAnyBox(ListBox filesBox)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                filesBox.Items.Add(drive);
            }
            return filesBox;
        }

        public void PathBack(TextBox pathBox1, ListBox filesBox)
        {
            pathBox1.Text = logicControls.PathBack(pathBox1.Text);

            OutputDirectoryInAnyBox(filesBox, pathBox1);
        }
    }
}
