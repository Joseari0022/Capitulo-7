namespace Servicio_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.atenderBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.queueBox = new System.Windows.Forms.ListBox();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cliente";
            // 
            // atenderBtn
            // 
            this.atenderBtn.Location = new System.Drawing.Point(248, 60);
            this.atenderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.atenderBtn.Name = "atenderBtn";
            this.atenderBtn.Size = new System.Drawing.Size(100, 28);
            this.atenderBtn.TabIndex = 8;
            this.atenderBtn.Text = "Atender";
            this.atenderBtn.UseVisualStyleBackColor = true;
            this.atenderBtn.Click += new System.EventHandler(this.atenderBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(17, 60);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 28);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Anadir a fila";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // queueBox
            // 
            this.queueBox.FormattingEnabled = true;
            this.queueBox.ItemHeight = 16;
            this.queueBox.Location = new System.Drawing.Point(17, 96);
            this.queueBox.Margin = new System.Windows.Forms.Padding(4);
            this.queueBox.Name = "queueBox";
            this.queueBox.Size = new System.Drawing.Size(329, 196);
            this.queueBox.TabIndex = 6;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(17, 28);
            this.clientBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(132, 22);
            this.clientBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atenderBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.queueBox);
            this.Controls.Add(this.clientBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atenderBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox queueBox;
        private System.Windows.Forms.TextBox clientBox;
    }
}

