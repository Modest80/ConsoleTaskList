using System.Diagnostics;
namespace TaskManConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            Console.Title = "Список процессов";
            Console.WindowWidth = 40;
            Console.BufferWidth = 40;
            Process[] prcs = Process.GetProcesses();
            Console.WriteLine("{0,-28}{1,-10}", "Имя процесса", "PID");
            foreach (Process p in prcs) {
                Console.WriteLine("{0,-28}{1,-10}", p.ProcessName, p.Id);
            }            
        }
    }
}
