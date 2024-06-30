﻿using DIP.GoodExample.Abstraction;
using System;

namespace DIP.GoodExample
{
    public class OracleLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Logger write to oracle db.");
        }
    }
}
