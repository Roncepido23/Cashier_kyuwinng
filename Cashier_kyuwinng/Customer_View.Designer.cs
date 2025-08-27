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
            this.label1_Now_Serving = new System.Windows.Forms.Label();
            this.label2_Cashier_Numbering = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Now_Serving
            // 
            this.label1_Now_Serving.AutoSize = true;
            this.label1_Now_Serving.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_Now_Serving.Location = new System.Drawing.Point(12, 9);
            this.label1_Now_Serving.Name = "label1_Now_Serving";
            this.label1_Now_Serving.Size = new System.Drawing.Size(131, 25);
            this.label1_Now_Serving.TabIndex = 0;
            this.label1_Now_Serving.Text = "*Now Serving";
            // 
            // label2_Cashier_Numbering
            // 
            this.label2_Cashier_Numbering.AutoSize = true;
            this.label2_Cashier_Numbering.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_Cashier_Numbering.Location = new System.Drawing.Point(109, 116);
            this.label2_Cashier_Numbering.Name = "label2_Cashier_Numbering";
            this.label2_Cashier_Numbering.Size = new System.Drawing.Size(260, 77);
            this.label2_Cashier_Numbering.TabIndex = 1;
            this.label2_Cashier_Numbering.Text = "P-1000";
            // 
            // Customer_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(502, 300);
            this.Controls.Add(this.label2_Cashier_Numbering);
            this.Controls.Add(this.label1_Now_Serving);
            this.Name = "Customer_View";
            this.Text = "Customer_View";
            this.Load += new System.EventHandler(this.Customer_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Now_Serving;
        private System.Windows.Forms.Label label2_Cashier_Numbering;
    }
}