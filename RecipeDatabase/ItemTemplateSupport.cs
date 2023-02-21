
using Wisej.Web;

namespace RecipeDatabase
{
	public class ItemTemplateSupport : Wisej.Web.UserControl
	{
		private Label label1;
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

		private void InitializeComponent()
		{
			this.label1 = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(264, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "NameLable";
			// 
			// ItemTemplateSupport
			// 
			this.Controls.Add(this.label1);
			this.Name = "ItemTemplateSupport";
			this.Size = new System.Drawing.Size(435, 134);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
