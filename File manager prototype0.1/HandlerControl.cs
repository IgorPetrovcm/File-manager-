using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_manager_prototype0._1
{
    public partial class HandlerControl
    {
        public static string pathFolders;
        public static DirectoryInfo[] dynamicDirectories;


        public static string MethodInputPath(string path)
        {
            if (path != null)
            {
                pathFolders = path;
                return pathFolders;
            }
            return path;
        }

        public static DirectoryInfo[] MethodSearchDirectories(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                if (directory.Exists)
                {
                    dynamicDirectories = directory.GetDirectories();
                    return dynamicDirectories;
                }
                return null;
            }
            return null;
        }
        public static FileInfo[] MethodSearchFiles(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                if (directory.Exists)
                {
                    FileInfo[] files = directory.GetFiles();
                    return files;
                }
                return null;
            }
            return null;
        }
    }
    public partial class HandlerControl_ReadDirectory : HandlerControl
    {
        //public static char[] unitFromCharsInFolder;
        public static char[] MethodReadDirectory(string path)
        {
            char[] unitFromCharsInFolder = new char[path.Length];
            int cout = 0;
            foreach (char unit in pathFolders)
            {
                unitFromCharsInFolder[cout] = unit;
                cout++;
            }
            return unitFromCharsInFolder;
        }

        public static string MethodRemovePath(char[] unitChars)
        {
            string text = "";
            int coutSlash = 0;
            for (int i = unitChars.Length-1; i >= 0;i--)
            {
                if (coutSlash != 0)
                {
                    if (unitChars[i] != '\\')
                    {
                        unitChars[i] = '+';
                    }
                    else break;
                }
                else
                {
                    if (unitChars[i] == '\\') { coutSlash++; unitChars[i] = '+'; }
                }
            }
            foreach (char unit in unitChars)
            {
                if (unit == '+') break;
                text += unit;
            }
            if (text != null) pathFolders = text;
            return text;
        }
    }     
}
