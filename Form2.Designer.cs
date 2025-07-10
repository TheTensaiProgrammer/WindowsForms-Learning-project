namespace shopwithui
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.Button();
            this.ShopInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input For User Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Open Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Input For Shop Data";
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(138, 70);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(75, 23);
            this.UserInput.TabIndex = 33;
            this.UserInput.Text = "Open";
            this.UserInput.UseVisualStyleBackColor = true;
            this.UserInput.Click += new System.EventHandler(this.UserInput_Click_1);
            // 
            // ShopInput
            // 
            this.ShopInput.Location = new System.Drawing.Point(138, 107);
            this.ShopInput.Name = "ShopInput";
            this.ShopInput.Size = new System.Drawing.Size(75, 23);
            this.ShopInput.TabIndex = 34;
            this.ShopInput.Text = "Open";
            this.ShopInput.UseVisualStyleBackColor = true;
            this.ShopInput.Click += new System.EventHandler(this.ShopInput_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*\" (Parameter \'value\')";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 157);
            this.Controls.Add(this.ShopInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Button UserInput;
        private Button ShopInput;
        private OpenFileDialog openFileDialog1;
    }
}