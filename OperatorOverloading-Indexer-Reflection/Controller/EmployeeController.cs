using OperatorOverloading_Indexer_Reflection.Services;
using OperatorOverloading_Indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Controller
{
    public class EmployeeController
    {
        public static void GetAverageSalary()
        {
            IEmployeeService employeeService = new EmployeeService();

            Console.WriteLine(employeeService.GetAllByAverageSalary(m => m.Age > 20 & m.Age < 40));
        }
    }
}
