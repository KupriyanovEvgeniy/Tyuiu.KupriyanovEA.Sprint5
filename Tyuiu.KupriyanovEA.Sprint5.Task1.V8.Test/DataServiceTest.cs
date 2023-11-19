﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

namespace Tyuiu.KupriyanovEA.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\evgeniy\source\repos\Tyuiu.KupriyanovEA.Sprint5\Tyuiu.KupriyanovEA.Sprint5.Task1.V8\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
