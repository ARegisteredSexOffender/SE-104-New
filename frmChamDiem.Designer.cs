namespace ABD
{
    partial class frmChamDiem
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
            this.dgvChamDiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamDiem
            // 
            this.dgvChamDiem.AllowUserToAddRows = false;
            this.dgvChamDiem.AllowUserToDeleteRows = false;
            this.dgvChamDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvChamDiem.MultiSelect = false;
            this.dgvChamDiem.Name = "dgvChamDiem";
            this.dgvChamDiem.ReadOnly = true;
            this.dgvChamDiem.RowHeadersWidth = 51;
            this.dgvChamDiem.RowTemplate.Height = 24;
            this.dgvChamDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamDiem.Size = new System.Drawing.Size(800, 450);
            this.dgvChamDiem.TabIndex = 1;
            this.dgvChamDiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamDiem_CellDoubleClick);
            // 
            // frmChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChamDiem);
            this.Name = "frmChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách điểm ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChamDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamDiem;
    }
}