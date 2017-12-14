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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            readAD();
        }
        public void readAD()//อ่านไฟล์ที่อยู่ลูกค้า
        {
            string[] add = new string[4];
            add = System.IO.File.ReadAllLines(Application.StartupPath + @"\add.txt"); //อ่านไฟล์แล้วนำมาเก็บแบบอาเรย์
            textBox1.Text = add[0];
            textBox2.Text = add[1];
            textBox3.Text = add[2];
            textBox4.Text = add[3];
        }
        public void address()//เมทตอทบันทึกที่อยู่ลูกค้า
        {
            string[] ad = new string[4];
            int number;
            bool a = int.TryParse(textBox3.Text, out number);//เช็คค่าว่าเป็นตัวเลขทั้งหมดมั้ย
            if (a == false)
            {
                MessageBox.Show("กรุณาใส่เบอร์โทรศัพท์");//แสดงข้อความแจ้งเตือนหากไม่ใส่เบอร์โทรศัพท์                                                                                                                                                                                                                                                                                             
            }
            else
            {
                string[] add = new string[4];
                add[0] = textBox1.Text;
                add[1] = textBox2.Text;
                add[2] = textBox3.Text;
                add[3] = textBox4.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\add.txt", add);//บันทึกไฟล์ข้อมูลลูกค้า
                Form4 f4 = new Form4();
                f4.textBox1.Text = textBox1.Text;//สั่งให้ textbox ของ form4 แสดงข้อมูลที่กำหนด
                f4.textBox2.Text = textBox2.Text;//สั่งให้ textbox ของ form4 แสดงข้อมูลที่กำหนด
                f4.textBox3.Text = textBox3.Text;//สั่งให้ textbox ของ form4 แสดงข้อมูลที่กำหนด
                f4.textBox4.Text = textBox4.Text;//สั่งให้ textbox ของ form4 แสดงข้อมูลที่กำหนด
                f4.Show();//แสดง form4
                Close();//ปิด form นี้
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty | textBox2.Text == string.Empty | textBox3.Text == string.Empty )//บังคับให้ใส่ข้อมูล
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
            else { address(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();//แสดง form1 
            Close();//ปิด form นี้
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
