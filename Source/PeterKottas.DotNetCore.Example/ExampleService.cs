﻿using PeterKottas.DotNetCore.WindowsService.Interfaces;
using System;
using System.IO;
using System.Diagnostics;

namespace PeterKottas.DotNetCore.Example
{
    public class ExampleService : IMicroService
    {
        private string fileName = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "log.txt");
        public void Start()
        {
            Console.WriteLine("I started");
            File.AppendAllText(fileName, "Started\n");
        }

        public void Stop()
        {
            File.AppendAllText(fileName, "Stopped\n");
            Console.WriteLine("I stopped");
        }
    }
}
