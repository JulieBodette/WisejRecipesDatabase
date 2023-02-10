
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
            dataRepeater1.DataSource= foodgroups;
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

        private void buttonReload_Click(object sender, System.EventArgs e)
        {
            //same code as what runs on page load
            menuitems = db.GetMenuItems();
            dataGridView1.DataSource = menuitems;
            foodgroups = db.GetFoodGroups();
            dataGridView2.DataSource = foodgroups;

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AlertBox.Show("stopped editing cell");
            //add code to update the cell value in the database
            Point ca = dataGridView1.CurrentCellAddress;
            AlertBox.Show(dataGridView1.GetValue(ca).ToString());
            //can i get the column of the cell? so i know where to put the data?
            //also the row
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AlertBox.Show("stopped editing cell");
            //add code to update the cell value in the database
            Point ca = dataGridView2.CurrentCellAddress;
            Point firstColumn = new Point(0, ca.Y);
            AlertBox.Show(dataGridView2.GetValue(ca).ToString());
            //can i get the column of the cell? so i know where to put the data?
            //also the row
            db.UpdateFoodGroup(dataGridView2.GetValue(firstColumn).ToString(), dataGridView2.GetValue(ca).ToString());
        }
    }
}
