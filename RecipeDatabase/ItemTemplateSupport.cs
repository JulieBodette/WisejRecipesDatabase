
using Wisej.Web;

namespace RecipeDatabase
{
	public class ItemTemplateSupport : Wisej.Web.UserControl
	{
		Label foodLabel;
		public ItemTemplateSupport() { 
		foodLabel = new Label();
		}
		/*
		public string Picture
		{
			get => pictureBox1.Text;
			set { pictureBox1.Text = value; }
		}
		*/
		public string FoodGroupName
		{
			get => foodLabel.Text;
			set { foodLabel.Text = value; }
		}

	}
}
