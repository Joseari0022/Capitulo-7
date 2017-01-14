namespace Capitulo_7
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
            this.addBtn = new System.Windows.Forms.Button();
            this.agendaBox = new System.Windows.Forms.ListBox();
            this.telBox = new System.Windows.Forms.MaskedTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(189, 64);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(167, 28);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // agendaBox
            // 
            this.agendaBox.FormattingEnabled = true;
            this.agendaBox.ItemHeight = 16;
            this.agendaBox.Location = new System.Drawing.Point(22, 100);
            this.agendaBox.Margin = new System.Windows.Forms.Padding(4);
            this.agendaBox.Name = "agendaBox";
            this.agendaBox.Size = new System.Drawing.Size(332, 196);
            this.agendaBox.TabIndex = 6;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(22, 68);
            this.telBox.Margin = new System.Windows.Forms.Padding(4);
            this.telBox.Mask = "999-999-9999";
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(132, 22);
            this.telBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(22, 27);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.agendaBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox agendaBox;
        private System.Windows.Forms.MaskedTextBox telBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}

