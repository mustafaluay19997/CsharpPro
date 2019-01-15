namespace Students.PL
{
    partial class MainForm
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
            this.btnQnat = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQnat
            // 
            this.btnQnat.Location = new System.Drawing.Point(514, 82);
            this.btnQnat.Margin = new System.Windows.Forms.Padding(4);
            this.btnQnat.Name = "btnQnat";
            this.btnQnat.Size = new System.Drawing.Size(159, 98);
            this.btnQnat.TabIndex = 0;
            this.btnQnat.Text = "ادارة القناة";
            this.btnQnat.UseVisualStyleBackColor = true;
            this.btnQnat.Click += new System.EventHandler(this.btnQnat_Click);
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(363, 82);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(143, 98);
            this.btnDept.TabIndex = 1;
            this.btnDept.Text = "ادارة الاقسام";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 460);
            this.Controls.Add(this.btnDept);
            this.Controls.Add(this.btnQnat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQnat;
        private System.Windows.Forms.Button btnDept;
    }
}