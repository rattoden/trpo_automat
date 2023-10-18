using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO
{
    public partial class Form1 : Form
    {

        public int system_litrov = 50;
        public int user_money = 0;
        public int user_cost = 0;
        public int user_litrov = 0;
        public int system_money = 0;
        public int change_money = 0;
        public int currentImageIndex = 0;
        public List<Image> images = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            Screen.ReadOnly = true;
            itog_sum.ReadOnly = true;
            Screen.Multiline = true;
            Screen.WordWrap = true;

            fivehundred.Visible = false;
            hundred.Visible = false;
            fifty.Visible = false;
            ten.Visible = false;
            five.Visible = false;
            two.Visible = false;
            one.Visible = false;

            pictureBox1.Visible = false;
            pictureBox1.Top = 430;
            pictureBox1.Left = 95;
            pictureBox1.Width = 230;
            pictureBox1.Height = 300;

            if (system_litrov < 5)
            {
                Screen.Text = "Недостаточно воды";
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
                Screen.Enabled = true;
                itog_sum.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                fivelitr.Enabled = true;
                tenlitr.Enabled = true;
                twlitr.Enabled = true;

            }
        }

        private void FIveLiterButton_Click(object sender, EventArgs e)
        {
            user_litrov += 5;
            user_cost += 25;
            tenlitr.Enabled = false;
            twlitr.Enabled = false;
            vvod_litr_Click();
        }

        private void TenLiterButton_Click(object sender, EventArgs e)
        {
            user_litrov += 10;
            user_cost += 50;
            fivelitr.Enabled = false;
            twlitr.Enabled = false;
            vvod_litr_Click();
        }

        private void TwelLiterButton_Click(object sender, EventArgs e)
        {
            user_litrov += 20;
            user_cost += 100;
            fivelitr.Enabled = false;
            tenlitr.Enabled = false;
            vvod_litr_Click();
        }

        void vvod_litr_Click()
        {
            if (user_litrov <= system_litrov)
            {
                Screen.Text = user_litrov.ToString() + " литров = " + user_cost + " руб.    Внесите деньги";
                fivelitr.Enabled = false;
                tenlitr.Enabled = false;
                twlitr.Enabled = false;
                fivehundred.Enabled = true;
                hundred.Enabled = true;
                fifty.Enabled = true;
                ten.Enabled = true;
                five.Enabled = true;
                two.Enabled = true;
                one.Enabled = true;
                kypyr.Enabled = true;
                monet.Enabled = true;
            }
            else
            {
                Screen.Text = "Недостаточно воды. Выберите другой объём";
                user_litrov = 0;
                user_money = 0;
                user_cost = 0;
                fivelitr.Enabled = true;
                tenlitr.Enabled = true;
                twlitr.Enabled = true;
            }

        }

        private void vvod_money_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                user_money += Convert.ToInt32(button.Text);
                itog_sum.Text = user_money.ToString();
            }
        }

        private void itog_sum_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(itog_sum.Text) >= user_cost)
            {
                vvod_money.Enabled = true;
            }
            else
            {
                vvod_money.Enabled = false;
            }
        }

        private void vvod_money_Click_1(object sender, EventArgs e)
        {
            change_money = user_money - user_cost;
            system_money += user_money;
            itog_sum.Text = "0";
            Screen.Text = user_litrov.ToString() + " литров                 Поставьте бутылку";
            string imagePath = null;
            fivehundred.Enabled = false;
            hundred.Enabled = false;
            fifty.Enabled = false;
            ten.Enabled = false;
            five.Enabled = false;
            two.Enabled = false;
            one.Enabled = false;
            fivehundred.Visible = false;
            hundred.Visible = false;
            fifty.Visible = false;
            ten.Visible = false;
            five.Visible = false;
            two.Visible = false;
            one.Visible = false;
            kypyr.Enabled = false;
            monet.Enabled = false;

            if (user_litrov == 20)
            {
                imagePath = @"D:\4 курс\Технология разработки программного обеспечения\20 литров пустая.png";
                Image originalImage = Image.FromFile(imagePath);
                Image resizedImage = new Bitmap(originalImage, 180, 250);
                pictureBox1.Image = resizedImage;

                string imagePath1 = @"D:\4 курс\Технология разработки программного обеспечения\20 литров пустая.png";
                Image originalImage1 = Image.FromFile(imagePath1);
                images.Add(originalImage1);

                string imagePath2 = @"D:\4 курс\Технология разработки программного обеспечения\20 литров 1 стадия.png";
                Image originalImage2 = Image.FromFile(imagePath2);
                images.Add(originalImage2);

                string imagePath3 = @"D:\4 курс\Технология разработки программного обеспечения\20 литров 2 стадия.png";
                Image originalImage3 = Image.FromFile(imagePath3);
                images.Add(originalImage3);

                string imagePath4 = @"D:\4 курс\Технология разработки программного обеспечения\20 литров 3 стадия.png";
                Image originalImage4 = Image.FromFile(imagePath4);
                images.Add(originalImage4);
            }
            else if (user_litrov == 5)
            {
                imagePath = @"D:\4 курс\Технология разработки программного обеспечения\5 литров пустая.png";
                Image originalImage = Image.FromFile(imagePath);
                Image resizedImage = new Bitmap(originalImage, 100, 170);
                pictureBox1.Top += 70;
                pictureBox1.Left += 35;
                pictureBox1.Image = resizedImage;

                string imagePath1 = @"D:\4 курс\Технология разработки программного обеспечения\5 литров пустая.png";
                Image originalImage1 = Image.FromFile(imagePath1);
                images.Add(originalImage1);

                string imagePath2 = @"D:\4 курс\Технология разработки программного обеспечения\5 литров 1 стадия.png";
                Image originalImage2 = Image.FromFile(imagePath2);
                images.Add(originalImage2);

                string imagePath3 = @"D:\4 курс\Технология разработки программного обеспечения\5 литров 2 стадия.png";
                Image originalImage3 = Image.FromFile(imagePath3);
                images.Add(originalImage3);

                string imagePath4 = @"D:\4 курс\Технология разработки программного обеспечения\5 литров 3 стадия.png";
                Image originalImage4 = Image.FromFile(imagePath4);
                images.Add(originalImage4);
            }
            else if (user_litrov == 10)
            {
                imagePath = @"D:\4 курс\Технология разработки программного обеспечения\10 литров пустая.png";
                Image originalImage = Image.FromFile(imagePath);
                Image resizedImage = new Bitmap(originalImage, 380, 220);
                pictureBox1.Image = resizedImage;
                pictureBox1.Top += 25;
                pictureBox1.Left -= 105;
                pictureBox1.Width += 30;

                string imagePath1 = @"D:\4 курс\Технология разработки программного обеспечения\10 литров пустая.png";
                Image originalImage1 = Image.FromFile(imagePath1);
                images.Add(originalImage1);

                string imagePath2 = @"D:\4 курс\Технология разработки программного обеспечения\10 литров 1 стадия.png";
                Image originalImage2 = Image.FromFile(imagePath2);
                images.Add(originalImage2);

                string imagePath3 = @"D:\4 курс\Технология разработки программного обеспечения\10 литров 2 стадия.png";
                Image originalImage3 = Image.FromFile(imagePath3);
                images.Add(originalImage3);

                string imagePath4 = @"D:\4 курс\Технология разработки программного обеспечения\10 литров 3 стадия.png";
                Image originalImage4 = Image.FromFile(imagePath4);
                images.Add(originalImage4);
            }
            pictureBox1.Visible = true;
            water.Enabled = true;
        }

        private void Water_Click(object sender, EventArgs e)
        {
            Screen.Text = "Идёт налив воды...";
            water.Enabled = false;
            if (user_litrov == 20)
            {
                currentImageIndex = 0;
                Image resizedImage = new Bitmap(images[currentImageIndex], 180, 250);
                pictureBox1.Image = resizedImage;
                timer1.Start();
            }
            else if (user_litrov == 5)
            {
                currentImageIndex = 0;
                Image resizedImage = new Bitmap(images[currentImageIndex], 100, 170);
                pictureBox1.Image = resizedImage;
                timer1.Start();
            }
            else if (user_litrov == 10)
            {
                currentImageIndex = 0;
                Image resizedImage = new Bitmap(images[currentImageIndex], 380, 220);
                pictureBox1.Image = resizedImage;
                timer1.Start();
            }
            system_litrov -= user_litrov;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= images.Count)
            {
                currentImageIndex = 3;
                water.Enabled = false;
                
                if(change_money == 0)
                {
                    Screen.Text = "Заберите бутыль";
                    bottle.Enabled = true;
                }
                else
                {
                    if(change_money > system_money)
                    {
                        Screen.Text = "Ваша сдача = " + change_money + "        Введите телефон для отправки сдачи";
                        bottle.Enabled = true;

                    }
                    else
                    {
                        Screen.Text = "Ваша сдача = " + change_money + "        Заберите сдачу";
                        pictureBox3.Enabled = true;
                        string imagePath = @"D:\4 курс\Технология разработки программного обеспечения\горка монет.png";
                        Image originalImage = Image.FromFile(imagePath);
                        Image resizedImage = new Bitmap(originalImage, 80, 70);
                        pictureBox3.Image = resizedImage;
                        bottle.Enabled = false;
                    }
                }
            }
            if (user_litrov == 20)
            {
                Image resizedImage = new Bitmap(images[currentImageIndex], 180, 250);
                pictureBox1.Image = resizedImage;
            }
            else if (user_litrov == 5)
            {
                Image resizedImage = new Bitmap(images[currentImageIndex], 100, 170);
                pictureBox1.Image = resizedImage;
            }
            else if (user_litrov == 10)
            {
                Image resizedImage = new Bitmap(images[currentImageIndex], 380, 220);
                pictureBox1.Image = resizedImage;
            }
        }

        private void bottle_Click(object sender, EventArgs e)
        {
            if(pictureBox3 != null)
            {
                timer1.Stop();
                Screen.Text = "Выберите количество литров";
                user_money = 0;
                user_litrov = 0;
                user_cost = 0;
                images.Clear();
                pictureBox3.Image = null;

                Screen.ReadOnly = true;
                itog_sum.ReadOnly = true;
                Screen.Multiline = true;
                Screen.WordWrap = true;

                pictureBox1.Visible = false;
                pictureBox1.Top = 430;
                pictureBox1.Left = 95;
                pictureBox1.Width = 230;
                pictureBox1.Height = 300;

                if (system_litrov < 5)
                {
                    Screen.Text = "Недостаточно воды";
                    foreach (Control control in this.Controls)
                    {
                        control.Enabled = false;
                    }
                }
                else
                {
                    foreach (Control control in this.Controls)
                    {
                        control.Enabled = false;
                    }
                    Screen.Enabled = true;
                    itog_sum.Enabled = true;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    fivelitr.Enabled = true;
                    tenlitr.Enabled = true;
                    twlitr.Enabled = true;
                    pictureBox3.Enabled = true;
                }
            }
            else
            {
                Screen.Text = "Заберите сдачу";
            }
            
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^89\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void kypyr_Click(object sender, EventArgs e)
        {
            fivehundred.Visible = true;
            hundred.Visible = true;
            fifty.Visible = true;
            if(ten.Visible == true && five.Visible == true && two.Visible == true && one.Visible == true)
            {
                ten.Visible = false;
                five.Visible = false;
                two.Visible = false;
                one.Visible = false;
            }
        }

        private void monet_Click(object sender, EventArgs e)
        {
            ten.Visible = true;
            five.Visible = true;
            two.Visible = true;
            one.Visible = true;
            if(fivehundred.Visible == true && hundred.Visible == true && fifty.Visible == true)
            {
                fivehundred.Visible = false;
                hundred.Visible = false;
                fifty.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (pictureBox3.Image != null)
            {
                pictureBox3.Image = null;
            }
            bottle.Enabled = true;
        }
    }
}
