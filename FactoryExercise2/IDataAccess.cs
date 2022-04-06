using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
     public interface IDataAccess
    {
        public List<Product> LoadData(); //return type needs to be a list because have data 

        public void SaveData();

    }
}
