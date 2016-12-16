namespace Course_work
{
    partial class Main
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
            this.ClientBtn = new System.Windows.Forms.Button();
            this.SubscrBtn = new System.Windows.Forms.Button();
            this.VisitingBtn = new System.Windows.Forms.Button();
            this.Row_SubBtn = new System.Windows.Forms.Button();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(64, 39);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(162, 23);
            this.ClientBtn.TabIndex = 0;
            this.ClientBtn.Text = "Таблиця Client";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubscrBtn
            // 
            this.SubscrBtn.Location = new System.Drawing.Point(64, 114);
            this.SubscrBtn.Name = "SubscrBtn";
            this.SubscrBtn.Size = new System.Drawing.Size(162, 23);
            this.SubscrBtn.TabIndex = 1;
            this.SubscrBtn.Text = "Таблиця Subscriptions";
            this.SubscrBtn.UseVisualStyleBackColor = true;
            // 
            // VisitingBtn
            // 
            this.VisitingBtn.Location = new System.Drawing.Point(64, 78);
            this.VisitingBtn.Name = "VisitingBtn";
            this.VisitingBtn.Size = new System.Drawing.Size(162, 23);
            this.VisitingBtn.TabIndex = 1;
            this.VisitingBtn.Text = "Таблиця Visiting";
            this.VisitingBtn.UseVisualStyleBackColor = true;
            // 
            // Row_SubBtn
            // 
            this.Row_SubBtn.Location = new System.Drawing.Point(64, 152);
            this.Row_SubBtn.Name = "Row_SubBtn";
            this.Row_SubBtn.Size = new System.Drawing.Size(162, 23);
            this.Row_SubBtn.TabIndex = 2;
            this.Row_SubBtn.Text = "Таблиця Row_Subscriptions";
            this.Row_SubBtn.UseVisualStyleBackColor = true;
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.Location = new System.Drawing.Point(64, 193);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(162, 23);
            this.ServiceBtn.TabIndex = 3;
            this.ServiceBtn.Text = "Таблиця Service_types";
            this.ServiceBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ServiceBtn);
            this.Controls.Add(this.Row_SubBtn);
            this.Controls.Add(this.VisitingBtn);
            this.Controls.Add(this.SubscrBtn);
            this.Controls.Add(this.ClientBtn);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button SubscrBtn;
        private System.Windows.Forms.Button VisitingBtn;
        private System.Windows.Forms.Button Row_SubBtn;
        private System.Windows.Forms.Button ServiceBtn;
    }
}

