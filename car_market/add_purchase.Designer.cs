namespace car_market
{
    partial class add_purchase
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_car = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBox_delivery = new System.Windows.Forms.ComboBox();
            this.comboBox_payment = new System.Windows.Forms.ComboBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.comboBox_client = new System.Windows.Forms.ComboBox();
            this.comboBox_manager = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Менеджер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Оплата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Доставка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Количество машин";
            // 
            // textBox_car
            // 
            this.textBox_car.Location = new System.Drawing.Point(32, 85);
            this.textBox_car.Name = "textBox_car";
            this.textBox_car.Size = new System.Drawing.Size(341, 22);
            this.textBox_car.TabIndex = 44;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 14.2F);
            this.label.Location = new System.Drawing.Point(27, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(318, 29);
            this.label.TabIndex = 40;
            this.label.Text = "Покупка данного автомобиля";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(104, 392);
            this.btn_Save.MinimumSize = new System.Drawing.Size(189, 43);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(189, 43);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "Добавить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBox_delivery
            // 
            this.comboBox_delivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_delivery.FormattingEnabled = true;
            this.comboBox_delivery.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox_delivery.Location = new System.Drawing.Point(32, 136);
            this.comboBox_delivery.Name = "comboBox_delivery";
            this.comboBox_delivery.Size = new System.Drawing.Size(341, 24);
            this.comboBox_delivery.TabIndex = 62;
            // 
            // comboBox_payment
            // 
            this.comboBox_payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_payment.FormattingEnabled = true;
            this.comboBox_payment.Items.AddRange(new object[] {
            "Картой",
            "Наличными"});
            this.comboBox_payment.Location = new System.Drawing.Point(32, 190);
            this.comboBox_payment.Name = "comboBox_payment";
            this.comboBox_payment.Size = new System.Drawing.Size(341, 24);
            this.comboBox_payment.TabIndex = 62;
            // 
            // comboBox_status
            // 
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(32, 242);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(341, 24);
            this.comboBox_status.TabIndex = 62;
            // 
            // comboBox_client
            // 
            this.comboBox_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_client.FormattingEnabled = true;
            this.comboBox_client.Location = new System.Drawing.Point(32, 292);
            this.comboBox_client.Name = "comboBox_client";
            this.comboBox_client.Size = new System.Drawing.Size(341, 24);
            this.comboBox_client.TabIndex = 62;
            // 
            // comboBox_manager
            // 
            this.comboBox_manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_manager.FormattingEnabled = true;
            this.comboBox_manager.Location = new System.Drawing.Point(32, 342);
            this.comboBox_manager.Name = "comboBox_manager";
            this.comboBox_manager.Size = new System.Drawing.Size(341, 24);
            this.comboBox_manager.TabIndex = 62;
            // 
            // add_purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 447);
            this.Controls.Add(this.comboBox_manager);
            this.Controls.Add(this.comboBox_client);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.comboBox_payment);
            this.Controls.Add(this.comboBox_delivery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_car);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_Save);
            this.Name = "add_purchase";
            this.Text = "Покупка данного автомобиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_car;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBox_delivery;
        private System.Windows.Forms.ComboBox comboBox_payment;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.ComboBox comboBox_client;
        private System.Windows.Forms.ComboBox comboBox_manager;
    }
}