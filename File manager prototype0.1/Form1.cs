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
        CompositeLogicControls logicControls = new CompositeLogicControls();
        HandlerControl handlerControl = new HandlerControl();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchbyPath_Click(object sender, EventArgs e)
        {
            filesBox = handlerControl.OutputDirectoryInAnyBox(filesBox, pathBox1);
        }

        private void btnPathBack_Click(object sender, EventArgs e)
        {
            pathBox1.Text = logicControls.PathBack(pathBox1.Text);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            handlerControl.PathBack(pathBox1, filesBox);
        }

        private void filesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var file = filesBox.SelectedItem;
            if (file == null) { return; }
            if (file is FileInfo)
            {
                return;
            }

            pathBox1.Text = logicControls.AddToPath(pathBox1.Text, filesBox.SelectedItem.ToString());

        }


        private void filesBox_DoubleClick(object sender, EventArgs e)
        {
            var path = filesBox.SelectedItem;
            if (path == null)
            {
                return;
            }
            if (path.GetType().ToString() == "System.IO.DirectoryInfo")
            {
                handlerControl.OutputDirectoryInAnyBox(filesBox, pathBox1);
            }
            if (path.GetType().ToString() == "System.IO.DriveInfo")
            {
                handlerControl.OutputDrivesInAnyBox(filesBox);
                handlerControl.OutputDirectoryInAnyBox(filesBox, pathBox1);

            }
        }

        private void filesBox_MouseEnter(object sender, EventArgs e)
        {
            if (filesBox.Items.Count == 0)
            {
                filesBox = handlerControl.OutputDrivesInAnyBox(filesBox);
            }
        }

    }
}
