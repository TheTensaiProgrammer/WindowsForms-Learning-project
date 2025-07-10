namespace shopwithui
{
    partial class SavePrompt
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
            this.ShopInput = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ShopInput
            // 
            this.ShopInput.Location = new System.Drawing.Point(138, 109);
            this.ShopInput.Name = "ShopInput";
            this.ShopInput.Size = new System.Drawing.Size(75, 23);
            this.ShopInput.TabIndex = 39;
            this.ShopInput.Text = "Save";
            this.ShopInput.UseVisualStyleBackColor = true;
            this.ShopInput.Click += new System.EventHandler(this.ShopInput_Click_1);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(138, 72);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(75, 23);
            this.UserInput.TabIndex = 38;
            this.UserInput.Text = "Save";
            this.UserInput.UseVisualStyleBackColor = true;
            this.UserInput.Click += new System.EventHandler(this.UserInput_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Save For Shop Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Save Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Save For User Data";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*\" (Parameter \'value\')";
            // 
            // SavePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 159);
            this.Controls.Add(this.ShopInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "SavePrompt";
            this.Text = "SavePrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ShopInput;
        private Button UserInput;
        private Label label2;
        private Label label4;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
    }
}