using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Enum;
using ConsoleApp1.Interface;

namespace ConsoleApp1
{
    public class CalculatorLogger : ICalculatorLogger
    {
        public List<IssueDetail> Issues { get; set; }

        public void AddLog(LogLevel level, string message)
        {
            Issues.Add(new IssueDetail { Level = level, Message = message });
        }
    }
}
