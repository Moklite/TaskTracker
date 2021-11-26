using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskTracker.Model;

namespace TaskTracker
{
    public static class Execution
    {
        public static int TaskId;

        public static void Input(Tasks tasks)
        {
        Start:
            Console.WriteLine("Press 1 to input task or press 2 to display task table: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                tasks.Id = Interlocked.Increment(ref TaskId);

                Console.WriteLine("Please input task: ");
                tasks.ToDo = Console.ReadLine();

                Console.WriteLine("Was the task completed (Yes/No)? ");
                tasks.Completed = Console.ReadLine();

                tasks.DateCreated = DateTime.Now;

                if (tasks.Completed == "Yes")
                {
                    tasks.DateUpated = DateTime.Now;
                }
                else if(tasks.Completed == "No")
                {
                    tasks.DateUpated = null;
                }

                Data.tasks.Add(tasks);
                goto Start;
            }
            else if(input == "2")
            {
                var table = new ConsoleTable("S/N", "To Do", "Completed?", "Date & Time Created", "Date & Time Updated");
                table.AddRow(tasks.Id, tasks.ToDo, tasks.Completed, tasks.DateCreated, tasks.DateUpated);

                table.Write();
            }

        }
    }
}
