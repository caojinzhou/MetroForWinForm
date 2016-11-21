using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MetroFramework.Demo
{
    public partial class LeadData : Form
    {
        List<string> Columnname = new List<string>();
        //List<string> Matchvalue = new List<string>();

        //传值
        char sybol = ' ';
        string istt = "";
        private string string1;
        private string string2;
        public string comevalue1
        {
            set
            {
                string1 = value;
            }
        }

        public string comevalue2
        {
            set
            {
                string2 = value;
            }
        }
        //显示
        public void SetValue()
        {
            this.label7.Text = string2+".TXT";
        }

        public LeadData()
        {
            InitializeComponent();
        }
       
        private void LeadData_Load(object sender, EventArgs e)
        {
            step1();          
        }

        private void nextbt_Click(object sender, EventArgs e)
        {
            Columnname.Clear();          

            //string path = "F:\\A.txt";

            FileStream fs = File.OpenRead(string1);
            StreamReader sr = new StreamReader(fs);
           
            if (tabrb.Checked)
            {
                sybol = '\t';
            }
            if (semicolonrb.Checked)
            {
                sybol = ';';
            }
            if (commarb.Checked)
            {
                sybol = ',';
            }
            if (Spacerb.Checked)
            {
                sybol = ' ';
            }
            
            if (isTitle.CheckState==CheckState.Unchecked)
            {
                istt = "no";
                string[] strArr = sr.ReadLine().Split(sybol);
                if (strArr.Length < 5)
                {
                    MessageBox.Show("对不起，您的数据不完整，或分隔符不正确！","提示");
                    step1();
                }
                else
                {
                    for (int j = 0; j < strArr.Length; j++)
                    {
                        Columnname.Add(strArr[j]);
                    }
                    step2();
                }                         
            }
            if (isTitle.CheckState == CheckState.Checked)
            {
                istt = "yes";
                string[] strArr = sr.ReadLine().Split(sybol);
                if (strArr.Length < 5)
                {
                    MessageBox.Show("对不起，您的数据不完整，或分隔符不正确！","提示");
                    step1();
                }
                else
                {
                   
                    for (int j = 0; j < strArr.Length; j++)
                    {
                        int i = j + 1;
                        Columnname.Add("Field" + i);
                    }
                    step2();
                }               
            }       
        }
        public void step1()
        {
            cancelbt.Location = new System.Drawing.Point(156, 210);
            nextbt.Location = new System.Drawing.Point(15, 210);
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            isTitle.Visible = true;
            cancelbt.Visible = true;
            nextbt.Visible = true;
            okbt.Visible = false;
            backbt.Visible = false;
        }
        public void step2()
        {
            groupBox1.Location = new System.Drawing.Point(15, 34);
            okbt.Location = new System.Drawing.Point(156, 270);
            backbt.Location = new System.Drawing.Point(15, 270);
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            backbt.Visible = true;
            okbt.Visible = true;
            isTitle.Visible = false;
            cancelbt.Visible = false;
            nextbt.Visible = false;
            adddatacb(comboBox1);
            adddatacb(comboBox2);
            adddatacb(comboBox3);
            adddatacb(comboBox4);
            adddatacb(comboBox5);
        }

        public void adddatacb(ComboBox cb)
        {
            cb.Items.Clear();
            for (int i = 0; i < Columnname.Count; i++)
            {                
                cb.Items.Add(Columnname[i]);
                cb.SelectedIndex = 0;
                cb.Text = Columnname[0];
            }
        }

        private void isTitle_CheckedChanged(object sender, EventArgs e)
        {
            Columnname.Clear();
        }

        private void okbt_Click(object sender, EventArgs e)
        {
            //把Form2的父窗口指针赋给lForm1      
            MainForm lForm1 = (MainForm)this.Owner;
            //在Matchvalue保存用户现在的列名以及顺序                                     
            lForm1.Matchvalue.Add(comboBox1.SelectedItem.ToString());
            lForm1.Matchvalue.Add(comboBox2.SelectedItem.ToString());
            lForm1.Matchvalue.Add(comboBox3.SelectedItem.ToString());
            lForm1.Matchvalue.Add(comboBox4.SelectedItem.ToString());
            lForm1.Matchvalue.Add(comboBox5.SelectedItem.ToString());
            lForm1.chuandifenge = sybol;  //传递分隔符
            lForm1.ischoosett = istt;
            List<string> isok = lForm1.Matchvalue.Distinct().ToList();
            lForm1.Matchvalue = lForm1.Matchvalue.Distinct().ToList();
            int num = isok.Count();
            //检查是否有重复的字段
            if (num < 5)
            {
                MessageBox.Show("请检查匹配字段是否有重复！", "提示");
            }
            else
            {
                lForm1.AddTableData();
                this.Close();
            }

        }

        private void backbt_Click(object sender, EventArgs e)
        {
            step1();
        }

        private void cancelbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
