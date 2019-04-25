namespace Inventory.Presentation
{
    partial class FormCreate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intQuantity = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.stringName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type Modified Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Quantity";
            // 
            // intQuantity
            // 
            this.intQuantity.Location = new System.Drawing.Point(213, 70);
            this.intQuantity.MaxLength = 32;
            this.intQuantity.Name = "intQuantity";
            this.intQuantity.Size = new System.Drawing.Size(200, 20);
            this.intQuantity.TabIndex = 5;
            this.intQuantity.TextChanged += new System.EventHandler(this.intQuantity_TextChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(213, 115);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stringName
            // 
            this.stringName.Location = new System.Drawing.Point(213, 23);
            this.stringName.MaxLength = 10000;
            this.stringName.Name = "stringName";
            this.stringName.Size = new System.Drawing.Size(200, 20);
            this.stringName.TabIndex = 9;
            this.stringName.TextChanged += new System.EventHandler(this.stringName_TextChanged);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 225);
            this.Controls.Add(this.stringName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.intQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormCreate";
            this.Load += new System.EventHandler(this.FormCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intQuantity;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox stringName;
    }
}