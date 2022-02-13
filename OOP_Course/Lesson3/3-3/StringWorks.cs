using System;
using System.IO;
using System.Text;

namespace OOP_Course.Lesson3._3_3
{
    internal class StringWorks
    {
        public static void ParseMail()
        {
            var openFilePath = "Files\\FIOMail.txt";
            using var openFile = File.OpenText(openFilePath);
            var fileString = openFile.ReadLine();
            SearchMail(ref fileString);
            SaveMailToFile(ref fileString);
        }

        private static void SearchMail(ref string s)
        {
            var separationChar = '&';
            var sb = new StringBuilder();
            var maxLen = s.Length-1;
            for (int i = 0; i <= maxLen; i++)
            {
                if (s[i] != separationChar && i <= maxLen)
                    i++;
                else
                {
                    while (!Char.IsLetterOrDigit(s[i]) && i <= maxLen) //пробелов может быть несколько
                        i++;
                    while (i <= maxLen && s[i] != ' ')
                    {
                        sb.Append(s[i]);
                        i++;
                    }
                    sb.Append(Environment.NewLine);
                }
            }
            s = sb.ToString();
        }

        private static void SaveMailToFile(ref string fileString)
        {
            var saveFilePath = "Files\\Mail.txt";
            File.WriteAllText(saveFilePath, fileString, Encoding.UTF8);
        }
    }
}
