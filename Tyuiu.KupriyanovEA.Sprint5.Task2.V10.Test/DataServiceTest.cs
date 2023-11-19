using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KupriyanovEA.Sprint5.Task2.V10.Lib;

namespace Tyuiu.KupriyanovEA.Sprint5.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\evgeniy\source\repos\Tyuiu.KupriyanovEA.Sprint5\Tyuiu.KupriyanovEA.Sprint5.Task2.V10\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
