using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyIncome.Tasks
{
    class TaskManager : ITaskManager
    {
        List<ITask> tasks;
        public TaskManager()
        {
            Setup();
        }
        public bool Setup()
        {
            tasks = new List<ITask>();

            //Add tasks here:
            tasks.Add(new Files.ProcessFiles("Process Incoming Files"));

            return true;
        }
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int Run()
        {
            foreach (ITask task in tasks)
            {
                Console.WriteLine($"Running task: {task.GetName()}");
                task.Run();
            }
            return 1;
        }

    }
}
