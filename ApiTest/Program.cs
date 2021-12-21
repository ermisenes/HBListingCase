using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Scenarios Documents : ApiTest\\Scenarios");
            string scenarioNumber = string.Empty;
            while (true)
            {
                try
                {
                    string path = string.Empty;
                    List<string> list;
                    switch (scenarioNumber)
                    {
                        case "1":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Scenarios\\Scenario1.txt");
                            list = FileReader.FileOperattion(path);
                            break;
                        case "2":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Scenarios\\Scenario2.txt");
                            list = FileReader.FileOperattion(path);
                            break;
                        case "3":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Scenarios\\Scenario3.txt");
                            list = FileReader.FileOperattion(path);
                            break;
                        case "4":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Scenarios\\Scenario4.txt");
                            list = FileReader.FileOperattion(path);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Select Scenario (exaple: 1,2,3,4)");
                scenarioNumber = Console.ReadLine();
            }
        }         
    }
}
