using System;
using System.Collections.Generic;

namespace FactoryExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use? List, SQL, Mongo?");
            var userAnswer = Console.ReadLine();

            IDataAccess database=DataAccessFactory.GetDataAccessType(userAnswer); //instance of a class and a object; take userAnswer to get return
            List<Product> items = database.LoadData();  //List of database from Loaddata method 
            foreach(var item in items) //to print each item from the list 
            {

                Console.WriteLine($"Product: {item.Name} Price: ${item.Price}");

            }

            database.SaveData();



        }
    }
}
