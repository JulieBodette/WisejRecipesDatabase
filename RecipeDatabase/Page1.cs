﻿using System.Collections.Generic;
using Wisej.Web;

namespace RecipeDatabase
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        List<MenuItem> menuitems = new List<MenuItem>();
        List<FoodGroup> foodgroups = new List<FoodGroup>();

        private void Page1_Load(object sender, System.EventArgs e)
        {
            DataAccess db = new DataAccess();
            menuitems = db.GetMenuItems();
            dataGridView1.DataSource = menuitems;
            foodgroups = db.GetFoodGroups();
            dataGridView2.DataSource = foodgroups;
        }
    }
}
