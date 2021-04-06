using System;
using System.Collections.Generic;
using System.Text;
using MonthlyIncome.Tasks;

namespace MonthlyIncome.Tasks.Files
{
    class ProcessFiles : ITask
    {
        string name;
        public ProcessFiles(string pName)
        {
            this.name = pName;
        }
        public string GetName()
        {
            return name;
        }

        public int Run()
        {
            throw new NotImplementedException();
        }
    }
}
