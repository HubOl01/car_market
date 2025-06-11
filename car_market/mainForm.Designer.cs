namespace car_market
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_car = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_carPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Автосалон";
            // 
            // btn_car
            // 
            this.btn_car.Location = new System.Drawing.Point(36, 104);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(195, 52);
            this.btn_car.TabIndex = 4;
            this.btn_car.Text = "Список машин";
            this.btn_car.UseVisualStyleBackColor = true;
            this.btn_car.Click += new System.EventHandler(this.btn_car_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(36, 162);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(195, 52);
            this.btn_purchase.TabIndex = 5;
            this.btn_purchase.Text = "Покупка";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.Location = new System.Drawing.Point(36, 278);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(195, 52);
            this.btn_manager.TabIndex = 6;
            this.btn_manager.Text = "Персонал";
            this.btn_manager.UseVisualStyleBackColor = true;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(36, 336);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(195, 52);
            this.btn_client.TabIndex = 7;
            this.btn_client.Text = "Данные клиента";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(384, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_car);
            this.panel1.Controls.Add(this.btn_carPurchase);
            this.panel1.Controls.Add(this.btn_purchase);
            this.panel1.Controls.Add(this.btn_manager);
            this.panel1.Controls.Add(this.btn_client);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 480);
            this.panel1.TabIndex = 9;
            // 
            // btn_carPurchase
            // 
            this.btn_carPurchase.Location = new System.Drawing.Point(36, 220);
            this.btn_carPurchase.Name = "btn_carPurchase";
            this.btn_carPurchase.Size = new System.Drawing.Size(195, 52);
            this.btn_carPurchase.TabIndex = 5;
            this.btn_carPurchase.Text = "Список купленных автомобилей";
            this.btn_carPurchase.UseVisualStyleBackColor = true;
            this.btn_carPurchase.Click += new System.EventHandler(this.btn_carPurchase_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 504);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(869, 551);
            this.MinimumSize = new System.Drawing.Size(869, 551);
            this.Name = "mainForm";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_carPurchase;
    }
}

