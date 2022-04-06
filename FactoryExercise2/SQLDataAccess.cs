using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    class SQLDataAccess : IDataAccess
    {
        public List<Product> items = new List<Product>()
        {
            new Product() { Name = "eggs", Price = 2 }
        
        };
        
    public List<Product> LoadData()
        {
            Console.WriteLine("I am reading from SQL Data Access.");
            return items;

        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL Data Access database."); 

        }

    }
}
