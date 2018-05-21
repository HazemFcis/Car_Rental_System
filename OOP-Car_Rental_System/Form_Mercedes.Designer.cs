namespace OOP_Car_Rental_System
{
    partial class Mercedes
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
            this.Mercedes_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Mercedes_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Mercedes_DGV
            // 
            this.Mercedes_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mercedes_DGV.Location = new System.Drawing.Point(144, 31);
            this.Mercedes_DGV.Name = "Mercedes_DGV";
            this.Mercedes_DGV.Size = new System.Drawing.Size(254, 111);
            this.Mercedes_DGV.TabIndex = 0;
            this.Mercedes_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 276);
            this.Controls.Add(this.Mercedes_DGV);
            this.Name = "Form12";
            this.Text = "Mercedes";
            ((System.ComponentModel.ISupportInitialize)(this.Mercedes_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Mercedes_DGV;
    }
}