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
    public partial class Form1 : Form
    {

        List<Label> listLabel = new List<Label>();
        List<TextBox> listText = new List<TextBox>();
        List<ComboBox> listCom = new List<ComboBox>();
        List<RadioButton> listRad = new List<RadioButton>();
        int initX = 50;
        int initY = 100;
        int difY = 30;
        int difX = 60;

        public Form1()
        {
            InitializeComponent();
            init();
        }


        private void initControls()
        {
            addTypeLabel();
            addTypeCom();
            addAmountLabel();

        }

        private void addTypeLabel()
        {
            Label label1 = new Label();
            label1.Text = "存款种类";
            label1.Name = "typeLabel";
            label1.AutoSize = true;
        }

        private void addTypeCom()
        {
            ComboBox combox1 = new ComboBox();
            combox1.Items.Add("请选择存款种类");
            combox1.Name = "typeCom";
            combox1.SelectedIndex = 0;
            combox1.DropDownStyle = ComboBoxStyle.DropDownList;
            combox1.SelectedIndexChanged += new System.EventHandler(this.typeComChanged);

        }

        private void addAmountLabel()
        {

            Label label2 = new Label();
            label2.Text = "存款金额";
            label2.Name = "amountLabel1";
            label2.AutoSize = true;

        }

        private void addAmountText()
        {
            TextBox text1 = new TextBox();
            text1.Text = "";
            text1.Name = "amountText";

        }

        private void addAmountLabel2()
        {

            Label label3 = new Label();
            label3.Text = "元";
            label3.Name = "amountLabel2";
            label3.AutoSize = true;
        }








        public void select(object sender, EventArgs e)
        {

            //clearList();
            string type = (string)this.comboBoxType.SelectedItem;
            if (type.Equals("人民币"))
            {
                initType1(0);
            }
        }
        
        public void clearList()
        {
            for(int i = listLabel.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(listLabel[i]);
                listLabel.RemoveAt(i);
            }
            for (int i = listText.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(listText[i]);
                listText.RemoveAt(i);
            }
            for (int i = listCom.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(listCom[i]);
                listCom.RemoveAt(i);
            }
            for (int i = listRad.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(listRad[i]);
                listRad.RemoveAt(i);
            }

        }

        public void init()
        {
            this.comboBoxType.SelectedIndex = 0;
            this.AutoSize = true;
        }

        public void initType1(int controlType)
        {

            //clearList();
            int X = initX;
            int Y = initY;
            Label label1 = new Label();
            label1.Text = "存款种类";
            label1.Name = "typeLabel";
            label1.Location = new Point(X,Y);
            label1.AutoSize = true;
            this.Controls.Add(label1);
            listLabel.Add(label1);


            if (controlType != 1)
            {
                ComboBox combox1 = new ComboBox();
                combox1.Items.Add("请选择存款种类");
                combox1.Name = "typeCom";
                combox1.Items.Add("活期");
                combox1.Items.Add("定活两便");
                combox1.Items.Add("存本取息");
                combox1.Items.Add("整存整取");
                combox1.Items.Add("零存整取");
                combox1.Items.Add("通知存款");
                combox1.SelectedIndex = 0;
                combox1.Location = new Point(X + difX, Y - 5);
                combox1.DropDownStyle = ComboBoxStyle.DropDownList;
                combox1.SelectedIndexChanged += new System.EventHandler(this.typeComChanged);
                this.Controls.Add(combox1);
                listCom.Add(combox1);

                Y += difY;

            }
            

            Label label2 = new Label();
            label2.Text = "存款金额";
            label2.Name = "amountLabel";
            label2.Location = new Point(X, Y);
            label2.AutoSize = true;
            this.Controls.Add(label2);
            listLabel.Add(label2);


            
            TextBox text1 = new TextBox();
            text1.Text = "";
            text1.Name = "amountText1";
            text1.Location = new Point(X + difX, Y - 5);
            this.Controls.Add(text1);
            listText.Add(text1);

            Label label3 = new Label();
            label3.Text = "元";
            label3.Name = "amountText2";
            label3.Location = new Point(text1.Location.X + text1.Size.Width, Y);
            label3.AutoSize = true;
            this.Controls.Add(label3);
            listLabel.Add(label3);


            Y += difY;

            Label label4 = new Label();
            label4.Text = "期限种类";
            label4.Name = "termLabel";
            label4.Location = new Point(X, Y);
            label4.AutoSize = true;
            this.Controls.Add(label4);
            listLabel.Add(label4);


            ComboBox combox2 = new ComboBox();
            combox2.Items.Add("选择期限种类");
            combox2.Name = "termCom";
            combox2.SelectedIndex = 0;
            combox2.Location = new Point(X + difX, Y - 5);
            combox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(combox2);
            listCom.Add(combox2);

            Y += difY;

            Label label5 = new Label();
            label5.Text = "利率输入选择";
            label5.Name = "rateTypeLabel";
            label5.Location = new Point(X, Y);
            label5.AutoSize = true;
            this.Controls.Add(label5);
            listLabel.Add(label5);


            RadioButton radio1 = new RadioButton();
            radio1.Text = "自动";
            radio1.Name = "rateTypeRad1";
            radio1.Checked = true;
            radio1.Location = new Point(X + difX + 30, Y);
            radio1.AutoSize = true;
            this.Controls.Add(radio1);
            listRad.Add(radio1);

            RadioButton radio2 = new RadioButton();
            radio2.Text = "手动";
            radio2.Name = "rateTypeRad2";
            radio2.Location = new Point(X + difX + 80, Y);
            radio2.AutoSize = true;
            this.Controls.Add(radio2);
            listRad.Add(radio2);

            Y += difY;

            Label label6 = new Label();
            label6.Text = "存款利率(年利率)";
            label6.Name = "rateLabel";
            label6.Location = new Point(X, Y);
            label6.AutoSize = true;
            this.Controls.Add(label6);
            listLabel.Add(label6);


            TextBox text2 = new TextBox();
            text2.Text = "";
            text2.Name = "rateText";
            text2.Location = new Point(X + difX + 45, Y - 5);
            text2.Size = new Size(text2.Size.Width - 40, text2.Size.Height);
            this.Controls.Add(text2);
            listText.Add(text2);


            Label label7 = new Label();
            label7.Text = "%";
            label7.Name = "rateLabe2";
            label7.Location = new Point(text2.Location.X + text2.Size.Width, Y);
            label7.AutoSize = true;
            this.Controls.Add(label7);
            listLabel.Add(label7);

            Y += difY;

            this.buttonCalculator.Location = new Point(X, Y);
            
            this.buttonReset.Location = new Point(X + 100, Y);

            Y += difY + 20;


            Label label8 = new Label();
            label8.Text = "存款利息";
            label8.Name = "interestLabel1";
            label8.Location = new Point(X, Y);
            label8.AutoSize = true;
            this.Controls.Add(label8);
            listLabel.Add(label8);


            TextBox text3 = new TextBox();
            text3.Text = "";
            text3.Name = "interestText1";
            text3.Location = new Point(X + difX, Y - 5);
            this.Controls.Add(text3);
            listText.Add(text3);



            Label label9 = new Label();
            label9.Text = "元";
            label9.Name = "interestLabel2";
            label9.Location = new Point(text3.Location.X + text3.Size.Width, Y);
            label9.AutoSize = true;
            this.Controls.Add(label9);
            listLabel.Add(label9);

            Y += difY;


            Label label10 = new Label();
            label10.Text = "本息合计";
            label10.Name = "interestLabel3";
            label10.Location = new Point(X, Y);
            label10.AutoSize = true;
            this.Controls.Add(label10);
            listLabel.Add(label10);


            TextBox text4 = new TextBox();
            text4.Text = "";
            text4.Name = "interestText2";
            text4.Location = new Point(X + difX, Y - 5);
            this.Controls.Add(text4);
            listText.Add(text4);



            Label label11 = new Label();
            label11.Text = "元";
            label11.Name = "interestLabel4";
            label11.Location = new Point(text3.Location.X + text3.Size.Width, Y);
            label11.AutoSize = true;
            this.Controls.Add(label11);
            listLabel.Add(label11);

            


        }




        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void typeComChanged(object sender, EventArgs e)
        {
            string type = this.Controls["typeCom"].Text;

            if (type.Equals("请选择存款种类"))
            {
                initType1(1);

            }
            if (type.Equals("活期"))
            {
                initType1(1);
                this.Controls.RemoveByKey("termLabel");
                this.Controls.RemoveByKey("termCom");

                int X = initX;
                int Y = this.Controls["typeLabel"].Location.Y;

                Y += difY;
                Y += difY;

                Label label1 = new Label();
                label1.Text = "起存日期";
                label1.Name = "dateFirstLabel1";
                label1.Location = new Point(X, Y + difY / 2);
                label1.AutoSize = true;
                this.Controls.Add(label1);
                listLabel.Add(label1);

                ComboBox combox1 = new ComboBox();
                combox1.Name = "dateFirstCom1";
                combox1.Items.Add("2018");
                combox1.Items.Add("2019");
                combox1.SelectedIndex = 0;
                combox1.Location = new Point(X + difX, Y - 5);
                combox1.Size = new Size(combox1.Size.Width - 70, combox1.Size.Height);
                combox1.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(combox1);
                listCom.Add(combox1);


                Label label2 = new Label();
                label2.Text = "年";
                label2.Name = "dateFirstLabel2";
                label2.Location = new Point(combox1.Location.X + combox1.Size.Width, Y);
                label2.AutoSize = true;
                this.Controls.Add(label2);
                listLabel.Add(label2);


                ComboBox combox2 = new ComboBox();
                combox2.Name = "dateFirstCom2";
                for (int i = 1; i <= 12; i++)
                {
                    combox2.Items.Add(Convert.ToString(i));
                }
                combox2.SelectedIndex = 0;
                combox2.Location = new Point(label2.Location.X + label2.Size.Width, Y - 5);
                combox2.Size = new Size(combox2.Size.Width - 70, combox2.Size.Height);
                combox2.DropDownStyle = ComboBoxStyle.DropDownList;
                combox2.SelectedIndexChanged += new System.EventHandler(dayMonth);
                this.Controls.Add(combox2);
                listCom.Add(combox2);


                Label label3 = new Label();
                label3.Text = "月";
                label3.Name = "dateFirstLabe3";
                label3.Location = new Point(combox2.Location.X + combox2.Size.Width, Y);
                label3.AutoSize = true;
                this.Controls.Add(label3);
                listLabel.Add(label3);

                Y += difY;

                ComboBox combox3 = new ComboBox();
                combox3.Name = "dateFirstCom3";
                for (int i = 1; i <= 31; i++)
                {
                    combox3.Items.Add(Convert.ToString(i));
                }
                combox3.SelectedIndex = 0;
                combox3.Location = new Point(X + difX, Y - 5);
                combox3.Size = new Size(combox3.Size.Width - 70, combox3.Size.Height);
                combox3.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(combox3);
                listCom.Add(combox3);


                Label label4 = new Label();
                label4.Text = "日";
                label4.Name = "dateFirstLabe4";
                label4.Location = new Point(combox3.Location.X + combox3.Size.Width, Y);
                label4.AutoSize = true;
                this.Controls.Add(label4);
                listLabel.Add(label4);

                Y += difY;


                Label label21 = new Label();
                label21.Text = "起存日期";
                label21.Name = "dateLastLabel1";
                label21.Location = new Point(X, Y + difY / 2);
                label21.AutoSize = true;
                this.Controls.Add(label21);
                listLabel.Add(label21);

                ComboBox combox21 = new ComboBox();
                combox21.Name = "dateLastCom1";
                combox21.Items.Add("2018");
                combox21.Items.Add("2019");
                combox21.SelectedIndex = 0;
                combox21.Location = new Point(X + difX, Y - 5);
                combox21.Size = new Size(combox21.Size.Width - 70, combox21.Size.Height);
                combox21.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(combox21);
                listCom.Add(combox21);


                Label label22 = new Label();
                label22.Text = "年";
                label22.Name = "dateLastLabel2";
                label22.Location = new Point(combox21.Location.X + combox21.Size.Width, Y);
                label22.AutoSize = true;
                this.Controls.Add(label22);
                listLabel.Add(label22);


                ComboBox combox22 = new ComboBox();
                combox22.Name = "dateLastCom2";
                for (int i = 1; i <= 12; i++)
                {
                    combox22.Items.Add(Convert.ToString(i));
                }
                combox22.SelectedIndex = 0;
                combox22.Location = new Point(label22.Location.X + label22.Size.Width, Y - 5);
                combox22.Size = new Size(combox22.Size.Width - 70, combox22.Size.Height);
                combox22.DropDownStyle = ComboBoxStyle.DropDownList;
                combox22.SelectedIndexChanged += new System.EventHandler(dayMonth);
                this.Controls.Add(combox22);
                listCom.Add(combox22);


                Label label23 = new Label();
                label23.Text = "月";
                label23.Name = "dateLastLabe3";
                label23.Location = new Point(combox22.Location.X + combox22.Size.Width, Y);
                label23.AutoSize = true;
                this.Controls.Add(label23);
                listLabel.Add(label23);

                Y += difY;

                ComboBox combox23 = new ComboBox();
                combox23.Name = "dateLastCom3";
                for (int i = 1; i <= 31; i++)
                {
                    combox23.Items.Add(Convert.ToString(i));
                }
                combox23.SelectedIndex = 0;
                combox23.Location = new Point(X + difX, Y - 5);
                combox23.Size = new Size(combox23.Size.Width - 70, combox23.Size.Height);
                combox23.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(combox23);
                listCom.Add(combox23);


                Label label24 = new Label();
                label24.Text = "日";
                label24.Name = "dateLastLabe4";
                label24.Location = new Point(combox23.Location.X + combox23.Size.Width, Y);
                label24.AutoSize = true;
                this.Controls.Add(label24);
                listLabel.Add(label24);


                int Y0 = Y - this.Controls["amountLabel"].Location.Y;
                Y0 -= difY;

                String now = "rateTypeLabel";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "rateTypeRad1";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "rateTypeRad2";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "rateLabel";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "rateText";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "rateLabe2";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "interestLabel1";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "interestText1";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "interestLabel2";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "interestLabel3";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "interestText2";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "interestLabel4";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "buttonCalculator";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);

                now = "buttonReset";
                this.Controls[now].Location = new Point(this.Controls[now].Location.X,
                    this.Controls[now].Location.Y + Y0);



            }
            else
            {

            }


            if (type.Equals("定活两便"))
            {
                initType1(2);
            }
            else
            {
                ;
            }



        }
        private void dayMonth(object sender, EventArgs e)
        {
            if (this.Controls.Find("dateFirstCom3", true) != null)
            {

                ComboBox c1 = (ComboBox)this.Controls["dateFirstCom2"];
                int month = Convert.ToInt32((string)c1.SelectedItem);
                ComboBox c2 = (ComboBox)this.Controls["dateFirstCom3"];
                int day = Convert.ToInt32((string)c2.SelectedItem);

                if (month == 1 || month == 3 || month == 5 || month == 7 || 
                    month == 8 || month == 10 || month == 12)
                {
                    c2.Items.Clear();
                    for(int i = 1; i <= 31; i++)
                    {
                        c2.Items.Add(Convert.ToString(i));
                    }
                    day = day > 31 ? 1 : day;
                    c2.SelectedItem = Convert.ToString(day);
                }
                else if(month == 2)
                {
                    c2.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                    {
                        c2.Items.Add(Convert.ToString(i));
                    }
                    day = day > 28 ? 1 : day;
                    c2.SelectedItem = Convert.ToString(day);
                }
                else
                {
                    c2.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        c2.Items.Add(Convert.ToString(i));
                    }
                    day = day > 30 ? 1 : day;
                    c2.SelectedItem = Convert.ToString(day);
                }
            }

            if (this.Controls.Find("dateLastCom3", true) != null)
            {

                ComboBox c1 = (ComboBox)this.Controls["dateLastCom2"];
                int month = Convert.ToInt32((string)c1.SelectedItem);
                ComboBox c2 = (ComboBox)this.Controls["dateLastCom3"];
                int day = Convert.ToInt32((string)c2.SelectedItem);

                if (month == 1 || month == 3 || month == 5 || month == 7 ||
                    month == 8 || month == 10 || month == 12)
                {
                    c2.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        c2.Items.Add(Convert.ToString(i));
                    }
                    day = day > 31 ? 1 : day;
                    c2.SelectedItem = Convert.ToString(day);
                }
                else if (month == 2)
                {
                    c2.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                    {
                        c2.Items.Add(Convert.ToString(i));
                    }
                    day = day > 28 ? 1 : day;
                    c2.SelectedItem = Convert.ToString(day);
                }
                else
                {
                    c2.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        c2.Items.Add(Convert.ToString(i));
                    }
                    day = day > 30 ? 1 : day;
                    c2.SelectedItem = Convert.ToString(day);
                }
            }



        }


    }


   
    



}
