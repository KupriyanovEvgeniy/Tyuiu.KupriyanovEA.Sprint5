using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KupriyanovEA.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (2*x - 2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2)), 2);
                }
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
