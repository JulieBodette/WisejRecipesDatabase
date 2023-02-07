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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using SQL query sent in by text
                //var output = connection.Query<MenuItem>("select * from Menu_Items").ToList();
                //using stored procedure
                var output = connection.Query<MenuItem>("dbo.GetAllMenuItem").ToList();
                return output;
            }
        }

        public List<FoodGroup> GetFoodGroups()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using SQL query sent in by text
                //var output = connection.Query<FoodGroup>("select * from Food_Group").ToList();
                //using stored procedure
                var output = connection.Query<FoodGroup>("dbo.GetAllFoodGroup").ToList();
                return output;
            }
        }

        public List<MenuItem> GetMenuItemsWithSameFoodGroup(string foodGroup)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using stored procedure
                var output = connection.Query<MenuItem>("dbo.GetMenuItemsWithSameFoodGroup @FoodGroup", new { FoodGroup = foodGroup }).ToList();
                return output;
            }
        }
        //write more functions here with more queries
        //I think they have to return a List<MenuItem> or a List<FoodGroup>??
        public void UpdateFoodGroup(string foodGroup, string whenEaten)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Recipes")))
            {
                //using stored procedure
                connection.Execute("dbo.UpdateFoodGroup @Food_Group, @When_Eaten", new FoodGroup { Food_Group = foodGroup, When_Eaten = whenEaten });

            }
        }
    }
}
