namespace RecipeDatabase
{
    partial class Page1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.dataGridView2 = new Wisej.Web.DataGridView();
			this.textBox1 = new Wisej.Web.TextBox();
			this.button1 = new Wisej.Web.Button();
			this.label3 = new Wisej.Web.Label();
			this.button2 = new Wisej.Web.Button();
			this.buttonReload = new Wisej.Web.Button();
			this.dataRepeater1 = new Wisej.Web.DataRepeater();
			this.dataRepeaterPicturebox = new Wisej.Web.PictureBox();
			this.dataRepeaterLabel = new Wisej.Web.Label();
			this.button3 = new Wisej.Web.Button();
			this.button4 = new Wisej.Web.Button();
			this.pdfViewer1 = new Wisej.Web.PdfViewer();
			this.button5 = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
			this.dataRepeater1.ItemTemplate.SuspendLayout();
			this.dataRepeater1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataRepeaterPicturebox)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = true;
			this.dataGridView1.AllowUserToDeleteRows = true;
			this.dataGridView1.Location = new System.Drawing.Point(24, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(399, 309);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellEndEdit += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "dbo.Menu_Items";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(694, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "dbo.Food_Group";
			// 
			// dataGridView2
			// 
			this.dataGridView2.Location = new System.Drawing.Point(449, 70);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(443, 308);
			this.dataGridView2.TabIndex = 4;
			this.dataGridView2.CellEndEdit += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(182, 392);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(148, 30);
			this.textBox1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(66, 437);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Filter";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Enter a food group here";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(612, 395);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 38);
			this.button2.TabIndex = 8;
			this.button2.Text = "Filter based on selected row";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonReload
			// 
			this.buttonReload.Location = new System.Drawing.Point(291, 24);
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new System.Drawing.Size(267, 30);
			this.buttonReload.TabIndex = 9;
			this.buttonReload.Text = "Reload from Database/ clear filters";
			this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
			// 
			// dataRepeater1
			// 
			this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 100);
			// 
			// dataRepeater1.ItemTemplate
			// 
			this.dataRepeater1.ItemTemplate.Controls.Add(this.dataRepeaterPicturebox);
			this.dataRepeater1.ItemTemplate.Controls.Add(this.dataRepeaterLabel);
			this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(462, 100);
			this.dataRepeater1.ItemTemplate.Layout += new Wisej.Web.LayoutEventHandler(this.dataRepeater1_ItemTemplate_Layout);
			this.dataRepeater1.Location = new System.Drawing.Point(927, 94);
			this.dataRepeater1.Name = "dataRepeater1";
			this.dataRepeater1.Size = new System.Drawing.Size(464, 272);
			this.dataRepeater1.TabIndex = 10;
			this.dataRepeater1.Text = "dataRepeater1";
			this.dataRepeater1.CurrentItemIndexChanged += new System.EventHandler(this.dataRepeater1_CurrentItemIndexChanged);
			// 
			// dataRepeaterPicturebox
			// 
			this.dataRepeaterPicturebox.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.dataRepeaterPicturebox.ImageSource = "https://images.unsplash.com/photo-1556761223-4c4282c73f77?ixlib=rb-4.0.3&ixid=Mnw" +
    "xMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=765&q=80";
			this.dataRepeaterPicturebox.Location = new System.Drawing.Point(71, 0);
			this.dataRepeaterPicturebox.Name = "dataRepeaterPicturebox";
			this.dataRepeaterPicturebox.Size = new System.Drawing.Size(100, 100);
			this.dataRepeaterPicturebox.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
			// 
			// dataRepeaterLabel
			// 
			this.dataRepeaterLabel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dataRepeaterLabel.AutoSize = true;
			this.dataRepeaterLabel.Location = new System.Drawing.Point(255, 39);
			this.dataRepeaterLabel.Name = "dataRepeaterLabel";
			this.dataRepeaterLabel.Size = new System.Drawing.Size(4, 18);
			this.dataRepeaterLabel.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(983, 388);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(200, 44);
			this.button3.TabIndex = 11;
			this.button3.Text = "update 1 value";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(852, 536);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 51);
			this.button4.TabIndex = 12;
			this.button4.Text = "transaction";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// pdfViewer1
			// 
			this.pdfViewer1.Location = new System.Drawing.Point(365, 547);
			this.pdfViewer1.Name = "pdfViewer1";
			this.pdfViewer1.Size = new System.Drawing.Size(255, 205);
			this.pdfViewer1.TabIndex = 13;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(405, 488);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(165, 25);
			this.button5.TabIndex = 14;
			this.button5.Text = "load pdf from database";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.pdfViewer1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataRepeater1);
			this.Controls.Add(this.buttonReload);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1046, 334);
			this.Load += new System.EventHandler(this.Page1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.dataRepeater1.ItemTemplate.ResumeLayout(false);
			this.dataRepeater1.ItemTemplate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
			this.dataRepeater1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataRepeaterPicturebox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label3;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button buttonReload;
		private Wisej.Web.DataRepeater dataRepeater1;
		private Wisej.Web.Label dataRepeaterLabel;
		private Wisej.Web.PictureBox dataRepeaterPicturebox;
		private Wisej.Web.Button button3;
		private Wisej.Web.Button button4;
		private Wisej.Web.PdfViewer pdfViewer1;
		private Wisej.Web.Button button5;
	}
}

