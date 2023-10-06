using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager_prototype0._1
{
    public class LogicBtnPathBack
    {
        public LogicBtnPathBack() { }
        public string PathRemove(string path, int numberDeletions)
        {
            char[] dividedPathIntoChar = new char[path.Length];
            int count = 0;
            foreach (char unit in path)
            {
                dividedPathIntoChar[count] = unit;
                count++;
            }

            int countSlash = 0;
            for (int i = dividedPathIntoChar.Length - 1; i >= 0; i--)
            {
                if (countSlash >= numberDeletions)
                {
                    if (dividedPathIntoChar[i] != '\\') { dividedPathIntoChar[i] = '+'; }
                    else break;
                }
                else
                {
                    if (dividedPathIntoChar[i] == '\\') { countSlash++; dividedPathIntoChar[i] = '+'; }
                }
            }

            string removePath = "";
            foreach (char unit in dividedPathIntoChar)
            {
                if (unit == '+') break;
                removePath += unit;
            }

            return removePath;
        }
    }
}
