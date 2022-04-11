using System;
using System.Diagnostics;
using System.Linq;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskkill = Process.GetProcesses();

            foreach (var proc in taskkill)
            {
                Console.WriteLine($"{proc.Id} {proc.ProcessName}");
            }
            Console.Write("Enter name process kill = ");
            var name = Console.ReadLine();
            try
            {
                taskkill.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                Console.WriteLine($"{name} deleted");
            }
            catch
            {
                Console.WriteLine($"Process {name} not kill process!");
            }
        }
    }
}
