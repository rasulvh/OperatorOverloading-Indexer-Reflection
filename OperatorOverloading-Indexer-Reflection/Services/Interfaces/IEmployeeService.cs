using OperatorOverloading_Indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Services.Interfaces
{
    public interface IEmployeeService
    {
        public double GetAllByAverageSalary(Predicate<Employee> predicate);
    }
}
