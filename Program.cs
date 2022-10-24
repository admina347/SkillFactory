using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace module13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("/home/admina/Документы/C-sharp курс/module13/Text1.txt");
                Dictionary<string, int> dr = new Dictionary<string, int>();
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    line = Regex.Replace(line, @",\r?\n", "");
                    string pattern = @"\s+";
                    string target = " ";
                    Regex regex = new Regex(pattern);
                    string result = regex.Replace(line, target);
                    //Пытался убрать лишние пробелы и перенос тсроки, но что-то так и не получилось.
                    var noPunctuationText = new string(result.Where(c => !char.IsPunctuation(c)).ToArray());
                    //Приведем текст в массив слов
                    string[] ArString = noPunctuationText.Split(' ');
                    //Размещаем слова в словаре и подсчитываем частотность
                    foreach (string s in ArString)
                        if (dr.Keys.Contains(s)) dr[s]++;
                        else dr.Add(s, 1);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

                string S = ""; int k = 0;
                //Отбираем 10 наиболее частотных слов и в нашем случае отображем их в сообщении
                foreach (KeyValuePair<string, int> kk in dr.OrderByDescending(x => x.Value))
                {
                    S += kk.Key + " " + kk.Value.ToString() + "\n";
                    k = k + 1;
                    if (k == 10) break;
                }
                Console.WriteLine(S);
                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}