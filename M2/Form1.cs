using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
namespace M2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort sp = new SerialPort()
        {
            //PortName = "COM9",
            BaudRate = 115200,
            Parity = Parity.None,
            DataBits = 8,
            StopBits = StopBits.One,
            NewLine = "\r"
        };
        public void testwrite(Action action)
        {
            try
            {
                sp.PortName = comboBox1.Text;
                TaskFactory tf = new TaskFactory(); ;
                tf.StartNew(() =>
                {
                    sp.Open();
                    action();
                }
                );
            }
            catch (Exception e)
            {

                toolStripStatusLabel1.Text = e.Message;
            }
            
        }

        #region 命令
        public void power()
        {
            command("Power_DC_OUT 1 1");
            Thread.Sleep(900);
            command("Power_DC_OUT 1 0");
            Thread.Sleep(900);
            command("Power_DC_OUT 2 1");
            Thread.Sleep(900);
            command("Power_DC_OUT 2 0");
            Thread.Sleep(900);
            command("Power_DC_OUT 3 1");
            Thread.Sleep(900);
            command("Power_DC_OUT 3 0");
            Thread.Sleep(900);
            command("Power_DC_OUT 4 1");
            Thread.Sleep(900);
            command("Power_DC_OUT 4 0");
            Thread.Sleep(900);
            command("Power_DC_OUT 5 1");
            Thread.Sleep(900);
            command("Power_DC_OUT 5 0");
            Thread.Sleep(900);
            command("Power_DC_OUT 6 1");
            Thread.Sleep(900);
            command("Power_DC_OUT 6 0");
            sp.Close();

            sp.Close();
        }

        public void VoltageCheck()
        {
                command("Voltage_Check 1 1");
                DelayMis(1000);
                command("Voltage_Check 1 0");
                DelayMis(1000);
                command("Voltage_Check 2 1");
                DelayMis(1000);
                command("Voltage_Check 2 0");
                DelayMis(1000);
                command("Voltage_Check 3 1");
                DelayMis(1000);
                command("Voltage_Check 3 0");
                DelayMis(1000);
                command("Voltage_Check 4 1");
                DelayMis(1000);
                command("Voltage_Check 4 0");
                DelayMis(1000);
                command("Voltage_Check 5 1");
                DelayMis(1000);
                command("Voltage_Check 5 0");
                DelayMis(1000);
                command("Voltage_Check 6 1");
                DelayMis(1000);
                command("Voltage_Check 6 0");
                DelayMis(1000);
                command("Voltage_Check 7 1");
                DelayMis(1000);
                command("Voltage_Check 7 0");
                DelayMis(1000);
                command("Voltage_Check 8 1");
                DelayMis(1000);
                command("Voltage_Check 8 0");
                sp.Close();
           

        }

        public void CurrentCheck()
        {
           
                command("Current_Check 1 1");
                DelayMis(1000);
                command("Current_Check 1 0");
                DelayMis(1000);
                command("Current_Check 2 1");
                DelayMis(1000);
                command("Current_Check 2 0");
                sp.Close();
           

        }

        public void Load_RES()
        {
            
                command("Load 1 1");
                DelayMis(1000);
                command("Load 1 0");
                DelayMis(1000);
                command("Load 2 1");
                DelayMis(1000);
                command("Load 2 0");
                DelayMis(1000);
                command("Load 3 1");
                DelayMis(1000);
                command("Load 3 0");
                DelayMis(1000);
                command("Load 4 1");
                DelayMis(1000);
                command("Load 4 0");
                DelayMis(1000);
                command("Load 5 1");
                DelayMis(1000);
                command("Load 5 0");
                DelayMis(1000);
                command("Load 6 1");
                DelayMis(1000);
                command("Load 6 0");
                sp.Close();
            

        }

        public void EX_BT()
        {
            
                command("EX_BT 1 1");
                DelayMis(1000);
                command("EX_BT 1 0");
                DelayMis(1000);
                command("EX_BT 2 1");
                DelayMis(1000);
                command("EX_BT 2 0");
                sp.Close();
           

        }

        public void Warn_light()
        {
            
                command("Warn 1 1");
                DelayMis(1000);
                command("Warn 1 0");
                DelayMis(1000);
                command("Warn 2 1");
                DelayMis(1000);
                command("Warn 2 0");
                DelayMis(1000);
                command("Warn 3 1");
                DelayMis(1000);
                command("Warn 3 0");
                DelayMis(1000);
                command("Warn 4 1");
                DelayMis(1000);
                command("Warn 4 0");
                DelayMis(1000);
                command("Warn 5 1");
                DelayMis(1000);
                command("Warn 5 0");
                sp.Close();
           
        }

        public void Output_H_Level()
        {
            
                command("H_Level 1 1");
                DelayMis(1000);
                command("H_Level 1 0");
                DelayMis(1000);
                command("H_Level 2 1");
                DelayMis(1000);
                command("H_Level 2 0");
                DelayMis(1000);
                command("H_Level 3 1");
                DelayMis(1000);
                command("H_Level 3 0");
                DelayMis(1000);
                command("H_Level 4 1");
                DelayMis(1000);
                command("H_Level 4 0");
                DelayMis(1000);
                command("H_Level 5 1");
                DelayMis(1000);
                command("H_Level 5 0");
                DelayMis(1000);
                command("H_Level 6 1");
                DelayMis(1000);
                command("H_Level 6 0");
                DelayMis(1000);
                command("H_Level 7 1");
                DelayMis(1000);
                command("H_Level 7 0");
                DelayMis(1000);
                command("H_Level 8 1");
                DelayMis(1000);
                command("H_Level 8 0");
                sp.Close();
           
        }

        public void Output_L_Level()
        {
           
                command("L_Level 1 1");
                DelayMis(1000);
                command("L_Level 1 0");
                DelayMis(1000);
                command("L_Level 2 1");
                DelayMis(1000);
                command("L_Level 2 0");
                DelayMis(1000);
                command("L_Level 3 1");
                DelayMis(1000);
                command("L_Level 3 0");
                DelayMis(1000);
                command("L_Level 4 1");
                DelayMis(1000);
                command("L_Level 4 0");
                DelayMis(1000);
                command("L_Level 5 1");
                DelayMis(1000);
                command("L_Level 5 0");
                DelayMis(1000);
                command("L_Level 6 1");
                DelayMis(1000);
                command("L_Level 6 0");
                DelayMis(1000);
                command("L_Level 7 1");
                DelayMis(1000);
                command("L_Level 7 0");
                DelayMis(1000);
                command("L_Level 8 1");
                DelayMis(1000);
                command("L_Level 8 0");
                sp.Close();
           
        }

        public void Audio2IN()
        {
                command("Audio2_IN 1 1");
                DelayMis(1000);
                command("Audio2_IN 1 0");
                DelayMis(1000);
                command("Audio2_IN 2 1");
                DelayMis(1000);
                command("Audio2_IN 2 0");
                DelayMis(1000);
                command("Audio2_IN 3 1");
                DelayMis(1000);
                command("Audio2_IN 3 0");
                DelayMis(1000);
                command("Audio2_IN 4 1");
                DelayMis(1000);
                command("Audio2_IN 4 0");
                DelayMis(1000);
                command("Audio2_IN 5 1");
                DelayMis(1000);
                command("Audio2_IN 5 0");
                DelayMis(1000);
                command("Audio2_IN 6 1");
                DelayMis(1000);
                command("Audio2_IN 6 0");
                DelayMis(1000);
                command("Audio2_IN 7 1");
                DelayMis(1000);
                command("Audio2_IN 7 0");
                DelayMis(1000);
                command("Audio2_IN 8 1");
                DelayMis(1000);
                command("Audio2_IN 8 0");
                sp.Close();
            
        }

        public void Audio2_OUT()
        {
            
                command("Audio2_OUT 1 1");
                DelayMis(1000);
                command("Audio2_OUT 1 0");
                DelayMis(1000);
                command("Audio2_OUT 2 1");
                DelayMis(1000);
                command("Audio2_OUT 2 0");
                DelayMis(1000);
                command("Audio2_OUT 3 1");
                DelayMis(1000);
                command("Audio2_OUT 3 0");
                DelayMis(1000);
                command("Audio2_OUT 4 1");
                DelayMis(1000);
                command("Audio2_OUT 4 0");
                DelayMis(1000);
                command("Audio2_OUT 5 1");
                DelayMis(1000);
                command("Audio2_OUT 5 0");
                DelayMis(1000);
                command("Audio2_OUT 6 1");
                DelayMis(1000);
                command("Audio2_OUT 6 0");
                DelayMis(1000);
                command("Audio2_OUT 7 1");
                DelayMis(1000);
                command("Audio2_OUT 7 0");
                DelayMis(1000);
                command("Audio2_OUT 8 1");
                DelayMis(1000);
                command("Audio2_OUT 8 0");
                sp.Close();
           
        }

        public void Audio4_OUT()
        {
           
                command("Audio4_OUT 1 1");
                DelayMis(1000);
                command("Audio4_OUT 1 0");
                DelayMis(1000);
                command("Audio4_OUT 2 1");
                DelayMis(1000);
                command("Audio4_OUT 2 0");
                DelayMis(1000);
                command("Audio4_OUT 3 1");
                DelayMis(1000);
                command("Audio4_OUT 3 0");
                DelayMis(1000);
                command("Audio4_OUT 4 1");
                DelayMis(1000);
                command("Audio4_OUT 4 0");
                sp.Close();
           
        }

        public void Z_OUT1()
        {
           
                command("Z_OUT 1 1");
                DelayMis(1000);
                command("Z_OUT 1 0");
                DelayMis(1000);
                command("Z_OUT 2 1");
                DelayMis(1000);
                command("Z_OUT 2 0");
                DelayMis(1000);
                command("Z_OUT 3 1");
                DelayMis(1000);
                command("Z_OUT 3 0");
                DelayMis(1000);
                command("Z_OUT 4 1");
                DelayMis(1000);
                command("Z_OUT 4 0");
                sp.Close();
           

        }
        #endregion

        #region Other
        public void command(string command)
        {
            try
            {
                sp.WriteLine(command);
                this.textBox1.Invoke(new Action(() => {this.textBox1.Text = command; }));
            }
            catch (System.InvalidOperationException e)
            {

                toolStripStatusLabel1.Text = e.Message;
            }

        }

        private void DelayMis(int Milliseconds)
        {
            long start_ticks = DateTime.Now.Ticks;
            long end_ticks = DateTime.Now.Ticks + new TimeSpan(0, 0, 0, 0, Milliseconds).Ticks;
            //循环读取在规定时间内
            while (start_ticks <= end_ticks)
            {
                start_ticks = DateTime.Now.Ticks;
            }
        }
        #endregion

        #region button
        private void button1_Click(object sender, EventArgs e)
        {
            testwrite(power);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SerialPort.GetPortNames().OrderBy(t => t).ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testwrite(VoltageCheck);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testwrite(CurrentCheck);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testwrite(Audio2IN);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            testwrite(Audio2_OUT);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            testwrite(Audio4_OUT);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            testwrite(Output_H_Level);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            testwrite(Output_L_Level);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            testwrite(EX_BT);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            testwrite(Load_RES);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            testwrite(Z_OUT1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            testwrite(Warn_light);
        }
        #endregion
    }
}
