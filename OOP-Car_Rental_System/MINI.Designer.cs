namespace OOP_Car_Rental_System
{
    partial class MINI
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
            this.MINI_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MINI_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MINI_DGV
            // 
            this.MINI_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MINI_DGV.Location = new System.Drawing.Point(88, 57);
            this.MINI_DGV.Name = "MINI_DGV";
            this.MINI_DGV.Size = new System.Drawing.Size(184, 192);
            this.MINI_DGV.TabIndex = 0;
            this.MINI_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MINI_DGV_CellContentClick);
            // 
            // MINI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MINI_DGV);
            this.Name = "MINI";
            this.Text = "MINI";
            ((System.ComponentModel.ISupportInitialize)(this.MINI_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MINI_DGV;
    }
}