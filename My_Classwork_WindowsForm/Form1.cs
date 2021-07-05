using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Classwork_WindowsForm
{
    public partial class FormUkraine : Form
    {
        public FormUkraine()
        {
            InitializeComponent();
        }

        //Створити дві кнопки. Лічити натиснення кожної з кнопок. Результати(2 лічильники) виводити на деякий Label.
        static int count1 = 0;
        static int count2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count1++;
            label1.Text = ($"Counter for button1 = {count1}, Counter for button2 = {count2}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count2++;
            label1.Text = ($"Counter for button1 = {count1}, Counter for button2 = {count2}");
        }

        //Створити додаток з елементом Label.При натисненнні на Label, він повинен переміщатися випадково, але не повинен виходити за границі форми.
        Random rnd = new Random();
        private void label1_Click(object sender, EventArgs e)
        {
            ClientSize = new Size(500, 400);
            for (int i = 0; i < 20; i++)
            {
                label1.Top = rnd.Next(1, 400);
                label1.Left = rnd.Next(1, 400);
                Thread.Sleep(500);
            }
            
            //Top = 0;
            //Left = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    int X = rnd.Next(50, 400);
            //    int Y = rnd.Next(50, 300);
            //    label1.Location = new Point(X, Y);
            //    Thread.Sleep(1000);
            //}
            
            //for (int i = 0; i < 100; i++)
            //{
            //    label1.Location = templocation;
            //    templocation.X = rnd.Next(100, 527);
            //    label1.Location = templocation;
            //    templocation.Y = rnd.Next(100, 423);
            //    Thread.Sleep(1000);
            //}
                
           
        }

        //При натисненні деякої кнопки збільшувати прозорість форми, 
        //іншої кнопки - зменшувати прозорість форми(властивість Opacity : 0..1).
        private void OpacityPlus_Click(object sender, EventArgs e)
        {
            Opacity -= 0.1;
        }

        private void OpacityMinus_Click(object sender, EventArgs e)
        {
            Opacity += 0.1;
        }
    }
}
