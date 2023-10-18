namespace TRPO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.fivelitr = new System.Windows.Forms.Button();
            this.tenlitr = new System.Windows.Forms.Button();
            this.twlitr = new System.Windows.Forms.Button();
            this.fivehundred = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hundred = new System.Windows.Forms.Button();
            this.fifty = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.bottle = new System.Windows.Forms.Button();
            this.itog_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.water = new System.Windows.Forms.Button();
            this.vvod_money = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kypyr = new System.Windows.Forms.Button();
            this.monet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(480, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество литров";
            // 
            // fivelitr
            // 
            this.fivelitr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fivelitr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fivelitr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fivelitr.ForeColor = System.Drawing.SystemColors.Window;
            this.fivelitr.Location = new System.Drawing.Point(487, 283);
            this.fivelitr.Margin = new System.Windows.Forms.Padding(4);
            this.fivelitr.Name = "fivelitr";
            this.fivelitr.Size = new System.Drawing.Size(179, 32);
            this.fivelitr.TabIndex = 1;
            this.fivelitr.Text = "5 литров, 25р";
            this.fivelitr.UseVisualStyleBackColor = false;
            this.fivelitr.Click += new System.EventHandler(this.FIveLiterButton_Click);
            // 
            // tenlitr
            // 
            this.tenlitr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tenlitr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tenlitr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenlitr.ForeColor = System.Drawing.SystemColors.Window;
            this.tenlitr.Location = new System.Drawing.Point(486, 322);
            this.tenlitr.Margin = new System.Windows.Forms.Padding(4);
            this.tenlitr.Name = "tenlitr";
            this.tenlitr.Size = new System.Drawing.Size(179, 32);
            this.tenlitr.TabIndex = 2;
            this.tenlitr.Text = "10 литров, 50р";
            this.tenlitr.UseVisualStyleBackColor = false;
            this.tenlitr.Click += new System.EventHandler(this.TenLiterButton_Click);
            // 
            // twlitr
            // 
            this.twlitr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.twlitr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twlitr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twlitr.ForeColor = System.Drawing.SystemColors.Window;
            this.twlitr.Location = new System.Drawing.Point(486, 362);
            this.twlitr.Margin = new System.Windows.Forms.Padding(4);
            this.twlitr.Name = "twlitr";
            this.twlitr.Size = new System.Drawing.Size(179, 32);
            this.twlitr.TabIndex = 3;
            this.twlitr.Text = "20 литров, 100р";
            this.twlitr.UseVisualStyleBackColor = false;
            this.twlitr.Click += new System.EventHandler(this.TwelLiterButton_Click);
            // 
            // fivehundred
            // 
            this.fivehundred.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fivehundred.Enabled = false;
            this.fivehundred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fivehundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fivehundred.ForeColor = System.Drawing.SystemColors.Window;
            this.fivehundred.Location = new System.Drawing.Point(606, 446);
            this.fivehundred.Margin = new System.Windows.Forms.Padding(4);
            this.fivehundred.Name = "fivehundred";
            this.fivehundred.Size = new System.Drawing.Size(49, 20);
            this.fivehundred.TabIndex = 4;
            this.fivehundred.Text = "500";
            this.fivehundred.UseVisualStyleBackColor = false;
            this.fivehundred.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(486, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Внесено наличных";
            // 
            // hundred
            // 
            this.hundred.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hundred.Enabled = false;
            this.hundred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hundred.ForeColor = System.Drawing.SystemColors.Window;
            this.hundred.Location = new System.Drawing.Point(606, 468);
            this.hundred.Margin = new System.Windows.Forms.Padding(4);
            this.hundred.Name = "hundred";
            this.hundred.Size = new System.Drawing.Size(49, 20);
            this.hundred.TabIndex = 6;
            this.hundred.Text = "100";
            this.hundred.UseVisualStyleBackColor = false;
            this.hundred.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // fifty
            // 
            this.fifty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fifty.Enabled = false;
            this.fifty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.fifty.ForeColor = System.Drawing.SystemColors.Window;
            this.fifty.Location = new System.Drawing.Point(606, 490);
            this.fifty.Margin = new System.Windows.Forms.Padding(4);
            this.fifty.Name = "fifty";
            this.fifty.Size = new System.Drawing.Size(49, 20);
            this.fifty.TabIndex = 7;
            this.fifty.Text = "50";
            this.fifty.UseVisualStyleBackColor = false;
            this.fifty.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ten.Enabled = false;
            this.ten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.ten.ForeColor = System.Drawing.SystemColors.Window;
            this.ten.Location = new System.Drawing.Point(537, 515);
            this.ten.Margin = new System.Windows.Forms.Padding(4);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(28, 20);
            this.ten.TabIndex = 8;
            this.ten.Text = "10";
            this.ten.UseVisualStyleBackColor = false;
            this.ten.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.five.Enabled = false;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.five.ForeColor = System.Drawing.SystemColors.Window;
            this.five.Location = new System.Drawing.Point(567, 515);
            this.five.Margin = new System.Windows.Forms.Padding(4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(28, 20);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.two.Enabled = false;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.two.ForeColor = System.Drawing.SystemColors.Window;
            this.two.Location = new System.Drawing.Point(537, 536);
            this.two.Margin = new System.Windows.Forms.Padding(4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(28, 20);
            this.two.TabIndex = 10;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.one.Enabled = false;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.one.ForeColor = System.Drawing.SystemColors.Window;
            this.one.Location = new System.Drawing.Point(567, 536);
            this.one.Margin = new System.Windows.Forms.Padding(4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(28, 20);
            this.one.TabIndex = 11;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.vvod_money_Click);
            // 
            // bottle
            // 
            this.bottle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bottle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottle.ForeColor = System.Drawing.SystemColors.Window;
            this.bottle.Location = new System.Drawing.Point(138, 400);
            this.bottle.Margin = new System.Windows.Forms.Padding(4);
            this.bottle.Name = "bottle";
            this.bottle.Size = new System.Drawing.Size(175, 31);
            this.bottle.TabIndex = 13;
            this.bottle.Text = "Забрать бутыль";
            this.bottle.UseVisualStyleBackColor = false;
            this.bottle.Click += new System.EventHandler(this.bottle_Click);
            // 
            // itog_sum
            // 
            this.itog_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog_sum.Location = new System.Drawing.Point(553, 574);
            this.itog_sum.Margin = new System.Windows.Forms.Padding(4);
            this.itog_sum.Multiline = true;
            this.itog_sum.Name = "itog_sum";
            this.itog_sum.Size = new System.Drawing.Size(53, 29);
            this.itog_sum.TabIndex = 15;
            this.itog_sum.Text = "0";
            this.itog_sum.TextChanged += new System.EventHandler(this.itog_sum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(480, 577);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Баланс";
            // 
            // water
            // 
            this.water.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.water.Enabled = false;
            this.water.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.water.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.water.ForeColor = System.Drawing.SystemColors.Window;
            this.water.Location = new System.Drawing.Point(138, 358);
            this.water.Margin = new System.Windows.Forms.Padding(4);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(175, 28);
            this.water.TabIndex = 17;
            this.water.Text = "Начать налив воды";
            this.water.UseVisualStyleBackColor = false;
            this.water.Click += new System.EventHandler(this.Water_Click);
            // 
            // vvod_money
            // 
            this.vvod_money.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vvod_money.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vvod_money.ForeColor = System.Drawing.SystemColors.Window;
            this.vvod_money.Location = new System.Drawing.Point(614, 574);
            this.vvod_money.Margin = new System.Windows.Forms.Padding(4);
            this.vvod_money.Name = "vvod_money";
            this.vvod_money.Size = new System.Drawing.Size(60, 30);
            this.vvod_money.TabIndex = 18;
            this.vvod_money.Text = "--->";
            this.vvod_money.UseVisualStyleBackColor = false;
            this.vvod_money.Click += new System.EventHandler(this.vvod_money_Click_1);
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Screen.Location = new System.Drawing.Point(79, 249);
            this.Screen.Margin = new System.Windows.Forms.Padding(4);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(288, 78);
            this.Screen.TabIndex = 32;
            this.Screen.TabStop = false;
            this.Screen.Text = "Выберите количество литров";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(128, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 300);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(517, 629);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 77);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // kypyr
            // 
            this.kypyr.BackColor = System.Drawing.Color.Black;
            this.kypyr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kypyr.Location = new System.Drawing.Point(494, 471);
            this.kypyr.Name = "kypyr";
            this.kypyr.Size = new System.Drawing.Size(105, 13);
            this.kypyr.TabIndex = 36;
            this.kypyr.UseVisualStyleBackColor = false;
            this.kypyr.Click += new System.EventHandler(this.kypyr_Click);
            // 
            // monet
            // 
            this.monet.BackColor = System.Drawing.Color.Black;
            this.monet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monet.Location = new System.Drawing.Point(517, 519);
            this.monet.Name = "monet";
            this.monet.Size = new System.Drawing.Size(10, 30);
            this.monet.TabIndex = 37;
            this.monet.UseVisualStyleBackColor = false;
            this.monet.Click += new System.EventHandler(this.monet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 929);
            this.Controls.Add(this.monet);
            this.Controls.Add(this.kypyr);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.vvod_money);
            this.Controls.Add(this.water);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itog_sum);
            this.Controls.Add(this.bottle);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.five);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.fifty);
            this.Controls.Add(this.hundred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fivehundred);
            this.Controls.Add(this.twlitr);
            this.Controls.Add(this.tenlitr);
            this.Controls.Add(this.fivelitr);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fivelitr;
        private System.Windows.Forms.Button tenlitr;
        private System.Windows.Forms.Button twlitr;
        private System.Windows.Forms.Button fivehundred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hundred;
        private System.Windows.Forms.Button fifty;
        private System.Windows.Forms.Button ten;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button bottle;
        private System.Windows.Forms.TextBox itog_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button water;
        private System.Windows.Forms.Button vvod_money;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button kypyr;
        private System.Windows.Forms.Button monet;
    }
}

