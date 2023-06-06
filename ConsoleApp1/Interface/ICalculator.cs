using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface
{
    public interface ICalculator
    {
        public ServiceResult<double> Divide(double x, double y);
    }
}
