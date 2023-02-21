using System;
using Wisej.Web;

namespace RecipeDatabase
{
	public partial class DataRepeaterBox : Wisej.Web.UserControl
	{
		public DataRepeaterBox()
		{
			InitializeComponent();
		}

		private void DataRepeaterBox_Load(object sender, EventArgs e)
		{
			//this.pictureBox1.DataBindings.Add() //property datasource datamember
			//this.textBox1.DataBindings.Add("Text", this.dataSource, "FirstName");
		}
	}
}
