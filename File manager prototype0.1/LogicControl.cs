using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager_prototype0._1
{
    public class LogicControl
    {
        public LogicControl() { }
        public List<string> GetDrivesBox()
        {
            List<string> listDrives = new List<string>();
            foreach (var drive in DriveInfo.GetDrives())
            {
                listDrives.Add(drive.Name);
            }
            return listDrives;
        }


    }
}
