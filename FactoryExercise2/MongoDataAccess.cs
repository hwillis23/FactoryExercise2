using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class MongoDataAccess : IDataAccess

    {
        public MongoDataAccess()
        {
        }

        public List<Product> items = new List<Product>()
        {
            new Product() { Name = "Mango", Price = 1 }

        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from Mongo Data Access.");

            return items;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a Mongo Data Access database.");
        }
    }
}
