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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            add_combobox();//ใช้เมทตอทเพิ่มตัวเลือกใน combobox
        }
        Form2 f2 = new Form2(); //ตัวแปรเรียกใช้งานในการสั่งการ form2
        public string[] readcpu = System.IO.File.ReadAllLines(Application.StartupPath + @"\cpu.txt"); //อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public string[] readvga = System.IO.File.ReadAllLines(Application.StartupPath + @"\vga.txt");//อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public string[] readmb = System.IO.File.ReadAllLines(Application.StartupPath + @"\mainboard.txt");//อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public string[] readram = System.IO.File.ReadAllLines(Application.StartupPath + @"\ram.txt");//อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public string[] readhd = System.IO.File.ReadAllLines(Application.StartupPath + @"\hd.txt");//อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public string[] readsp = System.IO.File.ReadAllLines(Application.StartupPath + @"\sp.txt");//อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public string[] readcase = System.IO.File.ReadAllLines(Application.StartupPath + @"\case.txt");//อ่านไฟล์txtแล้วนำมาเก็บในตัวแปร
        public int Sum = 0; //ประกาศตัวแปร int
        public void add_combobox() //เมทตอทในการเพิ่มตัวเลือกลงใน combobox
        {
            for (int i = 0; i <= 11; i += 2)// ลูปในเมทตอทนี้ใช้เพื่อประหยัดโค้ดในการระบุตำแหน่งข้อมูลที่จะอ่าน
            {
                comboBox1.Items.Add(readcpu[i]);//เพิ่มในcombobox1
            }
            for (int i = 0; i <= 5; i += 2)
            {
                comboBox3.Items.Add(readvga[i]);//เพิ่มในcombobox2
            }
            for (int i = 0; i <= 3; i += 2)
            {
                comboBox2.Items.Add(readmb[i]);//เพิ่มในcombobox3
            }
            for (int i = 0; i <= 5; i += 2)
            {
                comboBox4.Items.Add(readram[i]);//เพิ่มในcombobox4
            }
            for (int i = 0; i <= 5; i += 2)
            {
                comboBox5.Items.Add(readhd[i]);//เพิ่มในcombobox5
            }
            for (int i = 0; i <= 3; i += 2)
            {
                comboBox6.Items.Add(readsp[i]);//เพิ่มในcombobox6
            }
            for (int i = 0; i <= 3; i += 2)
            {
                comboBox7.Items.Add(readcase[i]);//เพิ่มในcombobox7
            }
        }
        public void pgb() //เมทตอทสั่งให้รูปแสดงที่ form2
        {
            if (comboBox1.Text == readcpu[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\r7.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox1.Text == readcpu[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\r5.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox1.Text == readcpu[4])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\r3.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox1.Text == readcpu[6])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\i7.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox1.Text == readcpu[8])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\i5.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox1.Text == readcpu[10])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\i3.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox1.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox1.Image = null;
            }
            if (comboBox2.Text == readmb[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\picture\z370.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox2.Text == readmb[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\picture\x370.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox2.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox2.Image = null;
            }
            if (comboBox3.Text == readvga[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\picture\1050.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox3.Text == readvga[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\picture\1060.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox3.Text == readvga[4])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\picture\1080.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox3.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox3.Image = null;
            }
            if (comboBox4.Text == readram[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\picture\8g.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox4.Text == readram[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\picture\16g.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox4.Text == readram[4])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\picture\32g.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox4.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox4.Image = null;
            }
            if (comboBox5.Text == readhd[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\picture\1t.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox5.Text == readhd[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\picture\2t.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox5.Text == readhd[4])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\picture\ssd.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox5.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox5.Image = null;
            }
            if (comboBox6.Text == readsp[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\picture\750w.jpg");//อ่านไฟล์ภาพ
            }
            else if (comboBox6.Text == readsp[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\picture\850w.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox6.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox6.Image = null;
            }
            if (comboBox7.Text == readcase[0])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\picture\case1.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox7.Text == readcase[2])//เช็คเพื่อให้ภาพตรงกับอุปกรณ์ที่เลือก
            {
                f2.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\picture\case2.png");//อ่านไฟล์ภาพ
            }
            else if (comboBox7.Text == string.Empty)//หากช่องอุปกร์ว่างภาพก็จะว่าง
            {
                f2.pictureBox7.Image = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataCPU();//เรียกใช้เมทตอท
        }
        public void dataCPU() //เมทตอทในการแสดงข้อมูลของ cpu
        {
            if (comboBox1.Text== readcpu[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\r7.png");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath+ @"\data\r7.txt");//แสดงข้อมูล
                label9.Text = readcpu[1] + " บาท";//แสดงราคา
                label10.Text = readcpu[0];//แสดงชื่อ
            }
            else if (comboBox1.Text == readcpu[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\r5.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\r5.txt");
                label9.Text = readcpu[3] + " บาท";
                label10.Text = readcpu[2];
            }
            else if (comboBox1.Text == readcpu[4])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\r3.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\r3.txt");
                label9.Text = readcpu[5] + " บาท";
                label10.Text = readcpu[4];
            }
            else if (comboBox1.Text == readcpu[6])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\i7.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\i7.txt");
                label9.Text = readcpu[7] + " บาท";
                label10.Text = readcpu[6];

            }
            else if (comboBox1.Text == readcpu[8])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\i5.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\i5.txt");
                label9.Text = readcpu[9] + " บาท";
                label10.Text = readcpu[8];
            }
            else if (comboBox1.Text == readcpu[10])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\i3.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\i3.txt");
                label9.Text = readcpu[11] + " บาท";
                label10.Text = readcpu[10];
            }

        }
        public void datamain()//เมทตอทในการแสดงข้อมูลของ mainboard
        {
            if (comboBox2.Text == readmb[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\z370.png");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\z370.txt");//แสดงข้อมูล
                label9.Text = readmb[1] + " บาท";//แสดงราคา
                label10.Text = readmb[0];//แสดงชื่อ
            }
            else if (comboBox2.Text == readmb[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\x370.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\x370.txt");
                label9.Text = readcpu[3] + " บาท";
                label10.Text = readmb[2];
            }
        }
        public void dataVGA()//เมทตอทในการแสดงข้อมูลของ การ์ดจอ
        {
            if (comboBox3.Text == readvga[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\1050.jpg");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\1050.txt");//แสดงข้อมูล
                label9.Text = readvga[1] + " บาท";//แสดงราคา
                label10.Text = readvga[0];//แสดงชื่อ
            }
            else if (comboBox3.Text == readvga[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\1060.jpg");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\1060.txt");
                label9.Text = readvga[3] + " บาท";
                label10.Text = readvga[2];
            }
            else if (comboBox3.Text == readvga[4])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\1080.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\1080.txt");
                label9.Text = readvga[5] + " บาท";
                label10.Text = readvga[4];
            }
        }
        public void dataRAM()//เมทตอทในการแสดงข้อมูลของ ram
        {
            if (comboBox4.Text == readram[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\8g.jpg");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\8g.txt");//แสดงข้อมูล
                label9.Text = readram[1] + " บาท";//แสดงราคา
                label10.Text = readram[0];//แสดงชื่อ
            }
            else if (comboBox4.Text == readram[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\16g.jpg");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\16g.txt");
                label9.Text = readram[3] + " บาท";
                label10.Text = readram[2];
            }
            else if (comboBox4.Text == readram[4])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\32g.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\32g.txt");
                label9.Text = readram[5] + " บาท";
                label10.Text = readram[4];
            }
        }
        public void dataHD()//เมทตอทในการแสดงข้อมูลของ harddisk
        {
            if (comboBox5.Text == readhd[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\1t.jpg");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\1t.txt");//แสดงข้อมูล
                label9.Text = readhd[1] + " บาท";//แสดงราคา
                label10.Text = readhd[0];//แสดงชื่อ
            }
            else if (comboBox5.Text == readhd[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\2t.jpg");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\2t.txt");
                label9.Text = readhd[3] + " บาท";
                label10.Text = readhd[2];
            }
            else if (comboBox5.Text == readhd[4])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\ssd.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\ssd.txt");
                label9.Text = readhd[5] + " บาท";
                label10.Text = readhd[4];
            }
        }
        public void dataSP()//เมทตอทในการแสดงข้อมูลของ power supply
        {
            if (comboBox6.Text == readsp[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\750w.jpg");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\750w.txt");//แสดงข้อมูล
                label9.Text = readsp[1] + " บาท";//แสดงราคา
                label10.Text = readsp[0];//แสดงชื่อ
            }
            else if (comboBox6.Text == readsp[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\850w.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\850w.txt");
                label9.Text = readsp[3] + " บาท";
                label10.Text = readsp[2];
            }
        }
        public void dataCASE()//เมทตอทในการแสดงข้อมูลของ case
        {
            if (comboBox7.Text == readcase[0])//การเช็คค่าในเมทตอทนี้เพื่อให้ข้อมูลตรงกับอุปกรณ์
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\case1.png");//แสดงรูป
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\case1.txt");//แสดงข้อมูล
                label9.Text = readcase[1] + " บาท";//แสดงราคา
                label10.Text = readcase[0];//แสดงชื่อ
            }
            else if (comboBox7.Text == readcase[2])
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\picture\case2.png");
                textBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + @"\data\case2.txt");
                label9.Text = readcase[3] + " บาท";
                label10.Text = readcase[2];
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Close();//ปิด form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datamain();//เรียกใช้เมทตอท
        }
        public void sheck()//เมทตอทนี้ใช้เช็คความเข้ากันของ cpu กับ mainboard
        {
            if (comboBox2.Text == readmb[0])
            {
                if (comboBox1.Text == readcpu[6] | comboBox1.Text == readcpu[8] | comboBox1.Text == readcpu[10] | comboBox1.Text == string.Empty)
                {
                    pgb();//เมทตอทแสดงภาพ
                    f2.Show();//แสดง form2
                    this.Hide();//ซ่อนformนี้
                }
                else
                {
                    MessageBox.Show("!! Main Board ไม่รองรับ CPU");//ข้อความแจ้งเตือน
                    f2.label3.Text = "!! Main Board ไม่รองรับ CPU";//ข้อความแจ้งเตือน
                }
            }
            if (comboBox2.Text == readmb[2])
            {
                if (comboBox1.Text == readcpu[0] | comboBox1.Text == readcpu[2] | comboBox1.Text == readcpu[4] | comboBox1.Text == string.Empty)
                {
                    pgb();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("!! Main Board ไม่รองรับ CPU");
                    f2.label3.Text = "!! Main Board ไม่รองรับ CPU";
                }
            }
        }
        public void sum() //เมทตอทคำนวนราคาคอม
        {
            for (int i = 0; i <= 10 ; i += 2 )
            {
                if (comboBox1.Text == readcpu[i])
                {
                    Sum += Convert.ToInt32(readcpu[i+1]);
                }
                if (comboBox2.Text == readmb[i])
                {
                    Sum += Convert.ToInt32(readmb[i + 1]);
                }
                if (comboBox3.Text == readvga[i])
                {
                    Sum += Convert.ToInt32(readvga[i + 1]);
                }
                if (comboBox4.Text == readram[i])
                {
                    Sum += Convert.ToInt32(readram[i + 1]);
                }
                if (comboBox5.Text == readhd[i])
                {
                    Sum += Convert.ToInt32(readhd[i + 1]);
                }
                f2.label2.Text = Sum.ToString();
            }
        }
        
        public void bin()//เมทตอทบันทึกรายการของ
        {
            int a = Convert.ToInt32(System.IO.File.ReadAllText(Application.StartupPath + @"\i.txt"));//อ่านค่า i จาก txet
            string[] save = new string[8];
            save[0] = comboBox1.Text;
            save[1] = comboBox2.Text;
            save[2] = comboBox3.Text;
            save[3] = comboBox4.Text;
            save[4] = comboBox5.Text;
            save[5] = comboBox6.Text;
            save[6] = comboBox7.Text;
            save[7] = Sum.ToString();
            for (int i = 0; i <= 7; i++)
            {
                System.IO.File.WriteAllLines(Application.StartupPath + @"\sum\sum"+a+".txt", save);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            sum();//ใช้เมทตอทรวมเงิน
            sheck();//ใช้เมทตอทเช็คเมนบอร์ด
            pgb();//ใช้เมทตอทเช็คอุปกรณ์
            bin();//ใช้เมทตอทบันทึกรายการ
            f2.Show();//แสดง form2
            this.Hide();//ซ่อน form นี้
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataVGA();//เรียกใช้เมทตอท
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataRAM();//เรียกใช้เมทตอท
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataHD();//เรียกใช้เมทตอท
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataSP();//เรียกใช้เมทตอท
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataCASE();//เรียกใช้เมทตอท
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aonza412/projeact.git");
        }
    }
        
}

