using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    public static class DataAccessFactory
    {                

                       //return type: IDataAccess
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())   //use switch case 
            {

                case "sql":
                    return new SQLDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                case "list":
                    return new ListDataAccess();

                default: throw new ArgumentException();


            }

        } 

    }
}

