using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RecipeDatabase
{
    public class DataAccess
    {
        public List<MenuItem> GetMenuItems()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                var output = connection.Query<MenuItem>("select * from Menu_Items").ToList();
                return output;
            }
        }
    }
}
