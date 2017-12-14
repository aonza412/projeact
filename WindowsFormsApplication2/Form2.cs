using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();//แสดงform1
            this.Close();//ซ่อน form นี้
        }
        public void cleartxt()//เมทตอทบันทึกข้อมูลปล่าว
        {
            string[] ad = new string[4];
            System.IO.File.WriteAllLines(Application.StartupPath + @"\add.txt", ad);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cleartxt();//ใช้เมทตอทบันทึกข้อมูลปล่าว
            Form f3 = new Form3();
            f3.Show();//แสดง form3 
            Close();//ปิด form นี้
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
