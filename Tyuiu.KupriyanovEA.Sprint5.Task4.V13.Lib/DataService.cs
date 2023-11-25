using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KupriyanovEA.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x; 
            x = Convert.ToDouble(strX);
            double res = Math.Cos(x) + (Math.Pow(x, 2) / 2);
            return Math.Round(res, 3);
        }
    }
}
