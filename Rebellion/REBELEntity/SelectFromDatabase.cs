using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebellionDataBaseModel;

namespace REBELEntity
{
    class SelectFromDatabase
    {

        public SelectFromDatabase()
        {
            //Each Select statement requires
            //SELECT WHAT eg first_name, last_name
            //FROM WHERE eg table - We do not allow the user to select which table
            //therefore it must be set in the class
            //But there MUST be a table and at least ONE thing to select

            //using (var context = new PokeBaseEntities())
            //{
            //    var queryResult = (from p in context.Pokemons
            //                       where p.type == "Fire"
            //                       select p);

            //    foreach (var pokemon in queryResult)
            //    {
            //        Console.WriteLine(pokemon.name);
            //    }
            //}



        }

   
        

        
    }
}
