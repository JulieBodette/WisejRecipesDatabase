
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
            //set up the bindings on the dataRepeater to show text and images
			this.dataRepeaterLabel.DataBindings.Add("Text", foodgroups, "Food_Group");
            this.dataRepeaterPicturebox.DataBindings.Add("ImageSource", foodgroups, "Picture_Link");
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
            //get the cell address of the currently selected cell- use it to get the value to put in an alertbox
            Point ca = dataGridView2.CurrentCellAddress;
            Point firstColumn = new Point(0, ca.Y);
            AlertBox.Show(dataGridView2.GetValue(ca).ToString());

            var selectedRow = this.dataGridView2.SelectedRows[0];
			var FoodGroupCell = selectedRow.Cells["Food_Group"]; //Here we need to send it the name of the column from the data grid view it "Food_Group"
			string foodgroup = (string)FoodGroupCell.Value;
			var IngredientCell = selectedRow.Cells["Main_Ingredients"]; //Main_Ingredients is the name of the column from the database- same as the name of the column in the data grid view. Here we need to send it the name of the column from the data grid view.
            string ingredient = (string)IngredientCell.Value;
			var WhenEatenCell = selectedRow.Cells["When_Eaten"];
			string when = (string)WhenEatenCell.Value;
			var LinkCell = selectedRow.Cells["Picture_Link"];
			string link = (string)LinkCell.Value;
			db.UpdateFoodGroup(foodgroup, ingredient,when, link);

		}


		private void dataRepeater1_ItemTemplate_Layout(object sender, LayoutEventArgs e)
		{
            //label4.Text = dataRepeater1.DisplayedItems[1].Text;
            //label4.Text = dataRepeater1.DataSource.ToString();
			//label4.Text = dataRepeater1.CurrentItem.Controls("lblName").Text
		}

		private void dataRepeater1_CurrentItemIndexChanged(object sender, System.EventArgs e)
		{
            AlertBox.Show("item index changed");
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
            db.UpdateFoodGroupSingleValue("Pizza", "Main_Ingredients", "cheese");
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			//db.FoodTransaction() returns a string showing whether the transaction was successful
			AlertBox.Show(db.FoodTransaction("snacks", "salt", "anytime", "https://images.unsplash.com/photo-1579642761360-eabd1cca1e81?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "chips"));//string foodGroup, string ingredient, string wheneaten, string picturelink
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
            //send it the string
            //use 'Soup' or 'Chicken'
            pdfViewer1.PdfSource = db.GetPDFFilepathFromDatabase("Chicken");
			//pdfViewer1.PdfSource = "C:\\Users\\julie\\Documents\\pdfrecipe\\BeefStewRecipe.pdf";
			//pdfViewer1.PdfSource = "C:\\Users\\julie\\Documents\\pdfrecipe\\ParmesanChickenCasserole.pdf";
		}
	}
}
