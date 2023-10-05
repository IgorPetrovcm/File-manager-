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

        public ListBox SearchbyPath(ListBox filesBox, TextBox pathBox1 )
        {
            filesBox.Items.Clear();
            FileInfo[] files;
            List<string> listDirectories = logicControls.OutputDirectories(pathBox1.Text, out files);

            if ((files != null) || (listDirectories != null))
            {
                foreach (string dir in listDirectories) { filesBox.Items.Add(dir); }

                logicControls.OutputDirectories(pathBox1.Text, out files);

                foreach (var file in files) { filesBox.Items.Add(file); }

                return filesBox;
            }
            else return null;

        }

        public void PathBack(TextBox pathBox1, ListBox filesBox)
        {
            pathBox1.Text = logicControls.PathBack(pathBox1.Text);

            SearchbyPath(filesBox, pathBox1);
        }
    }
}
