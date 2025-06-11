namespace car_market
{
    partial class procedure
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.btnManager_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Добавить стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номер покупки";
            // 
            // textBox_2
            // 
            this.textBox_2.Location = new System.Drawing.Point(32, 219);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(341, 22);
            this.textBox_2.TabIndex = 13;
            // 
            // textBox_1
            // 
            this.textBox_1.Location = new System.Drawing.Point(32, 135);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(341, 22);
            this.textBox_1.TabIndex = 14;
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.ManagerLabel.Location = new System.Drawing.Point(27, 21);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(307, 29);
            this.ManagerLabel.TabIndex = 12;
            this.ManagerLabel.Text = "Вызов хранимой процедуры";
            // 
            // btnManager_Save
            // 
            this.btnManager_Save.Location = new System.Drawing.Point(108, 386);
            this.btnManager_Save.Name = "btnManager_Save";
            this.btnManager_Save.Size = new System.Drawing.Size(189, 43);
            this.btnManager_Save.TabIndex = 11;
            this.btnManager_Save.Text = "Добавить";
            this.btnManager_Save.UseVisualStyleBackColor = true;
            this.btnManager_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.ManagerLabel);
            this.Controls.Add(this.btnManager_Save);
            this.MaximumSize = new System.Drawing.Size(418, 497);
            this.MinimumSize = new System.Drawing.Size(418, 497);
            this.Name = "procedure";
            this.Text = "procedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.Button btnManager_Save;
    }
}