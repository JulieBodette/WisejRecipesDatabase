using System.Collections.Generic;
using System.Drawing;
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

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            Point ca = dataGridView1.CurrentCellAddress;
            AlertBox.Show(dataGridView1.CurrentCellAddress.ToString());
            AlertBox.Show(dataGridView1.CurrentRow.ToString());
            AlertBox.Show(dataGridView1.GetValue(ca).ToString());
        }
    }
}
