using OperatorOverloading_Indexer_Reflection.Models;
using OperatorOverloading_Indexer_Reflection.Services;
using OperatorOverloading_Indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Controller
{
    public class PersonController
    {
        public static void ShowAll()
        {
            IPersonService personService = new PersonService();

            var result = personService.GetFullData(m => m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetFilteredPersonsPowCount()
        {
            IPersonService personService = new PersonService();

            Console.WriteLine(personService.GetFilteredDatasCount(m=>m.Name.ToLower().StartsWith("c")));
        }
    }
}
