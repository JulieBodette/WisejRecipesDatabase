
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
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
        DataAccess db = new DataAccess();

        private void Page1_Load(object sender, System.EventArgs e)
        {
            
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            //update the datagrid view based on the foodgroup from the textbox
            menuitems = db.GetMenuItemsWithSameFoodGroup(textBox1.Text);
            dataGridView1.DataSource = menuitems;

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //update the datagrid view based on the selected foodgroup
            Point ca = dataGridView2.CurrentCellAddress;
            menuitems = db.GetMenuItemsWithSameFoodGroup(dataGridView2.GetValue(ca).ToString());
            dataGridView1.DataSource = menuitems;
            //slightly awkward- you have to select the specific cell and not just the row
        }
    }
}
