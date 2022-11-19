using OperatorOverloading_Indexer_Reflection.Models;
using OperatorOverloading_Indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Services
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDatasCount(Predicate<Person> predicate)
        {
            var datas = AddAll();

            var filteredDatas = datas.FindAll(predicate);

            var result = (int)Math.Pow(filteredDatas.Count, 2);

            return result;
        }

        public List<string> GetFullData(Predicate<Person> predicate)
        {
            var datas = AddAll();

            var result = datas.FindAll(predicate);

            return GetPersonDetails(result);
        }

        private List<Person> AddAll()
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person()
            {
                Name = "Rasul",
                Surname = "Hesenov",
                Address = "Xalqlar",
                Salary = 2300
            };
            Person person2 = new Person()
            {
                Name = "Eli",
                Surname = "Veliyev",
                Address = "Gunesli",
                Salary = 900
            };
            Person person3 = new Person()
            {
                Name = "Cesur",
                Surname = "Hesenzade",
                Address = "Ehmedli",
                Salary = 3700
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            return people;
        }

        private List<string> GetPersonDetails(List<Person> people)
        {
            List<string> fullDatas = new List<string>();

            foreach (var item in people)
            {
                string data = $"{item.Name} {item.Surname} {item.Address}";
                fullDatas.Add(data);
            }

            return fullDatas;
        }
    }
}
