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

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> listDrivesName = logicControls.AddDrivesInLoadForm();
            foreach (string name in listDrivesName) { cmbDrivesListBox.Items.Add(name); }
        }

        private void btnSearchbyPath_Click(object sender, EventArgs e)
        {
            filesBox.Items.Clear();
            FileInfo[] files;
            List<string> listDirectories = logicControls.OutputDirectories(pathBox1.Text, out files);
            foreach (string dir in listDirectories) { filesBox.Items.Add(dir); }

            logicControls.OutputDirectories(pathBox1.Text, out files);

            foreach (var file in files) { filesBox.Items.Add(file); }
        }

        private void btnPathBack_Click(object sender, EventArgs e)
        {
            pathBox1.Text = logicControls.PathBack(pathBox1.Text);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            pathBox1.Text = logicControls.PathBack(pathBox1.Text);

            filesBox.Items.Clear();
            FileInfo[] files;
            List<string> listDirectories = logicControls.OutputDirectories(pathBox1.Text, out files);
            foreach (string dir in listDirectories) { filesBox.Items.Add(dir); }


            foreach (var file in files) { filesBox.Items.Add(file); }
        }

        private void filesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var file = filesBox.SelectedItem;
            if (file is FileInfo)
            {
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

        }
    }
}
