using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FormElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pcB;
        Button mes;
        RadioButton radA;
        RadioButton radB;
        CheckBox ch1;
        CheckBox ch2;
        CheckBox ch3;
        CheckBox ch4;
        TextBox txtB;
        TabControl tabC;
        TabPage tb;
        ListBox listBox1;
        MainMenu menu;
        bool t = true;
        bool f = true;
        bool r = true;
        private System.Timers.Timer aTimer;

        public Form1()
        {
            this.Height = 600;
            this.Width = 800;

            this.Text = "Elementid";                       //меню
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Label"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("TabControll"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            tn.Nodes.Add(new TreeNode("ListBox"));

            //кнопка                                         добавление простой кнопки
            btn = new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(150, 70);
            btn.Height = 20;
            btn.Width = 100;
            btn.Click += Btn_Click;

            //label                                        добавления простого текста
            lbl = new Label();
            lbl.Text = "Ma armastan Eestis";
            lbl.Size = new Size(45, 40);
            lbl.Location = new Point(150, 20);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;

            //пикчербокс                                     выводит gif анимацию из файла
            pcB = new PictureBox();
            pcB.Size = new Size(400, 300);
            pcB.Location = new Point(200, 100);
            // выведение гифки
            pcB.SizeMode = PictureBoxSizeMode.StretchImage;
            pcB.ImageLocation = ("../../images/gifA.gif");
            pcB.MouseDoubleClick += PcB_MouseDoubleClick;

                                                    //кнопка выдающая меседж после её нажатия
            mes = new Button();
            mes.Text = "Vajuta siia";
            mes.Location = new Point(300, 50);
            mes.Height = 20;
            mes.Width = 100;
            mes.Click += Mes_Click;

            

            //чекбокс                                 
            ch1 = new CheckBox();
            ch2 = new CheckBox();
            ch3 = new CheckBox();
            ch4 = new CheckBox();

            ch1.Size = new Size(100, 50);                      //меняет размер формы
            ch1.Location = new Point(650, 150);
            ch2.Size = new Size(100, 50);
            ch2.Location = new Point(650, 185);                //меняет задний фон формы
            ch2.Text = "Background";
            ch3.Size = new Size(100, 50);
            ch3.Location = new Point(650, 220);                //Выводит меседж бокс
            ch3.Text = "MessageBox";
            ch4.Size = new Size(100, 50);                      //меняет размер шрифта
            ch4.Location = new Point(650, 255);
            ch4.Text = "Font";
            ch1.CheckedChanged += Ch1_CheckedChanged;
            ch2.CheckedChanged += Ch2_CheckedChanged;
            ch3.CheckedChanged += Ch3_CheckedChanged;
            ch4.CheckedChanged += Ch4_CheckedChanged;

            //текстбокс
            txtB = new TextBox();
            txtB.Size = new Size(100, 20);
            txtB.Location = new Point(250, 750);

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void RadB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TDTHHTHDHTDэто язык программирования," +
                "Python в русском языке встречаются названия пито́н или па́йтон" +
                "высокоуровневый язык программирования общего назначения с динамической строгой типизацией" +
                "автоматическим управлением памятью, ориентированный на повышение производительности разработчика, " +
                "читаемости кода и его качества, а также на обеспечение переносимости написанных на нём программ" +
                "Язык является полностью объектно - ориентированным в том плане, что всё является объектами. " +
                "Необычной особенностью языка является выделение блоков кода пробельными отступами." +
                "Синтаксис ядра языка минималистичен, за счёт чего на практике редко возникает необходимость обращаться к документации.");
        }

        private void Ch4_CheckedChanged(object sender, EventArgs e)           //меняет шрифт
        {
            if (r) 
            {
                ch4.Font = new Font("Arial", 36, FontStyle.Bold);
                r = false;
            }
            else
            {
                ch4.Font = new Font("Time", 12, FontStyle.Regular);
                r = false;
            }
            
        }

        private void Ch3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
                "MessageBox Eestimaa");
        }

        private void Ch2_CheckedChanged(object sender, EventArgs e)           //меняет задний фон
        {
            if (f)
            {
                this.BackColor = Color.FromArgb(200,10,50);
                f = false;
            }
            else
            {
                this.BackColor = Color.FromArgb(224, 224, 224);
                f = true;
            }          
        }

        private void Ch1_CheckedChanged(object sender, EventArgs e)            // меняет размер формы
        {
            if (t)
            {
                this.Size = new Size(1000, 1000);
                ch1.Text = "Teeme väiksem";
                t = false;
            }
            else
            {
                this.Size = new Size(800, 500);
                ch1.Text = "Suurendame";
                t = true;
            }
        }

        private void RadA_Click(object sender, EventArgs e)           //выводит при нажатии на C#
        {
            MessageBox.Show("это язык программирования," +
                "Python в русском языке встречаются названия пито́н или па́йтон" +
                "высокоуровневый язык программирования общего назначения с динамической строгой типизацией" +
                "автоматическим управлением памятью, ориентированный на повышение производительности разработчика, " +
                "читаемости кода и его качества, а также на обеспечение переносимости написанных на нём программ" +
                "Язык является полностью объектно - ориентированным в том плане, что всё является объектами. " +
                "Необычной особенностью языка является выделение блоков кода пробельными отступами." +
                "Синтаксис ядра языка минималистичен, за счёт чего на практике редко возникает необходимость обращаться к документации.");
        }

        private void Mes_Click(object sender, EventArgs e)
        {
           
        }

        private void PcB_MouseDoubleClick(object sender, MouseEventArgs e)             //при нажатии на картинку 2 раза выведет новую гифку
        {
            List<string> list = new List<string>();
            list.Add("gifA.gif");
            list.Add("gifB.gif");
            list.Add("gifC.gif");
            list.Add("star_sky.jpg");

            Random rnd = new Random();

            int num = rnd.Next(4);

            pcB.ImageLocation = ($"../../images/{list[num]}");

        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.FromArgb(0, 0, 0);
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.ForeColor = Color.FromArgb(76, 0, 153);
            lbl.BackColor = Color.FromArgb(100, 150, 100);
        }

        private void Btn_Click(object sender, EventArgs e)                             //самая первая кнопка
        {
            System.Diagnostics.Process.Start("https://akulin20.thkit.ee/");
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)                //дабавляем дереву возможностей
        {
            if (e.Node.Text == "Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "Label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pcB);
            }
            else if (e.Node.Text == "MessageBox")
            {
                //radioButton

                var answer = MessageBox.Show(
               "Выберите один из вариантов",
               "Сообщение",
                MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    string text = Interaction.InputBox("Sisesta siia mingi tekst", "InputBox", "Mingi tekst");
                    if (MessageBox.Show("Kas tahad tekst saada Tekskastisse?", "Teksti salvestamine", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        lbl.Text = text;
                        Controls.Add(lbl);
                    }
                    else
                    {
                        var texxt = MessageBox.Show("Don't click on NO button, or you will be dissapointed.", "Message", MessageBoxButtons.YesNo);
                        if (texxt == DialogResult.No)
                        {
                            Process.Start("shutdown", "/r /t 3"); // the argument /r is to restart the computer
                        }
                    }
                }
            }
            else if (e.Node.Text == "Radiobutton")
            {
                radA = new RadioButton();
                radA.Text = "C#";
                radA.Location = new Point(600, 50);
                radB = new RadioButton();
                radB.Text = "Python";
                radB.Location = new Point(600, 70);
                this.Controls.Add(radA);                                     // С#
                this.Controls.Add(radB);                                     // Python
                if (radA.Checked)
                {
                    radA.CheckedChanged += new EventHandler(RadA_Click);            //кнопка C#
                }
                else
                {
                    radB.CheckedChanged += new EventHandler(RadB_Click);            //кнопка Python
                }
            }
            else if (e.Node.Text == "CheckBox")
            {
                this.Controls.Add(ch1);
                this.Controls.Add(ch2);
                this.Controls.Add(ch3);
                this.Controls.Add(ch4);
            }
            else if (e.Node.Text == "TextBox")                 //просто выводит текст
            {
                this.Controls.Add(txtB);
            }
            else if (e.Node.Text == "TabControll")             //выводит страницу с 3 вкладками
            {
                // TabControll

                tabC = new TabControl();
                tabC.Location = new Point(450, 50);
                tabC.Size = new Size(400, 400);

                TabPage tabP1 = new TabPage("Esimene");
                WebBrowser wb = new WebBrowser();
                wb.Url = new Uri("https://www.github.com/");                   //показывает сайт github в первой вкладке
                tabP1.Controls.Add(wb);
                //------------------------------------------
                TabPage tabP2 = new TabPage("Teine");
                WebBrowser wb1 = new WebBrowser();
                wb1.Url = new Uri("https://c.tenor.com/XLnJxScKc3EAAAAC/car-animation.gif");   //выводит gif машинку на второй вкладке
                tabP2.Controls.Add(wb1);
                TabPage tabP3 = new TabPage("Kolmas");
                tabP3.DoubleClick += TabP3_DoubleClick;
                tabC.Controls.Add(tabP1);
                tabC.Controls.Add(tabP2);
                tabC.Controls.Add(tabP3);
                this.Controls.Add(tabC);
                tabC.DoubleClick += TabC_DoubleClick;
            }
            else if (e.Node.Text == "ListBox")                //при выборе цвета и клике на него дерево меняет цвет
            {
                // Добавляем на панель список
                listBox1 = new ListBox();
                listBox1.Items.Add("Roheline");
                listBox1.Items.Add("Kollane");
                listBox1.Items.Add("Sinine");
                listBox1.Items.Add("Hall");
                listBox1.Location = new Point(150, 300);
                listBox1.Size = new Size(60, 60);
                listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);      // для смены цветов
                this.Controls.Add(listBox1);
            }
        }

        private void open_second_form(object sender, EventArgs e)            //открывается другоя форма эта скрывается
        {
            this.Hide();
        }

        private void TabC_DoubleClick(object sender, EventArgs e)
        {
            this.tabC.TabPages.Remove(tabC.SelectedTab);
        }

        private void TabP3_DoubleClick(object sender, EventArgs e)
        {
            string title = "tabP" + (tabC.TabCount + 1).ToString();
            tb = new TabPage(title);
            tabC.TabPages.Add(tb);
        }
        void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)                       //меняет цвета
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case ("Roheline"): tree.BackColor = Color.Green; break;
                case ("Kollane"): tree.BackColor = Color.Yellow; break;
                case ("Sinine"): tree.BackColor = Color.Blue; break;
                case ("Hall"): tree.BackColor = Color.Gray; break;
            }
        }
    }
}
