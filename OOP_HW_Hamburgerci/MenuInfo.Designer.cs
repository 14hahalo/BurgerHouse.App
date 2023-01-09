namespace BurgerHouse.App
{
    partial class MenuInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveMenu = new System.Windows.Forms.Button();
            this.nudMenuPrice = new System.Windows.Forms.NumericUpDown();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveMenu);
            this.groupBox1.Controls.Add(this.nudMenuPrice);
            this.groupBox1.Controls.Add(this.txtMenuName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.Location = new System.Drawing.Point(80, 94);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(99, 28);
            this.btnSaveMenu.TabIndex = 3;
            this.btnSaveMenu.Text = "Save Menu";
            this.btnSaveMenu.UseVisualStyleBackColor = true;
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
            // 
            // nudMenuPrice
            // 
            this.nudMenuPrice.Location = new System.Drawing.Point(80, 67);
            this.nudMenuPrice.Name = "nudMenuPrice";
            this.nudMenuPrice.Size = new System.Drawing.Size(99, 20);
            this.nudMenuPrice.TabIndex = 2;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(80, 32);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(99, 20);
            this.txtMenuName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Name";
            // 
            // MenuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 168);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuInfo";
            this.Text = "Menu Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveMenu;
        private System.Windows.Forms.NumericUpDown nudMenuPrice;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}