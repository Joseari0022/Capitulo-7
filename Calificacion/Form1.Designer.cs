namespace Calificacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.promBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.califBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Calificacion mas baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Calificacion mas alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Calificacion";
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(329, 145);
            this.maxBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxBox.Name = "maxBox";
            this.maxBox.ReadOnly = true;
            this.maxBox.Size = new System.Drawing.Size(132, 22);
            this.maxBox.TabIndex = 16;
            // 
            // promBox
            // 
            this.promBox.Location = new System.Drawing.Point(329, 239);
            this.promBox.Margin = new System.Windows.Forms.Padding(4);
            this.promBox.Name = "promBox";
            this.promBox.ReadOnly = true;
            this.promBox.Size = new System.Drawing.Size(132, 22);
            this.promBox.TabIndex = 15;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(329, 192);
            this.minBox.Margin = new System.Windows.Forms.Padding(4);
            this.minBox.Name = "minBox";
            this.minBox.ReadOnly = true;
            this.minBox.Size = new System.Drawing.Size(132, 22);
            this.minBox.TabIndex = 14;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(16, 97);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(300, 212);
            this.listBox.TabIndex = 13;
            // 
            // califBox
            // 
            this.califBox.Location = new System.Drawing.Point(17, 29);
            this.califBox.Margin = new System.Windows.Forms.Padding(4);
            this.califBox.Name = "califBox";
            this.califBox.Size = new System.Drawing.Size(132, 22);
            this.califBox.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(17, 61);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxBox);
            this.Controls.Add(this.promBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.califBox);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox promBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox califBox;
        private System.Windows.Forms.Button addBtn;
    }
}

