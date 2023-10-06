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
            /*List<string> listDrivesName = logicControls.AddDrivesInLoadForm();
            foreach (string name in listDrivesName) { cmbDrivesListBox.Items.Add(name); }*/
            filesBox = handlerControl.OutputDrivesInAnyBox(filesBox);
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
            if (file is FileInfo)
            {
                return;
            }
            if (file is DriveInfo)
            {
                pathBox1.Text = filesBox.SelectedItem.ToString();
                pathBox1.Text = logicControls.AddToPath(pathBox1.Text, filesBox.SelectedItem.ToString());

                return;
            }
            pathBox1.Text = logicControls.AddToPath(pathBox1.Text, filesBox.SelectedItem.ToString());

        }

        private void cmbDrivesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathBox1.Text = cmbDrivesListBox.Text;

        }

        private void filesBox_DoubleClick(object sender, EventArgs e)
        {
            var path = filesBox.SelectedItem;
            if (path.GetType().ToString() == "System.IO.DirectoryInfo")
            {
                handlerControl.OutputDirectoryInAnyBox(filesBox, pathBox1);
            }
            if (path.GetType().ToString() == "System.IO.DriveInfo")
            {
                handlerControl.OutputDrivesInAnyBox(filesBox);
            }
        }
    }
}
