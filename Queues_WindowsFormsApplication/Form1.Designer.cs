namespace Queues_WindowsFormsApplication
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
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum
            // 
            this.textBoxNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNum.Location = new System.Drawing.Point(135, 30);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(173, 20);
            this.textBoxNum.TabIndex = 0;
            // 
            // btInsert
            // 
            this.btInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btInsert.Location = new System.Drawing.Point(111, 72);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(95, 27);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemove.Location = new System.Drawing.Point(236, 72);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(95, 27);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(443, 269);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.textBoxNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button buttonRemove;
    }
}

