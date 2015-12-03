using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebellionDataBaseLibrary.Select
{
    class SelectGroupByID
    {
        public static string FindGroup(int id)
        {
            try
            {
                int ID = id;
                string groupName = String.Empty;
                using (var context = new RebellionDataEntities())
                {
                    groupName = context.Groups.Find(ID).group_name;
                }
                return groupName;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
