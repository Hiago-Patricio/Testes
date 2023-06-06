using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ServiceResult<T>
    {
        public T Result { get; set; }
        public bool Status { get; set; }
        public List<IssueDetail> Issues { get; set; }

        public ServiceResult() { 
            Issues = new List<IssueDetail>();
            Status = true;
        }
    }
}
