namespace shopwithui
{
    partial class Debug
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
            this.DebugTrees = new System.Windows.Forms.Button();
            this.DebugHash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DebugTrees
            // 
            this.DebugTrees.Location = new System.Drawing.Point(137, 111);
            this.DebugTrees.Name = "DebugTrees";
            this.DebugTrees.Size = new System.Drawing.Size(75, 23);
            this.DebugTrees.TabIndex = 39;
            this.DebugTrees.Text = "Debug";
            this.DebugTrees.UseVisualStyleBackColor = true;
            this.DebugTrees.Click += new System.EventHandler(this.DebugTrees_Click_1);
            // 
            // DebugHash
            // 
            this.DebugHash.Location = new System.Drawing.Point(137, 74);
            this.DebugHash.Name = "DebugHash";
            this.DebugHash.Size = new System.Drawing.Size(75, 23);
            this.DebugHash.TabIndex = 38;
            this.DebugHash.Text = "Debug";
            this.DebugHash.UseVisualStyleBackColor = true;
            this.DebugHash.Click += new System.EventHandler(this.DebugHash_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Debug Shop Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "Debug Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Debug User Data";
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 157);
            this.Controls.Add(this.DebugTrees);
            this.Controls.Add(this.DebugHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Debug";
            this.Text = "Debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DebugTrees;
        private Button DebugHash;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}