using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Enum;

namespace ConsoleApp1.Interface
{
    public interface ICalculatorLogger
    {
        public List<IssueDetail> Issues { get; set; }
        public void AddLog(LogLevel level, string message);
    }
}
