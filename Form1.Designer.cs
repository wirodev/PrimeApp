namespace PrimeApp
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			txtName = new TextBox();
			btnSave = new Button();
			lblGreeting = new Label();
			txtNumber = new TextBox();
			btnGenerateList = new Button();
			lstNumbers = new ListBox();
			label2 = new Label();
			SuspendLayout();

			// 
			// txtName
			// 
			txtName.Location = new Point(59, 72);
			txtName.Name = "txtName";
			txtName.Size = new Size(245, 23);
			txtName.TabIndex = 0;

			// 
			// btnSave
			// 
			btnSave.Location = new Point(310, 72);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(117, 23);
			btnSave.TabIndex = 1;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += new System.EventHandler(this.btnSave_Click);

			// 
			// lblGreeting
			// 
			lblGreeting.AutoSize = true;
			lblGreeting.Location = new Point(59, 121);
			lblGreeting.Name = "lblGreeting";
			lblGreeting.Size = new Size(38, 15);
			lblGreeting.TabIndex = 2;
			lblGreeting.Text = "Hello!";

			// 
			// txtNumber
			// 
			txtNumber.Location = new Point(59, 161);
			txtNumber.Name = "txtNumber";
			txtNumber.Size = new Size(245, 23);
			txtNumber.TabIndex = 3;

			// 
			// btnGenerateList
			// 
			btnGenerateList.Location = new Point(310, 161);
			btnGenerateList.Name = "btnGenerateList";
			btnGenerateList.Size = new Size(117, 23);
			btnGenerateList.TabIndex = 4;
			btnGenerateList.Text = "Generate List";
			btnGenerateList.UseVisualStyleBackColor = true;
			btnGenerateList.Click += new System.EventHandler(this.btnGenerateList_Click);

			// 
			// lstNumbers
			// 
			lstNumbers.FormattingEnabled = true;
			lstNumbers.ItemHeight = 15;
			lstNumbers.Location = new Point(59, 202);
			lstNumbers.Name = "lstNumbers";
			lstNumbers.Size = new Size(368, 184);
			lstNumbers.TabIndex = 5;

			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(59, 41);
			label2.Name = "label2";
			label2.Size = new Size(108, 15);
			label2.TabIndex = 6;
			label2.Text = "What's your name?";

			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(517, 450);
			Controls.Add(label2);
			Controls.Add(lstNumbers);
			Controls.Add(btnGenerateList);
			Controls.Add(txtNumber);
			Controls.Add(lblGreeting);
			Controls.Add(btnSave);
			Controls.Add(txtName);
			Name = "Form1";
			Text = "Prime Number App";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtName;
		private Button btnSave;
		private Label lblGreeting;
		private TextBox txtNumber;
		private Button btnGenerateList;
		private ListBox lstNumbers;
		private Label label2;
	}
}
