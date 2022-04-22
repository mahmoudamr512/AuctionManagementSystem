namespace AuctionManagementSystem
{
    partial class BuyerDashboard
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
            System.Windows.Forms.Button allItems;
            System.Windows.Forms.Button profile;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button addItem;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            allItems = new System.Windows.Forms.Button();
            profile = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            addItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allItems
            // 
            allItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            allItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            allItems.FlatAppearance.BorderSize = 0;
            allItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            allItems.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            allItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            allItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            allItems.Location = new System.Drawing.Point(4, 300);
            allItems.Name = "allItems";
            allItems.Size = new System.Drawing.Size(197, 61);
            allItems.TabIndex = 1;
            allItems.TabStop = false;
            allItems.Text = "Items";
            allItems.UseVisualStyleBackColor = false;
            allItems.Click += new System.EventHandler(this.allItems_Click);
            // 
            // profile
            // 
            profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            profile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            profile.FlatAppearance.BorderSize = 0;
            profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            profile.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            profile.Location = new System.Drawing.Point(3, 241);
            profile.Name = "profile";
            profile.Size = new System.Drawing.Size(197, 61);
            profile.TabIndex = 1;
            profile.TabStop = false;
            profile.Text = "Profile";
            profile.UseVisualStyleBackColor = false;
            profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button3.Location = new System.Drawing.Point(-2, 578);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(203, 61);
            button3.TabIndex = 1;
            button3.TabStop = false;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addItem
            // 
            addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            addItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            addItem.FlatAppearance.BorderSize = 0;
            addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addItem.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            addItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addItem.Location = new System.Drawing.Point(3, 179);
            addItem.Name = "addItem";
            addItem.Size = new System.Drawing.Size(200, 61);
            addItem.TabIndex = 1;
            addItem.TabStop = false;
            addItem.Text = "Add Item";
            addItem.UseVisualStyleBackColor = false;
            addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(allItems);
            this.panel1.Controls.Add(profile);
            this.panel1.Controls.Add(button3);
            this.panel1.Controls.Add(addItem);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 639);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 177);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(55, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(79, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuctionManagementSystem.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(59, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 91);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(612, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 52);
            this.label3.TabIndex = 11;
            this.label3.Text = "Auction Management \r\nSystem\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.panel3.Location = new System.Drawing.Point(205, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 560);
            this.panel3.TabIndex = 10;
            // 
            // BuyerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1299, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyerDashboard";
            this.Load += new System.EventHandler(this.BuyerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}