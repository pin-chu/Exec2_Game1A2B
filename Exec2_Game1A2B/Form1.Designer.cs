
namespace Exec2_Game1A2B
{
	partial class Form1
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
			this.CalcButton = new System.Windows.Forms.Button();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NewButton = new System.Windows.Forms.Button();
			this.ShowTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CalcButton
			// 
			this.CalcButton.Location = new System.Drawing.Point(272, 107);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(94, 29);
			this.CalcButton.TabIndex = 0;
			this.CalcButton.Text = "Star";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(125, 107);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(125, 27);
			this.InputTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "輸入:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "請輸入4個數字";
			// 
			// NewButton
			// 
			this.NewButton.Location = new System.Drawing.Point(272, 33);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(94, 29);
			this.NewButton.TabIndex = 0;
			this.NewButton.Text = "新遊戲";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// ShowTextBox
			// 
			this.ShowTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ShowTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.ShowTextBox.Location = new System.Drawing.Point(55, 176);
			this.ShowTextBox.Name = "ShowTextBox";
			this.ShowTextBox.Size = new System.Drawing.Size(215, 27);
			this.ShowTextBox.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 461);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ShowTextBox);
			this.Controls.Add(this.InputTextBox);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.CalcButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CalcButton;
		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.TextBox ShowTextBox;
	}
}

