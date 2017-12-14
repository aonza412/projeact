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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form f3 = new Form3();
        public void address()//เมทตอทบันทึกข้อมูลที่เช็คแล้ว
        {
            int i = Convert.ToInt32(System.IO.File.ReadAllText(Application.StartupPath + @"\i.txt"));//อ่านค่า i จาก txet
            string[] ad = new string[4];
                ad[0] = textBox1.Text;
                ad[1] = textBox2.Text;
                ad[2] = textBox3.Text;
                ad[3] = textBox4.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\bill\bill"+i+".txt", ad);//บันทึกไฟล์
            MessageBox.Show("         ดำเนินการเสร็จสิ้น" + "\n" + "โปรดรอการติดต่อจากพนักงาน");
            i += 1;//เพิ่มค่า i
            System.IO.File.WriteAllText(Application.StartupPath + @"\i.txt", i.ToString());//บันทึกค่า i
            Form f1 = new Form1();
                f1.Show();
                Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            address();//ใช้เมทตอทบันทึกไฟล์
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3.Show();//แสดง form3 
            Close();//ปิด form นี้
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
