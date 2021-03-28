
namespace Security
{
    partial class Security
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Security));
            this.label1 = new System.Windows.Forms.Label();
            this.ContactUsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitRequestButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RequestAQuoteLabel = new System.Windows.Forms.Label();
            this.TextLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 60);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ContactUsButton
            // 
            this.ContactUsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(10)))));
            this.ContactUsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContactUsButton.FlatAppearance.BorderSize = 0;
            this.ContactUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactUsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactUsButton.ForeColor = System.Drawing.Color.White;
            this.ContactUsButton.Location = new System.Drawing.Point(1040, 23);
            this.ContactUsButton.Name = "ContactUsButton";
            this.ContactUsButton.Size = new System.Drawing.Size(132, 37);
            this.ContactUsButton.TabIndex = 1;
            this.ContactUsButton.Text = "CONTACT US";
            this.ContactUsButton.UseVisualStyleBackColor = false;
            this.ContactUsButton.Click += new System.EventHandler(this.ContactUsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitRequestButton);
            this.panel1.Controls.Add(this.MessageTextBox);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.SurnameTextBox);
            this.panel1.Controls.Add(this.MessageLabel);
            this.panel1.Controls.Add(this.PhoneNumberLabel);
            this.panel1.Controls.Add(this.SurnameLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.RequestAQuoteLabel);
            this.panel1.Location = new System.Drawing.Point(154, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 521);
            this.panel1.TabIndex = 2;
            // 
            // SubmitRequestButton
            // 
            this.SubmitRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(10)))));
            this.SubmitRequestButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubmitRequestButton.FlatAppearance.BorderSize = 0;
            this.SubmitRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitRequestButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitRequestButton.ForeColor = System.Drawing.Color.White;
            this.SubmitRequestButton.Location = new System.Drawing.Point(132, 469);
            this.SubmitRequestButton.Name = "SubmitRequestButton";
            this.SubmitRequestButton.Size = new System.Drawing.Size(132, 37);
            this.SubmitRequestButton.TabIndex = 3;
            this.SubmitRequestButton.Text = "SUBMIT";
            this.SubmitRequestButton.UseVisualStyleBackColor = false;
            this.SubmitRequestButton.Click += new System.EventHandler(this.SubmitRequestButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessageTextBox.Location = new System.Drawing.Point(58, 356);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(271, 96);
            this.MessageTextBox.TabIndex = 9;
            this.MessageTextBox.Text = "";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneTextBox.Location = new System.Drawing.Point(58, 261);
            this.PhoneTextBox.MaxLength = 11;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(271, 33);
            this.PhoneTextBox.TabIndex = 7;
            this.PhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameTextBox.Location = new System.Drawing.Point(58, 169);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(271, 33);
            this.SurnameTextBox.TabIndex = 6;
            this.SurnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessageLabel.Location = new System.Drawing.Point(58, 328);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(103, 25);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.Text = "Message";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(58, 233);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(76, 25);
            this.PhoneNumberLabel.TabIndex = 4;
            this.PhoneNumberLabel.Text = "Phone";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SurnameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(58, 141);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(103, 25);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(58, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(58, 84);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(271, 33);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RequestAQuoteLabel
            // 
            this.RequestAQuoteLabel.AutoSize = true;
            this.RequestAQuoteLabel.BackColor = System.Drawing.Color.Transparent;
            this.RequestAQuoteLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RequestAQuoteLabel.Location = new System.Drawing.Point(112, 17);
            this.RequestAQuoteLabel.Name = "RequestAQuoteLabel";
            this.RequestAQuoteLabel.Size = new System.Drawing.Size(181, 25);
            this.RequestAQuoteLabel.TabIndex = 0;
            this.RequestAQuoteLabel.Text = "Request a Quote";
            // 
            // TextLabel1
            // 
            this.TextLabel1.AutoSize = true;
            this.TextLabel1.BackColor = System.Drawing.Color.Transparent;
            this.TextLabel1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextLabel1.ForeColor = System.Drawing.Color.White;
            this.TextLabel1.Location = new System.Drawing.Point(698, 353);
            this.TextLabel1.Name = "TextLabel1";
            this.TextLabel1.Size = new System.Drawing.Size(372, 32);
            this.TextLabel1.TabIndex = 3;
            this.TextLabel1.Text = "PRIVATE SECURITY SERVICES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(698, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customized private security \r\nstrategy to ensure your complete protection.";
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.AutoSize = true;
            this.MainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuLabel.ForeColor = System.Drawing.Color.Orange;
            this.MainMenuLabel.Location = new System.Drawing.Point(698, 480);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(320, 56);
            this.MainMenuLabel.TabIndex = 5;
            this.MainMenuLabel.Text = "SEE FULL PRIVATE SECURITY \r\nPROTECTION SERVICES >>";
            this.MainMenuLabel.Click += new System.EventHandler(this.MainMenuLabel_Click);
            // 
            // Security
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.MainMenuLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContactUsButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security";
            this.Load += new System.EventHandler(this.Security_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContactUsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label RequestAQuoteLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SubmitRequestButton;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Label TextLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MainMenuLabel;
    }
}