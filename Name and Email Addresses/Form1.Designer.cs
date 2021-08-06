
namespace Name_and_Email_Addresses
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.ContactGroupBox = new System.Windows.Forms.GroupBox();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NameOutput = new System.Windows.Forms.Label();
            this.EmailOutput = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ContactGroupBox.SuspendLayout();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NamesListBox);
            this.panel1.Location = new System.Drawing.Point(42, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 410);
            this.panel1.TabIndex = 0;
            // 
            // NamesListBox
            // 
            this.NamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 20;
            this.NamesListBox.Location = new System.Drawing.Point(28, 22);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(357, 364);
            this.NamesListBox.TabIndex = 0;
            this.NamesListBox.SelectedIndexChanged += new System.EventHandler(this.NamesListBox_SelectedIndexChanged);
            // 
            // ContactGroupBox
            // 
            this.ContactGroupBox.Controls.Add(this.EmailOutput);
            this.ContactGroupBox.Controls.Add(this.NameOutput);
            this.ContactGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactGroupBox.Location = new System.Drawing.Point(480, 59);
            this.ContactGroupBox.Name = "ContactGroupBox";
            this.ContactGroupBox.Size = new System.Drawing.Size(387, 351);
            this.ContactGroupBox.TabIndex = 1;
            this.ContactGroupBox.TabStop = false;
            this.ContactGroupBox.Text = "Contact";
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.EmailInput);
            this.AddGroupBox.Controls.Add(this.label2);
            this.AddGroupBox.Controls.Add(this.NameInput);
            this.AddGroupBox.Controls.Add(this.label1);
            this.AddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGroupBox.Location = new System.Drawing.Point(905, 59);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(387, 351);
            this.AddGroupBox.TabIndex = 2;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "Add New Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(51, 109);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(282, 26);
            this.NameInput.TabIndex = 1;
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(6, 190);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(375, 26);
            this.EmailInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email: ";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(905, 430);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(387, 39);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add Contact";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(631, 519);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(118, 39);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NameOutput
            // 
            this.NameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOutput.Location = new System.Drawing.Point(58, 73);
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(272, 88);
            this.NameOutput.TabIndex = 0;
            this.NameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailOutput
            // 
            this.EmailOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailOutput.Location = new System.Drawing.Point(25, 202);
            this.EmailOutput.Name = "EmailOutput";
            this.EmailOutput.Size = new System.Drawing.Size(340, 88);
            this.EmailOutput.TabIndex = 1;
            this.EmailOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(480, 430);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(387, 39);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete this contact?";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 570);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.ContactGroupBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Name and  Email Addresses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ContactGroupBox.ResumeLayout(false);
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.GroupBox ContactGroupBox;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label EmailOutput;
        private System.Windows.Forms.Label NameOutput;
        private System.Windows.Forms.Button DeleteButton;
    }
}

