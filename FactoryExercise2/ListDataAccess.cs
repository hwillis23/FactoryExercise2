using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class ListDataAccess : IDataAccess
    {
        public static List<Product> items = new List<Product>()
        {
            new Product() { Name = "bread", Price = 3 }

        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from List Data Access.");

            return items;

        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL Data Access database.");
        }
    }
}
