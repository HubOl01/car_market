namespace car_market
{
    partial class add_managerForm
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
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_full_name = new System.Windows.Forms.TextBox();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.btnManager_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(34, 228);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(341, 22);
            this.textBox_phone.TabIndex = 7;
            // 
            // textBox_full_name
            // 
            this.textBox_full_name.Location = new System.Drawing.Point(34, 144);
            this.textBox_full_name.Name = "textBox_full_name";
            this.textBox_full_name.Size = new System.Drawing.Size(341, 22);
            this.textBox_full_name.TabIndex = 8;
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.ManagerLabel.Location = new System.Drawing.Point(29, 30);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(329, 29);
            this.ManagerLabel.TabIndex = 4;
            this.ManagerLabel.Text = "Добавление нового менежера";
            // 
            // btnManager_Save
            // 
            this.btnManager_Save.Location = new System.Drawing.Point(110, 395);
            this.btnManager_Save.Name = "btnManager_Save";
            this.btnManager_Save.Size = new System.Drawing.Size(189, 43);
            this.btnManager_Save.TabIndex = 3;
            this.btnManager_Save.Text = "Добавить";
            this.btnManager_Save.UseVisualStyleBackColor = true;
            this.btnManager_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия с инициалами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Телефон";
            // 
            // add_managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_full_name);
            this.Controls.Add(this.ManagerLabel);
            this.Controls.Add(this.btnManager_Save);
            this.MaximumSize = new System.Drawing.Size(418, 497);
            this.MinimumSize = new System.Drawing.Size(418, 497);
            this.Name = "add_managerForm";
            this.Text = "Добавление нового менеджера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_full_name;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.Button btnManager_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}