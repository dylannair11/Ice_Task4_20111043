
namespace DonutOrder
{
    partial class FrmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDonuts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCoffees = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETE\'S DONUT SHOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter no.of Donuts";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(196, 71);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 3;
            // 
            // txbDonuts
            // 
            this.txbDonuts.Location = new System.Drawing.Point(196, 134);
            this.txbDonuts.Name = "txbDonuts";
            this.txbDonuts.Size = new System.Drawing.Size(100, 23);
            this.txbDonuts.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter no.of coffees";
            // 
            // txbCoffees
            // 
            this.txbCoffees.Location = new System.Drawing.Point(196, 198);
            this.txbCoffees.Name = "txbCoffees";
            this.txbCoffees.Size = new System.Drawing.Size(100, 23);
            this.txbCoffees.TabIndex = 6;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(175, 296);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(88, 34);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "process order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 385);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txbCoffees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDonuts);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbDonuts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCoffees;
        private System.Windows.Forms.Button btnOrder;
    }
}

