using OperatorOverloading_Indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading_Indexer_Reflection.Services.Interfaces
{
    public interface IPersonService
    {
        public List<string> GetFullData(Predicate<Person> predicate);

        public int GetFilteredDatasCount(Predicate<Person> predicate);
    }
}
