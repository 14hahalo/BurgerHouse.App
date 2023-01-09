namespace BurgerHouse.App
{
    partial class OrderDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.rdbMid = new System.Windows.Forms.RadioButton();
            this.rdbBig = new System.Windows.Forms.RadioButton();
            this.flpExtras = new System.Windows.Forms.FlowLayoutPanel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lsbOrders = new System.Windows.Forms.ListBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.pcbBurger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Menu Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose Extra Materials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Cost :";
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(455, 496);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(107, 26);
            this.btnCompleteOrder.TabIndex = 1;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(70, 166);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(174, 21);
            this.cmbMenu.TabIndex = 3;
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(12, 206);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(50, 17);
            this.rdbSmall.TabIndex = 4;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // rdbMid
            // 
            this.rdbMid.AutoSize = true;
            this.rdbMid.Location = new System.Drawing.Point(73, 206);
            this.rdbMid.Name = "rdbMid";
            this.rdbMid.Size = new System.Drawing.Size(42, 17);
            this.rdbMid.TabIndex = 4;
            this.rdbMid.TabStop = true;
            this.rdbMid.Text = "Mid";
            this.rdbMid.UseVisualStyleBackColor = true;
            // 
            // rdbBig
            // 
            this.rdbBig.AutoSize = true;
            this.rdbBig.Location = new System.Drawing.Point(123, 206);
            this.rdbBig.Name = "rdbBig";
            this.rdbBig.Size = new System.Drawing.Size(40, 17);
            this.rdbBig.TabIndex = 4;
            this.rdbBig.TabStop = true;
            this.rdbBig.Text = "Big";
            this.rdbBig.UseVisualStyleBackColor = true;
            // 
            // flpExtras
            // 
            this.flpExtras.AutoScroll = true;
            this.flpExtras.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpExtras.Location = new System.Drawing.Point(11, 252);
            this.flpExtras.Name = "flpExtras";
            this.flpExtras.Size = new System.Drawing.Size(315, 223);
            this.flpExtras.TabIndex = 5;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(244, 205);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(79, 20);
            this.nudQuantity.TabIndex = 6;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(15, 496);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(84, 26);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add New Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lsbOrders
            // 
            this.lsbOrders.FormattingEnabled = true;
            this.lsbOrders.Location = new System.Drawing.Point(332, 16);
            this.lsbOrders.Name = "lsbOrders";
            this.lsbOrders.ScrollAlwaysVisible = true;
            this.lsbOrders.Size = new System.Drawing.Size(601, 459);
            this.lsbOrders.TabIndex = 7;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(174, 503);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(13, 13);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "0";
            // 
            // pcbBurger
            // 
            this.pcbBurger.Location = new System.Drawing.Point(84, 0);
            this.pcbBurger.Name = "pcbBurger";
            this.pcbBurger.Size = new System.Drawing.Size(147, 147);
            this.pcbBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBurger.TabIndex = 2;
            this.pcbBurger.TabStop = false;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(945, 534);
            this.Controls.Add(this.lsbOrders);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.flpExtras);
            this.Controls.Add(this.rdbBig);
            this.Controls.Add(this.rdbMid);
            this.Controls.Add(this.rdbSmall);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.pcbBurger);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderDetail";
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.PictureBox pcbBurger;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.RadioButton rdbMid;
        private System.Windows.Forms.RadioButton rdbBig;
        private System.Windows.Forms.FlowLayoutPanel flpExtras;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ListBox lsbOrders;
        private System.Windows.Forms.Label lblCost;
    }
}