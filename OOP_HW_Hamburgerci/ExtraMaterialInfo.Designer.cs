namespace BurgerHouse.App
{
    partial class ExtraMaterialInfo
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
            this.btnSaveExtraMaterial = new System.Windows.Forms.Button();
            this.nudExtraPrice = new System.Windows.Forms.NumericUpDown();
            this.txtExtraMaterialName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveExtraMaterial);
            this.groupBox1.Controls.Add(this.nudExtraPrice);
            this.groupBox1.Controls.Add(this.txtExtraMaterialName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Material Info";
            // 
            // btnSaveExtraMaterial
            // 
            this.btnSaveExtraMaterial.Location = new System.Drawing.Point(115, 94);
            this.btnSaveExtraMaterial.Name = "btnSaveExtraMaterial";
            this.btnSaveExtraMaterial.Size = new System.Drawing.Size(99, 39);
            this.btnSaveExtraMaterial.TabIndex = 3;
            this.btnSaveExtraMaterial.Text = "Save Extra";
            this.btnSaveExtraMaterial.UseVisualStyleBackColor = true;
            this.btnSaveExtraMaterial.Click += new System.EventHandler(this.btnSaveExtraMaterial_Click);
            // 
            // nudExtraPrice
            // 
            this.nudExtraPrice.Location = new System.Drawing.Point(115, 67);
            this.nudExtraPrice.Name = "nudExtraPrice";
            this.nudExtraPrice.Size = new System.Drawing.Size(99, 20);
            this.nudExtraPrice.TabIndex = 2;
            // 
            // txtExtraMaterialName
            // 
            this.txtExtraMaterialName.Location = new System.Drawing.Point(115, 32);
            this.txtExtraMaterialName.Name = "txtExtraMaterialName";
            this.txtExtraMaterialName.Size = new System.Drawing.Size(99, 20);
            this.txtExtraMaterialName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra Material Name";
            // 
            // ExtraMaterialInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 164);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExtraMaterialInfo";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveExtraMaterial;
        private System.Windows.Forms.NumericUpDown nudExtraPrice;
        private System.Windows.Forms.TextBox txtExtraMaterialName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}