
namespace Security
{
    partial class Datatable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datatable));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.AdminPanelLabel = new System.Windows.Forms.Label();
            this.BackToAdminFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 247);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(1160, 562);
            this.dgv.TabIndex = 0;
            // 
            // AdminPanelLabel
            // 
            this.AdminPanelLabel.AutoSize = true;
            this.AdminPanelLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminPanelLabel.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminPanelLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminPanelLabel.Location = new System.Drawing.Point(373, 155);
            this.AdminPanelLabel.Name = "AdminPanelLabel";
            this.AdminPanelLabel.Size = new System.Drawing.Size(442, 44);
            this.AdminPanelLabel.TabIndex = 6;
            this.AdminPanelLabel.Text = "Welcome back, Admin!";
            // 
            // BackToAdminFormButton
            // 
            this.BackToAdminFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(10)))));
            this.BackToAdminFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackToAdminFormButton.FlatAppearance.BorderSize = 0;
            this.BackToAdminFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToAdminFormButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackToAdminFormButton.ForeColor = System.Drawing.Color.White;
            this.BackToAdminFormButton.Location = new System.Drawing.Point(967, 31);
            this.BackToAdminFormButton.Name = "BackToAdminFormButton";
            this.BackToAdminFormButton.Size = new System.Drawing.Size(205, 37);
            this.BackToAdminFormButton.TabIndex = 10;
            this.BackToAdminFormButton.Text = "BACK TO ADMIN FORM";
            this.BackToAdminFormButton.UseVisualStyleBackColor = false;
            this.BackToAdminFormButton.Click += new System.EventHandler(this.BackToAdminFormButton_Click);
            // 
            // Datatable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.BackToAdminFormButton);
            this.Controls.Add(this.AdminPanelLabel);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Datatable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datatable";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackToAdminFormButton;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Label AdminPanelLabel;
    }
}