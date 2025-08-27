namespace Cashier_kyuwinng
{
    partial class Customer_View
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
            this.label1_Current_Number = new System.Windows.Forms.Label();
            this.label2_Cashier_Numbering = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Current_Number
            // 
            this.label1_Current_Number.AutoSize = true;
            this.label1_Current_Number.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Current_Number.Location = new System.Drawing.Point(12, 18);
            this.label1_Current_Number.Name = "label1_Current_Number";
            this.label1_Current_Number.Size = new System.Drawing.Size(193, 32);
            this.label1_Current_Number.TabIndex = 0;
            this.label1_Current_Number.Text = "*Now Serving";
            // 
            // label2_Cashier_Numbering
            // 
            this.label2_Cashier_Numbering.AutoSize = true;
            this.label2_Cashier_Numbering.Font = new System.Drawing.Font("Arial Rounded MT Bold", 69.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Cashier_Numbering.Location = new System.Drawing.Point(65, 112);
            this.label2_Cashier_Numbering.Name = "label2_Cashier_Numbering";
            this.label2_Cashier_Numbering.Size = new System.Drawing.Size(358, 108);
            this.label2_Cashier_Numbering.TabIndex = 1;
            this.label2_Cashier_Numbering.Text = "P-1000";
            // 
            // Customer_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(502, 300);
            this.Controls.Add(this.label2_Cashier_Numbering);
            this.Controls.Add(this.label1_Current_Number);
            this.Name = "Customer_View";
            this.Text = "Customer_View";
            this.Load += new System.EventHandler(this.Customer_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Current_Number;
        private System.Windows.Forms.Label label2_Cashier_Numbering;
    }
}