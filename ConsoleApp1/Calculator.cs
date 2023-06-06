using ConsoleApp1.Enum;
using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Calculator : ICalculator
    {
        private ICalculatorLogger _logger { get; set; }

        public Calculator(ICalculatorLogger logger)
        {
            _logger = logger;
        }

        public ServiceResult<double> Divide(double x, double y)
        {
            _logger.AddLog(LogLevel.Information, $"Iniciando {nameof(Divide)} na classe {nameof(Calculator)}");
            var result = new ServiceResult<double>();

            try
            {
                if (y == 0)
                {
                    throw new Exception();
                }
                
                result.Result = x / y;
            }
            catch
            {
                var issueDetail = new IssueDetail
                {
                    Level = LogLevel.Error,
                    Message = $"Erro em {nameof(Divide)} na classe {nameof(Calculator)}"
                }; 
                
                result.Status = false;
                result.Result = 0;
                result.Issues.Add(issueDetail);

                _logger.AddLog(issueDetail.Level, issueDetail.Message);
            }

            _logger.AddLog(LogLevel.Information, $"Finalizando {nameof(Divide)} na classe {nameof(Calculator)}");

            return result;
        }
    }
}
