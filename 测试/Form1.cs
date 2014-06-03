using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Timers;
namespace 测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Timers.Timer t = new System.Timers.Timer(2);
            //int intTime = 100;
            //t.Interval = intTime;//设置间隔时间，为毫秒；
            t.Elapsed += new System.Timers.ElapsedEventHandler(ontimeevent1);//到达时间的时候执行事件；
            t.AutoReset = false;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；

            t.Start();
            t.EndInit();
            //t.Interval =5000;

            t.Elapsed += new System.Timers.ElapsedEventHandler(ontimeevent2);//到达时间的时候执行事件；
            t.Start();
           // label1.Hide();
        }
        static void ontimeevent1(object sender, ElapsedEventArgs e)
        {
            MessageBox.Show("2");
        }
        static void ontimeevent2(object sender, ElapsedEventArgs e)
        {
            MessageBox.Show("3");
        }
    }
}
