using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_deposit_calculator
{
    public partial class Form2 : Form
    {
        int X1 = 30;
        int X2 = 110;
        int Y = 50;
        int difX = 30;
        int difY = 30;

        public Form2()
        {
            InitializeComponent();
            init();
        }


        public void init()
        {
            this.Size = new Size(300, 500);

            move_textBox("存款利率2", 0, 0, 50);

            move_textBox("存款期限2", 0, 0, 50);
            move_textBox("存款期限4", 0, 0, 50);
            move_textBox("存款期限6", 0, 0, 50);
            move_ComboBox("期限种类2", 0, 0);

            this.label.Name = "标题";
            this.label.Location = new Point((this.Size.Width - this.label.Size.Width) / 2, 10);
            this.label.Show();

            this.labelType.Name = "币种1";
            this.labelType.Location = new Point(X1, Y);
            this.labelType.Show();

            this.comboBoxType.Name = "币种2";
            this.comboBoxType.Location = new Point(X2, Y - 5);
            this.comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxType.SelectedIndex = 0;
            this.comboBoxType.Show();

            this.buttonCalculate.Name = "计算";
            this.buttonReset.Name = "重置";
            this.radioButton1.Name = "自动";
            this.radioButton2.Name = "手动";
            this.radioButton3.Name = "不转存";
            this.radioButton4.Name = "转存";

            this.label.Show();
            this.labelType.Show();
            this.comboBoxType.Show();
            this.buttonCalculate.Show();
            this.buttonReset.Show();
            addition1();
        }

        private void addition1()
        {

            int y = 100;
            move_ComboBox("起存日期2", X2, y, 60);
            ComboBox c1 = (ComboBox)findC("起存日期2");
            c1.Items.Add("2018");
            c1.Items.Add("2019");
            c1.SelectedIndex = 0;
            c1.Hide();
            move_ComboBox("起存日期4", 0, 0, 60);
            ComboBox c2 = (ComboBox)findC("起存日期4");
            for(int i = 1; i <= 12; i++)
            {
                c2.Items.Add(i);
            }
            c2.SelectedIndex = 0;
            c2.Hide();

            move_ComboBox("起存日期6", X2, y, 60);
            ComboBox c3 = (ComboBox)findC("起存日期6");
            c3.Hide();
            for (int i = 1; i <= 31; i++)
            {
                c3.Items.Add(i);
            }
            c3.SelectedIndex = 0;

            move_ComboBox("结束日期2", X2, y, 60);
            ComboBox c4 = (ComboBox)findC("结束日期2");
            c4.Items.Add("2018");
            c4.Items.Add("2019");
            c4.SelectedIndex = 0;
            c4.Hide();

            move_ComboBox("结束日期4", 0, 0, 60);
            ComboBox c5 = (ComboBox)findC("结束日期4");
            c5.Hide();
            for (int i = 1; i <= 12; i++)
            {
                c5.Items.Add(i);
            }
            c5.SelectedIndex = 0;

            move_ComboBox("结束日期6", X2, y, 60);
            ComboBox c6 = (ComboBox)findC("结束日期6");
           
            for (int i = 1; i <= 31; i++)
            {
                c6.Items.Add(i);
            }
            c6.SelectedIndex = 0;
            c6.Hide();


            c2.SelectedIndexChanged += new System.EventHandler(count_Day1);
            c5.SelectedIndexChanged += new System.EventHandler(count_Day2);
        }
        private void count_Day1(Object sender, EventArgs args)
        {
            ComboBox c = (ComboBox)this.Controls["起存日期4"];
            ComboBox c1 = (ComboBox)this.Controls["起存日期6"];
            c1.Items.Clear();
            int month = (int)c.SelectedItem;
            if (month == 1 || month == 3 || month == 5 ||
                month == 7 || month == 8 || month == 10 || month == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    c1.Items.Add(i);
                }
                c1.SelectedIndex = 0;
            }
            else if (month == 2)
            {
                for (int i = 1; i <= 28; i++)
                {
                    c1.Items.Add(i);
                }
                c1.SelectedIndex = 0;

            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    c1.Items.Add(i);
                }
                c1.SelectedIndex = 0;

            }

        }
        private void count_Day2(Object sender, EventArgs args)
        {
            ComboBox c = (ComboBox)this.Controls["结束日期4"];
            ComboBox c1 = (ComboBox)this.Controls["结束日期6"];
            c1.Items.Clear();
            int month = (int)c.SelectedItem;
            if (month == 1 || month == 3 || month == 5 ||
                month == 7 || month == 8 || month == 10 || month == 12)
            {
                for (int i = 1; i <= 31; i++)
                {
                    c1.Items.Add(i);
                }
                c1.SelectedIndex = 0;
            }
            else if (month == 2)
            {
                for (int i = 1; i <= 28; i++)
                {
                    c1.Items.Add(i);
                }
                c1.SelectedIndex = 0;

            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    c1.Items.Add(i);
                }
                c1.SelectedIndex = 0;

            }

        }



        private void C2_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void all_Hide()
        {
            foreach (Control control in this.Controls)
            {
                string name = control.Name;
                if(name.Equals("label") || name.Equals("币种1")|| name.Equals("币种2")||name.Equals("Form2") )
                {
                    continue;
                }

                control.Hide();
            }
        }

        private void init_Show()
        {
            this.label.Show();
            this.labelType.Show();
            this.comboBoxType.Show();
            this.buttonCalculate.Show();
            this.buttonReset.Show();
        }

        public void init1()
        {

            all_Hide();
            init_Show();
            int x1 = this.X1;
            int x2 = this.X2;
            int y = this.labelType.Location.Y;
            y += difY;

            move_Label("存款种类1", "存款种类", x1, y);

            move_ComboBox("存款种类2", x2, y);
            ComboBox c1 = (ComboBox)findC("存款种类2");
            int index = c1.SelectedIndex;
            if (index == -1)
            {
                index = 0;
            }
            c1.Items.Clear();
            c1.Items.Add("选择存款种类");
            c1.Items.Add("活期");
            c1.Items.Add("定活两便");
            c1.Items.Add("存本取息");
            c1.Items.Add("整存整取");
            c1.Items.Add("零存整取");
            c1.Items.Add("通知存款");
            c1.DropDownStyle = ComboBoxStyle.DropDownList;




            y += difY;
            move_Label("存款金额1", "存款金额", x1, y);
            move_textBox("存款金额2", x2, y);
            move_Label("存款金额3", "元", 0, 0, findC("存款金额2"), true);


            c1.SelectedIndexChanged += new System.EventHandler(choose1);
            index = Math.Min(index, c1.Items.Count - 1);
            c1.SelectedIndex = index;

        }
        private void choose1(Object sender, EventArgs args)
        {
            int y = this.Controls["存款金额1"].Location.Y;
            y += difY;
            List<string> use = new List<string>();
            use.Clear();
            use.Add("标题");
            use.Add("币种1");
            use.Add("币种2");
            use.Add("存款种类1");
            use.Add("存款种类2");
            use.Add("计算");
            use.Add("重置");
            use.Add("自动");
            use.Add("手动");
            use.Add("存款金额1");
            use.Add("存款金额2");
            use.Add("存款金额3");

            Label label = (Label)this.Controls["存款金额1"];
            label.Text = "存款金额";
            string type = (string)((ComboBox)this.Controls["存款种类2"]).SelectedItem;
            System.Console.WriteLine("______________ " + type);
            if (type.Equals("选择存款种类"))
            {
                move_Label("期限种类1", "期限种类", X1, y);
                use.Add("期限种类1");

                move_ComboBox("期限种类2", X2, y);
                use.Add("期限种类2");
                ComboBox c = (ComboBox)this.Controls["期限种类2"];
                c.SelectedIndexChanged -= new System.EventHandler(choose2);
                c.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = c.SelectedIndex;
                if(index == -1)
                {
                    index = 0;
                }
                c.Items.Clear();
                c.Items.Add("选择期限种类");
                
                c.SelectedIndex = Math.Min(index,c.Items.Count-1);

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");

            }
            else if (type.Equals("活期"))
            {
                
                move_Label("起存日期1", "起存日期", X1, y + difY / 2);
                use.Add("起存日期1");

                move_ComboBox("起存日期2", X2, y, 60);
                ComboBox c1 = (ComboBox)findC("起存日期2");
                use.Add("起存日期2");

                move_Label("起存日期3", "年", 0, 0, findC("起存日期2"), false);
                use.Add("起存日期3");

                move_ComboBox("起存日期4", 0, 0, 60, findC("起存日期3"));
                ComboBox c2 = (ComboBox)findC("起存日期4");
                use.Add("起存日期4");

                move_Label("起存日期5", "月", 0, 0, findC("起存日期4"), true);
                use.Add("起存日期5");

                y += difY;

                move_ComboBox("起存日期6", X2, y, 60);
                ComboBox c3 = (ComboBox)findC("起存日期6");
                use.Add("起存日期6");

                move_Label("起存日期7", "日", 0, 0, findC("起存日期6"), true);
                use.Add("起存日期7");

                y += difY;
                
                move_Label("结束日期1", "结束日期", X1, y + difY / 2);
                use.Add("结束日期1");

                move_ComboBox("结束日期2", X2, y, 60);
                ComboBox c4 = (ComboBox)findC("结束日期2");
                use.Add("结束日期2");

                move_Label("结束日期3", "年", 0, 0, findC("结束日期2"), false);
                use.Add("结束日期3");

                move_ComboBox("结束日期4", 0, 0, 60, findC("结束日期3"));
                ComboBox c5 = (ComboBox)findC("结束日期4");
                use.Add("结束日期4");

                move_Label("结束日期5", "月", 0, 0, findC("结束日期4"), true);
                use.Add("结束日期5");

                y += difY;

                move_ComboBox("结束日期6", X2, y, 60);
                ComboBox c6 = (ComboBox)findC("结束日期6");
                use.Add("结束日期6");

                move_Label("结束日期7", "日", 0, 0, findC("结束日期6"), true);
                use.Add("结束日期7");

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");

            }
            else if (type.Equals("定活两便")){

                move_Label("存款期限1", "存款期限", X1, y + difY / 2);
                use.Add("存款期限1");

                move_textBox("存款期限2", X2, y, 60);
                use.Add("存款期限2");

                move_Label("存款期限3", "年", 0, 0, findC("存款期限2"), false);
                use.Add("存款期限3");

                move_textBox("存款期限4", 0, 0, 60, findC("存款期限3"));
                use.Add("存款期限4");

                move_Label("存款期限5", "月", 0, 0, findC("存款期限4"), true);
                use.Add("存款期限5");

                y += difY;

                move_textBox("存款期限6", X2, y, 60);
                use.Add("存款期限6");

                move_Label("存款期限7", "日", 0, 0, findC("存款期限6"), true);
                use.Add("存款期限7");

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");

            }
            else if (type.Equals("存本取息"))
            {
                move_Label("期限种类1", "期限种类", X1, y);
                use.Add("期限种类1");

                move_ComboBox("期限种类2", X2, y);
                use.Add("期限种类2");
                ComboBox c = (ComboBox)this.Controls["期限种类2"];
                c.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = c.SelectedIndex;
                if (index == -1)
                {
                    index = 0;
                }
                c.Items.Clear();
                c.Items.Add("选择期限种类");
                c.Items.Add("一年");
                c.Items.Add("三年");
                c.Items.Add("五年");
                index = Math.Min(index, c.Items.Count - 1);
                c.SelectedIndexChanged -= new System.EventHandler(choose2);
                c.SelectedIndex = index;

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("每月利息1", "每月利息", X1, y);
                use.Add("每月利息1");

                move_textBox("每月利息2", X2, y);
                use.Add("每月利息2");

                move_Label("每月利息3", "元", 0, 0, findC("每月利息2"), true);
                use.Add("每月利息3");

                y += difY; 
                move_Label("累计利息1", "累计利息", X1, y);
                use.Add("累计利息1");

                move_textBox("累计利息2", X2, y);
                use.Add("累计利息2");

                move_Label("累计利息3", "元", 0, 0, findC("累计利息2"), true);
                use.Add("累计利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");


            }
            else if (type.Equals("整存整取"))
            {
                move_Label("期限种类1", "期限种类", X1, y);
                use.Add("期限种类1");

                move_ComboBox("期限种类2", X2, y);
                use.Add("期限种类2");
                ComboBox c = (ComboBox)this.Controls["期限种类2"];
                c.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = c.SelectedIndex;
                if (index == -1)
                {
                    index = 0;
                }
                c.Items.Clear();
                c.Items.Add("选择期限种类");
                c.Items.Add("三个月");
                c.Items.Add("半年");
                c.Items.Add("一年");
                c.Items.Add("二年");
                c.Items.Add("三年");
                c.Items.Add("五年");
                index = Math.Min(index, c.Items.Count - 1);
                c.SelectedIndex = index;

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;

                move_Label("约定转存选择1", "约定转存选择", X1, y);
                use.Add("约定转存选择1");
                this.radioButton3.Location = new_Point(findC("约定转存选择1"));
                this.radioButton3.Show();
                use.Add("不转存");

                this.radioButton3.Checked = true;

                this.radioButton4.Location = new_Point(radioButton3);
                this.radioButton4.Show();
                use.Add("转存");
                use.Add("flowLayoutPanel1");
                this.flowLayoutPanel1.Location = new_Point(findC("约定转存选择1"));

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");


            }
            else if (type.Equals("零存整取"))
            {

                label.Text = "每期存入金额";

                move_Label("期限种类1", "期限种类", X1, y);
                use.Add("期限种类1");

                move_ComboBox("期限种类2", X2, y);
                use.Add("期限种类2");
                ComboBox c = (ComboBox)this.Controls["期限种类2"];
                c.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = c.SelectedIndex;
                if (index == -1)
                {
                    index = 0;
                }
                c.Items.Clear();
                c.Items.Add("选择期限种类");
                c.Items.Add("一年");
                c.Items.Add("三年");
                c.Items.Add("五年");
                index = Math.Min(index, c.Items.Count - 1);
                c.SelectedIndex = index;

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");


            }
            else if (type.Equals("通知存款"))
            {
                move_Label("期限种类1", "期限种类", X1, y);
                use.Add("期限种类1");

                move_ComboBox("期限种类2", X2, y);
                use.Add("期限种类2");
                ComboBox c = (ComboBox)this.Controls["期限种类2"];
                c.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = c.SelectedIndex;
                if (index == -1)
                {
                    index = 0;
                }
                c.Items.Clear();
                c.Items.Add("选择期限种类");
                c.Items.Add("一天");
                c.Items.Add("七天");
                index = Math.Min(index, c.Items.Count - 1);
                c.SelectedIndex = index;

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");


            }
            foreach (Control temp in this.Controls)
            {
                string name = temp.Name;
                bool flag = false;
                System.Console.WriteLine(name);
                foreach(string has in use)
                {
                    if (name.Equals(has))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    temp.Hide();
                }
                else
                {
                    temp.Show();
                }
            }
        }

        public void choose1_1(Object sender, EventArgs args)
        {

        }

        private void init2()
        {
            all_Hide();
            init_Show();

            int y = this.Controls["币种1"].Location.Y;
            y += difY;
            List<string> use = new List<string>();
            use.Clear();
            use.Add("标题");
            use.Add("币种1");
            use.Add("币种2");
            use.Add("计算");
            use.Add("重置");
            use.Add("自动");
            use.Add("手动");

            move_Label("期限种类1", "期限种类", X1, y);
            use.Add("期限种类1");

            move_ComboBox("期限种类2", X2, y);
            use.Add("期限种类2");
            ComboBox c = (ComboBox)this.Controls["期限种类2"];
            c.DropDownStyle = ComboBoxStyle.DropDownList;
            int index = c.SelectedIndex;
            if (index == -1)
            {
                index = 0;
            }
            c.Items.Clear();
            c.Items.Add("活期");
            c.Items.Add("一个月");
            c.Items.Add("三个月");
            c.Items.Add("六个月");
            c.Items.Add("一年");
            c.Items.Add("两年");
            c.Items.Add("七天通知");
            index = Math.Min(index, c.Items.Count - 1);
            c.SelectedIndexChanged -= new System.EventHandler(choose1);
            c.SelectedIndexChanged += new System.EventHandler(choose2);
            c.SelectedIndex = index;


        }
        private void choose2(Object sender, EventArgs args)
        {
            string type0 = (string)((ComboBox)this.Controls["币种2"]).SelectedItem;
            if (type0.Equals("人民币"))
            {
                return;
            }


            int y = this.Controls["期限种类1"].Location.Y;
            y += difY;
            List<string> use = new List<string>();
            use.Clear();
            use.Add("标题");
            use.Add("币种1");
            use.Add("币种2");
            use.Add("计算");
            use.Add("重置");
            use.Add("自动");
            use.Add("手动");
            use.Add("期限种类1");
            use.Add("期限种类2");

            string type = (string)((ComboBox)this.Controls["期限种类2"]).SelectedItem;

            if (type.Equals("活期"))
            {
                move_Label("存款金额1", "存款金额", X1, y);
                use.Add("存款金额1");
                move_textBox("存款金额2", X2, y);
                use.Add("存款金额2");
                move_Label("存款金额3", "元", 0, 0, findC("存款金额2"), true);
                use.Add("存款金额3");

                y += difY;
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");


            }
            else
            {
                move_Label("利率输入选择1", "利率输入选择", X1, y);
                use.Add("利率输入选择1");

                this.radioButton1.Location = new_Point(findC("利率输入选择1"));
                this.radioButton1.Show();

                this.radioButton2.Location = new_Point(radioButton1);
                this.radioButton2.Show();
                y += difY;

                move_Label("存款利率1", "存款利率（年利率）", X1, y);
                use.Add("存款利率1");

                move_textBox("存款利率2", 0, 0, 50, findC("存款利率1"));
                use.Add("存款利率2");
                if (this.radioButton1.Checked)
                {
                    TextBox t = (TextBox)findC("存款利率2");
                    t.ReadOnly = true;
                }

                move_Label("存款利率3", "%", 0, 0, findC("存款利率2"), true);
                use.Add("存款利率3");

                this.radioButton1.Checked = true;

                y += difY;
                this.buttonCalculate.Location = new Point(X1 + 20, y);
                this.buttonCalculate.Show();
                this.buttonReset.Location = new Point(X2 + 50, y);
                this.buttonReset.Show();

                y += difY;
                y += difY;

                move_Label("存款利息1", "存款利息", X1, y);
                use.Add("存款利息1");

                move_textBox("存款利息2", X2, y);
                use.Add("存款利息2");

                move_Label("存款利息3", "元", 0, 0, findC("存款利息2"), true);
                use.Add("存款利息3");

                y += difY;

                move_Label("本息合计1", "本息合计", X1, y);
                use.Add("本息合计1");

                move_textBox("本息合计2", X2, y);
                use.Add("本息合计2");

                move_Label("本息合计3", "元", 0, 0, findC("本息合计2"), true);
                use.Add("本息合计3");

            }

            foreach (Control temp in this.Controls)
            {
                string name = temp.Name;
                bool flag = false;
                System.Console.WriteLine(name);
                foreach (string has in use)
                {
                    if (name.Equals(has))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    temp.Hide();
                }
                else
                {
                    temp.Show();
                }
            }


        }

        public void move_Label(string name, string text, int x, int y, Control control = null, bool correct = false)
        {
            Label label = (Label)this.Controls[name];
            if (label == null)
            {
                create_Label(name, text, x, y, control, correct);
            }
            else
            {
                label.Text = text;
                if (control != null)
                {
                    x = new_Point(control, correct).X - x;
                    y = new_Point(control, correct).Y - y;
                }
                label.Location = new Point(x, y);
                label.Show();
            }



        }

        public void move_textBox(string name, int x, int y, int sub_Width = 0, Control control = null, bool correct = false)
        {
            TextBox textBox = (TextBox)this.Controls[name];
            if (textBox == null)
            {
                create_TextBox(name, x, y, sub_Width, control, correct);
            }
            else
            {
                if (control != null)
                {
                    x = new_Point(control, correct).X - x;
                    y = new_Point(control, correct).Y - y;
                }
                textBox.Location = new Point(x, y);
                textBox.Show();
            }


        }

        public void move_ComboBox(string name, int x, int y, int sub_Width = 0, Control control = null, bool correct = false)
        {
            ComboBox comboBox = (ComboBox)this.Controls[name];
            if (comboBox == null)
            {
                create_ComboBox(name, x, y, sub_Width, control, correct);
            }
            else
            {
                if (control != null)
                {
                    x = new_Point(control, correct).X - x;
                    y = new_Point(control, correct).Y - y;
                }
                comboBox.Location = new Point(x, y);
                comboBox.Show();
            }
        }



        public void create_Label(string name, string text, int x, int y, Control control = null, bool correct = false)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = text;
            label.AutoSize = true;
            if (control != null)
            {
                x = new_Point(control, correct).X - x;
                y = new_Point(control, correct).Y - y;
            }
            label.Location = new Point(x, y);

            this.Controls.Add(label);
        }

        public void create_TextBox(string name, int x, int y, int sub_Width = 0, Control control = null, bool correct = false)
        {
            TextBox textBox = new TextBox();
            textBox.Name = name;

            textBox.Size = new Size(textBox.Size.Width - sub_Width, textBox.Size.Height);
            if (control != null)
            {
                x = new_Point(control, correct).X - x;
                y = new_Point(control, correct).Y - y;
            }
            textBox.Location = new Point(x, y);

            this.Controls.Add(textBox);
        }

        public void create_ComboBox(string name, int x, int y, int sub_Width = 0, Control control = null, bool correct = false)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Name = name;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList; 
            comboBox.Size = new Size(comboBox.Size.Width - sub_Width, comboBox.Size.Height);
            if (control != null)
            {
                x = new_Point(control, correct).X - x;
                y = new_Point(control, correct).Y - y;
            }
            comboBox.Location = new Point(x, y);
            this.Controls.Add(comboBox);
            if (name.Equals("期限种类2"))
            {
                comboBox.SelectedIndexChanged += new System.EventHandler(choose_Rate);
            }
            if (name.Equals("存款种类2"))
            {
                comboBox.SelectedIndexChanged += new System.EventHandler(choose_Rate);
            }
        }



        private Control findC(string name)
        {
            Control control = (Control)(this.Controls.Find(name, true).First());
            return control;

        }

        private Point new_Point(Control control, bool correct = false)
        {
            if (correct)
            {
                return new Point(control.Location.X + control.Size.Width, control.Location.Y + 5);

            }
            else
            {
                return new Point(control.Location.X + control.Size.Width, control.Location.Y);


            }
        }


        private void type_Change(object sender, EventArgs s)
        {
            string type = (string)this.comboBoxType.SelectedItem;

            if (type.Equals("人民币"))
            {
                init1();
            }
            else 
            {
                init2();
            }
        }




        private void is_Auto(object sender, EventArgs e)
        {
            TextBox t = (TextBox)this.Controls["存款利率2"];
           
            if (this.radioButton1.Checked)
            {

                t.ReadOnly = true;
                ComboBox c = (ComboBox)this.Controls["币种2"];
                TextBox r = (TextBox)this.Controls["存款利率2"];

                string type = (string)c.SelectedItem;
                if (type.Equals("人民币"))
                {
                    ComboBox c1 = (ComboBox)this.Controls["存款种类2"];
                    string s1 = (string)c1.SelectedItem;
                    if (s1.Equals("活期")){
                        r.Text = "0.30";
                    }
                    else if (s1.Equals("定活两便"))
                    {
                        string d1 = (string)((TextBox)this.Controls["存款期限2"]).Text;
                        string d2 = (string)((TextBox)this.Controls["存款期限4"]).Text;
                        string d3 = (string)((TextBox)this.Controls["存款期限6"]).Text;

                        if (d1.Equals(""))
                        {
                            d1 = "0";
                            
                            
                        }
                        if (d2.Equals(""))
                        {
                            d2 = "0";
                        }
                        if (d3.Equals(""))
                        {
                            d3 = "0";
                        }
                        int year;
                        bool flag = true;
                        if (int.TryParse(d1, out year))
                        {

                        }
                        else
                        {
                            MessageBox.Show("请输入正确年份");
                            flag = false;
                        }
                        int month;
                        if (int.TryParse(d2, out month))
                        {

                        }
                        else
                        {
                            MessageBox.Show("请输入正确月份");
                            flag = false;
                        }

                        int day;
                        if (int.TryParse(d3, out day))
                        {

                        }
                        else
                        {
                            MessageBox.Show("请输入正确日数");
                            flag = false;
                        }

                        if(flag == false)
                        {
                            return;
                        }


                        if (year < 0 || year > 100)
                        {
                            MessageBox.Show("请输入正确年份");
                            flag = false;

                        }
                        else if (month < 0 || month > 11)
                        {
                            MessageBox.Show("请输入正确月份");
                            flag = false;

                        }
                        else if (day < 0 || day > 31)
                        {
                            MessageBox.Show("请输入正确日数");
                            flag = false;

                        }

                        if (flag == false)
                        {
                            r.Text = "";
                            return;
                        }


                        if (year > 0)
                        {
                            r.Text = "1.05";
                        }
                        else
                        {
                            if (month < 3 || (month==3&&day==0))
                            {
                                r.Text = "0.3";
                            }
                            else if (month < 6 || (month == 6 && day == 0))
                            {
                                r.Text = "0.81";
                            }
                            else 
                            {
                                r.Text = "0.93";
                            }
                        }



                    }
                    else if(s1.Equals("存本取息"))
                    {
                        ComboBox c2 = (ComboBox)this.Controls["期限种类2"];
                        string s2 = (string)c2.SelectedItem;
                        if (s2.Equals("一年"))
                        {
                            r.Text = "1.35";
                        }
                        else if (s2.Equals("三年"))
                        {
                            r.Text = "1.55";
                        }
                        else if (s2.Equals("五年"))
                        {
                            r.Text = "1.55";
                        }
                        else
                        {
                            r.Text = "";

                        }


                    }
                    else if (s1.Equals("整存整取"))
                    {
                        ComboBox c2 = (ComboBox)this.Controls["期限种类2"];
                        string s2 = (string)c2.SelectedItem;
                        if (s2.Equals("三个月"))
                        {
                            r.Text = "1.35";
                        }
                        else if (s2.Equals("半年"))
                        {
                            r.Text = "1.55";
                        }
                        else if (s2.Equals("一年"))
                        {
                            r.Text = "1.75";
                        }
                        else if (s2.Equals("二年"))
                        {
                            r.Text = "2.25";
                        }
                        else if (s2.Equals("三年"))
                        {
                            r.Text = "2.75";
                        }
                        else if (s2.Equals("五年"))
                        {
                            r.Text = "2.75";
                        }
                        else
                        {
                            r.Text = "";

                        }

                    }
                    else if (s1.Equals("零存整取"))
                    {
                        ComboBox c2 = (ComboBox)this.Controls["期限种类2"];
                        string s2 = (string)c2.SelectedItem;
                        if (s2.Equals("一年"))
                        {
                            r.Text = "1.35";
                        }
                        else if (s2.Equals("三年"))
                        {
                            r.Text = "1.55";
                        }
                        else if (s2.Equals("五年"))
                        {
                            r.Text = "1.55";
                        }
                        else
                        {
                            r.Text = "";

                        }


                    }
                    else if (s1.Equals("通知存款"))
                    {
                        ComboBox c2 = (ComboBox)this.Controls["期限种类2"];
                        string s2 = (string)c2.SelectedItem;
                        if (s2.Equals("一天"))
                        {
                            r.Text = "0.55";
                        }
                        
                        else if (s2.Equals("七天"))
                        {
                            r.Text = "1.10";
                        }
                        else
                        {
                            r.Text = "";

                        }


                    }
                }
                else
                {
                    ComboBox c2 = (ComboBox)this.Controls["期限种类2"];
                    string s2 = (string)c2.SelectedItem;
                    if (s2.Equals("活期"))
                    {
                        if (type.Equals("英镑"))
                        {
                            r.Text = "0.05";

                        }
                        else if (type.Equals("澳大利亚元"))
                        {

                            r.Text = "0.2";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("美元"))
                        {

                            r.Text = "0.05";
                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.0001";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.005";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.0001";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.01";

                        }
                    }

                    else if (s2.Equals("一个月"))
                    {
                        if (type.Equals("英镑"))
                        {
                            r.Text = "0.1";

                        }
                        else if (type.Equals("澳大利亚元"))
                        {
                            r.Text = "1.2";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.05";

                        }
                        else if (type.Equals("美元"))
                        {
                            r.Text = "0.2";

                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.03";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.1";

                        }
                    }
                    if (s2.Equals("三个月"))
                    {
                        if (type.Equals("英镑"))
                        {

                            r.Text = "0.1";
                        }
                        else if (type.Equals("澳大利亚元"))
                        {
                            r.Text = "1.3";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.05";

                        }
                        else if (type.Equals("美元"))
                        {

                            r.Text = "0.3";
                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.05";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.25";

                        }
                    }
                    if (s2.Equals("六个月"))
                    {
                        if (type.Equals("英镑"))
                        {

                            r.Text = "0.1";
                        }
                        else if (type.Equals("澳大利亚元"))
                        {
                            r.Text = "1.3";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.3";

                        }
                        else if (type.Equals("美元"))
                        {

                            r.Text = "0.5";
                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.15";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.5";

                        }
                    }
                    if (s2.Equals("一年"))
                    {
                        if (type.Equals("英镑"))
                        {

                            r.Text = "0.1";
                        }
                        else if (type.Equals("澳大利亚元"))
                        {
                            r.Text = "1.5";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.4";

                        }
                        else if (type.Equals("美元"))
                        {

                            r.Text = "0.8";
                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.2";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.7";

                        }
                    }
                    if (s2.Equals("二年"))
                    {
                        if (type.Equals("英镑"))
                        {

                            r.Text = "0.1";
                        }
                        else if (type.Equals("澳大利亚元"))
                        {
                            r.Text = "1.5";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.4";

                        }
                        else if (type.Equals("美元"))
                        {

                            r.Text = "0.8";
                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.25";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.01";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.75";

                        }
                    }
                    if (s2.Equals("七天通知"))
                    {
                        if (type.Equals("英镑"))
                        {

                            r.Text = "0.05";
                        }
                        else if (type.Equals("澳大利亚元"))
                        {
                            r.Text = "0.25";

                        }
                        else if (type.Equals("加拿大元"))
                        {
                            r.Text = "0.05";

                        }
                        else if (type.Equals("美元"))
                        {

                            r.Text = "0.05";
                        }
                        else if (type.Equals("日元"))
                        {
                            r.Text = "0.0005";

                        }
                        else if (type.Equals("欧元"))
                        {
                            r.Text = "0.005";

                        }
                        else if (type.Equals("瑞士法郎"))
                        {
                            r.Text = "0.0005";

                        }
                        else if (type.Equals("港币"))
                        {
                            r.Text = "0.01";

                        }
                    }


                }

            }
            else
            {
                t.ReadOnly = false;
            }
        }    

        private void choose_Rate(object sender,EventArgs e)
        {
            this.radioButton2.Checked = true;
            this.radioButton1.Checked = true;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)this.Controls["币种2"];
            string type = (string)c.SelectedItem;
            if (type.Equals("人民币"))
            {
                init1();
            }
            else
            {
                init2();
            }
            System.Console.WriteLine("______________________________________________");

            foreach (Control control in this.Controls)
            {
                System.Console.WriteLine(control.Name);
            }
            System.Console.WriteLine("______________________________________________");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double money;
            TextBox t1 = (TextBox)this.Controls["存款金额2"];
            
            string s1 = (string)t1.Text;
            if (s1.Equals(""))
            {
                s1 = "0";
            }
            if(double.TryParse(s1,out money))
            {

            }
            else
            {
                MessageBox.Show("请输入正确存款金额");
            }

            if (money < 0 || money > 1e9)
            {

                MessageBox.Show("请输入正确存款金额");
            }

            double rate;
            TextBox t2 = (TextBox)this.Controls["存款利率2"];
            string s2 = (string)t2.Text;
            if (s2.Equals(""))
            {
                s2 = "0";
            }
            if (double.TryParse(s2, out rate))
            {

            }
            else
            {
                MessageBox.Show("请输入正确年利率");
            }

            if (money < 0 || money > 1e9)
            {

                MessageBox.Show("请输入正确年利率");
            }



            ComboBox c1 = (ComboBox)this.Controls["币种2"];
            string type = (string)c1.SelectedItem;



            ComboBox c2 = (ComboBox)this.Controls["存款种类2"];
            string type2 = (string)c2.SelectedItem;

            if (type.Equals("人民币"))
            {
                if (type2.Equals("活期"))
                {




                }
                else if (type2.Equals("定活两便"))
                {

                }
                else if (type2.Equals("存本取息"))
                {

                }
                else if (type2.Equals("整存整取"))
                {

                }
                else if (type2.Equals("零存整取"))
                {

                }
                else if (type2.Equals("通知存款"))
                {

                }
                else
                {

                }
            }
            else
            {
                if (type2.Equals("活期"))
                {

                }
                else 
                {

                }

            }

        }
    }
}