
namespace NoteApp.View
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.Created = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.CategoryName = new System.Windows.Forms.Label();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(12, 62);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(209, 334);
			this.listBox1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(100, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Show category:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(227, 110);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(561, 328);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(287, 81);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 23);
			this.comboBox2.TabIndex = 8;
			// 
			// Created
			// 
			this.Created.AutoSize = true;
			this.Created.Location = new System.Drawing.Point(227, 84);
			this.Created.Name = "Created";
			this.Created.Size = new System.Drawing.Size(54, 15);
			this.Created.TabIndex = 9;
			this.Created.Text = "Created: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(414, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Modified: ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(481, 81);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 23);
			this.comboBox3.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(227, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "Category:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(424, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 25);
			this.label4.TabIndex = 13;
			this.label4.Text = "NoteName";
			// 
			// CategoryName
			// 
			this.CategoryName.AutoSize = true;
			this.CategoryName.Location = new System.Drawing.Point(287, 62);
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.Size = new System.Drawing.Size(53, 15);
			this.CategoryName.TabIndex = 14;
			this.CategoryName.Text = "category";
			this.CategoryName.Click += new System.EventHandler(this.CategoryName_Click);
			// 
			// MenuStrip
			// 
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(61, 4);
			this.MenuStrip.Tag = "";
			this.MenuStrip.Text = "File";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.CategoryName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Created);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label Created;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label CategoryName;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.ContextMenuStrip MenuStrip;
	}
}

