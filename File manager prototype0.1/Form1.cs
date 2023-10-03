using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace File_manager_prototype0._1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            btnReadFile.Enabled = false;  
            btnShow.Enabled = false;

        }


        private void GetInput()
        {
            BoxFolderManager.Items.Clear();
            HandlerControl objectHandlerControl = new HandlerControl();


            string dynamicPath = objectHandlerControl.MethodInputPath(EditingPath.Text);
            DirectoryInfo[] directories = objectHandlerControl.MethodSearchDirectories(dynamicPath);
            FileInfo[] files = objectHandlerControl.MethodSearchFiles(dynamicPath);

            foreach (var item in directories)
            {
                if ((item.Attributes & FileAttributes.Hidden) == 0)
                {
                    BoxFolderManager.Items.Add(item);
                   
                }
            }
            foreach (var file in files)
            {
                if ((file.Attributes & FileAttributes.Hidden) == 0)
                {
                    string fileInFolder = file.Name + "." + file.Attributes;
                    BoxFolderManager.Items.Add(file);
                }
            }
        }
        private void RemovePath()
        {
            HandlerControl_ReadDirectory objectHandlerControl_readDirectory = new HandlerControl_ReadDirectory();

            char[] chars = objectHandlerControl_readDirectory.MethodReadDirectory(EditingPath.Text);
            EditingPath.Text = objectHandlerControl_readDirectory.MethodRemovePath(chars);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetInput();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n /select, {EditingPath.Text}" });
        }

        private void BoxFolderManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReadFile.Enabled = false;

            var file = BoxFolderManager.SelectedItem;
            if (file is FileInfo)
            {
                btnShow.Enabled = true;

                string fileAttribute = BoxFolderManager.Text;
                if (fileAttribute.Contains(".txt"))
                {
                    btnReadFile.Enabled = true;
                    return;
                }
                return;
            }
            btnShow.Enabled = true;

            EditingPath.Text += BoxFolderManager.Text + @"\";
        }
       

        private void btnReturnToFolder_Click(object sender, EventArgs e)
        {
            RemovePath();
            GetInput();
        }

        private void btnRemovePartOfPath_Click(object sender, EventArgs e)
        {
            RemovePath();
        }


        //Локига бокса дисков-----------------------------------
        private void Form1_LoadInBox(object sender, EventArgs e)
        {
            LogicControl logicAllControl = new LogicControl();
            List<string> listDrives = logicAllControl.GetDrivesBox();
            foreach (string drive in listDrives) { drivesBox.Items.Add(drive); }
        }
        private void drivesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditingPath.Text = drivesBox.Text;
        }
    }
}
