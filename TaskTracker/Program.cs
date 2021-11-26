using System;
using TaskTracker.Model;

namespace TaskTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks tasks = new Tasks();

            Execution.Input(tasks);
        }
    }
}
