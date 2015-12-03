using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebellionDataBaseLibrary
{
    public class SelectFromDatabase
    {
        public static void SelectFromDatabase(int search)
        {
            string table = String.Empty;

            using (var context = new RebellionDataEntities())
            {
                //I'll figure this out later
            }
        }
    }
}
