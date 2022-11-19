using OperatorOverloading_Indexer_Reflection.Models;
using OperatorOverloading_Indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double GetAllByAverageSalary(Predicate<Employee> predicate)
        {
            var employees = GetAll();

            var result = employees.FindAll(predicate);

            return CalculateAverageSalary(result);
        }

        private List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.Age = 25;
            emp1.Salary = 2500;
            Employee emp2 = new Employee();
            emp2.Age = 15;
            emp2.Salary = 3000;
            Employee emp3 = new Employee();
            emp3.Age = 45;
            emp3.Salary = 4500;
            Employee emp4 = new Employee();
            emp4.Age = 35;
            emp4.Salary = 2800;

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            return employees;
        }

        private double CalculateAverageSalary(List<Employee> employees)
        {
            return employees.Sum(m => m.Salary) / employees.Count;

            //return employees.Average(m => m.Salary);
        }
    }
}
