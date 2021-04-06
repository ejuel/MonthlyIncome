using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyIncome.Tasks
{
    public interface ITask
    {
        public int Run(); //Returns 1 if successful, 0 if failed, or other int for other message
        public string GetName();
    }
    public interface ITaskManager
    {
        public int Run();
        public string GetName();
        public bool Setup();
    }
}
