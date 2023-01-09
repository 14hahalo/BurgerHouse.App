namespace BurgerHouse.App
{
    partial class LoginScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OrdersManagementStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.NewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewExtraMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdersManagementStrip,
            this.MaterialManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OrdersManagementStrip
            // 
            this.OrdersManagementStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewOrder,
            this.OrderInformation});
            this.OrdersManagementStrip.Name = "OrdersManagementStrip";
            this.OrdersManagementStrip.Size = new System.Drawing.Size(123, 20);
            this.OrdersManagementStrip.Text = "Order Management";
            // 
            // NewOrder
            // 
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(180, 22);
            this.NewOrder.Text = "Create an Order";
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // OrderInformation
            // 
            this.OrderInformation.Name = "OrderInformation";
            this.OrderInformation.Size = new System.Drawing.Size(180, 22);
            this.OrderInformation.Text = "Order Information";
            this.OrderInformation.Click += new System.EventHandler(this.OrderInformation_Click);
            // 
            // MaterialManagement
            // 
            this.MaterialManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenu,
            this.NewExtraMaterial});
            this.MaterialManagement.Name = "MaterialManagement";
            this.MaterialManagement.Size = new System.Drawing.Size(135, 20);
            this.MaterialManagement.Text = "Product Management";
            // 
            // NewMenu
            // 
            this.NewMenu.Name = "NewMenu";
            this.NewMenu.Size = new System.Drawing.Size(180, 22);
            this.NewMenu.Text = "Add New Menu";
            this.NewMenu.Click += new System.EventHandler(this.NewMenu_Click);
            // 
            // NewExtraMaterial
            // 
            this.NewExtraMaterial.Name = "NewExtraMaterial";
            this.NewExtraMaterial.Size = new System.Drawing.Size(180, 22);
            this.NewExtraMaterial.Text = "Add New Extra";
            this.NewExtraMaterial.Click += new System.EventHandler(this.NewExtraMaterial_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginScreen";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OrdersManagementStrip;
        private System.Windows.Forms.ToolStripMenuItem NewOrder;
        private System.Windows.Forms.ToolStripMenuItem OrderInformation;
        private System.Windows.Forms.ToolStripMenuItem MaterialManagement;
        private System.Windows.Forms.ToolStripMenuItem NewMenu;
        private System.Windows.Forms.ToolStripMenuItem NewExtraMaterial;
    }
}

