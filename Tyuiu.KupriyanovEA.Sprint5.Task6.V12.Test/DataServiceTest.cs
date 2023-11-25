using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KupriyanovEA.Sprint5.Task6.V12.Lib;

namespace Tyuiu.KupriyanovEA.Sprint5.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\evgeniy\source\repos\Tyuiu.KupriyanovEA.Sprint5\Tyuiu.KupriyanovEA.Sprint5.Task6.V12\bin\Debug\InPutDataFileTask6V12.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
