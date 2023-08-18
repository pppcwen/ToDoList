using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace f74114087_practice_7_2
{
    public partial class Form1 : Form
    {

        Form2 f2 = new Form2();
        finish f3 = new finish();

        string file = "new";
        string filename = "未命名*";

        bool showcomplete = true;
        string notcomplete, all;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            saveFileDialog1.DefaultExt = ".todo";
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            file = "new";
            textBox1.Text = "";
            hide.Text = "";
            filename = "未命名*";
            this.Text = filename + "-代辦清單";

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
            if (f2.add != "")
            {
                textBox1.Text +=" [ ] "+f2.add + "\r\n";
                hide.Text+= " [ ] " + f2.add + "\r\n";

            }
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                hide.Font = fontDialog1.Font;
                findresult.Font= fontDialog1.Font;
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = "open";
                filename = openFileDialog1.FileName;
                this.Text = filename + "-代辦清單";
                StreamReader sr = new StreamReader(filename);

                string data,showdata;
                while (true)
                {
                    data = sr.ReadLine();
                    if (data == null) break;

                    if (data[0] == '+')
                    {
                        showdata = " [√] " + data.Substring(1, data.Length - 1);
                    }
                    else
                    {
                        showdata = " [ ] " + data.Substring(1, data.Length - 1);
                        hide.Text+= showdata + "\r\n";
                    }
                    textBox1.Text += showdata +"\r\n";

                }
                sr.Close();

                

            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file == "open")
            {
                FileInfo finfo = new FileInfo(filename);
                StreamWriter sw = finfo.CreateText();
                for (int i = 0; i < textBox1.Lines.Length - 1; i++)
                {
                    if (textBox1.Lines[i].Contains("√"))
                    {
                        sw.WriteLine("+" + textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5));
                    }
                    else
                    {
                        sw.WriteLine("-" + textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5));
                    }
                }
                sw.Flush();
                sw.Close();

            }
            else if (file == "new")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                    FileInfo finfo = new FileInfo(filename);
                    StreamWriter sw = finfo.CreateText();
                    for (int i = 0; i < textBox1.Lines.Length - 1; i++)
                    {
                        if (textBox1.Lines[i].Contains("√"))
                        {
                            sw.WriteLine("+" + textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5));
                        }
                        else
                        {
                            sw.WriteLine("-" + textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5));
                        }
                    }
                    sw.Flush();
                    sw.Close();
                }

            }
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                FileInfo finfo = new FileInfo(filename);
                StreamWriter sw = finfo.CreateText();
                for(int i = 0; i < textBox1.Lines.Length-1; i++)
                {
                    if (textBox1.Lines.Contains("√"))
                    {
                        sw.WriteLine("+" + textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5));
                    }
                    else
                    {
                        sw.WriteLine("-" + textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5));
                    }
                }
                
                sw.Flush();
                sw.Close();
            }
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            hide.Visible = true;
            showcomplete = false;
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            hide.Visible = false;
            showcomplete = true;

        }

        private void 新增事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void 完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
            if (f3.check != "")
            {
                List<int> l = new List<int>();
                string change = "";

                
                for (int i = 0; i < textBox1.Lines.Length-1; i++)
                {
                    if  (textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5) == f3.check)
                    {
                        l.Add(i);
                       
                    }
                }



                for (int i = 0; i < textBox1.Lines.Length-1; i++)
                {
                    if (!l.Contains(i))
                    {
                        change += textBox1.Lines[i]+"\r\n";
                    }
                }
                textBox1.Text = change;


                l = new List<int>();
                change = "";


                for (int i = 0; i < hide.Lines.Length - 1; i++)
                {
                    if (hide.Lines[i].Substring(5, hide.Lines[i].Length - 5) == f3.check)
                    {
                        l.Add(i);

                    }
                }



                for (int i = 0; i < hide.Lines.Length - 1; i++)
                {
                    if (!l.Contains(i))
                    {
                        change += hide.Lines[i] + "\r\n";
                    }
                }
                hide.Text = change;


            }

        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();

            string fr = "";
            if (f3.check != "")
            {
                for (int i = 0; i < textBox1.Lines.Length; i++)
                {
                    if (textBox1.Lines[i].Contains(f3.check))
                    {
                        fr += textBox1.Lines[i] + "\r\n";
                    }
                }
                findresult.Text = fr;

                if (showcomplete)
                {
                    textBox1.Visible = false;
                }
                else
                {
                    hide.Visible = false;
                }

                findresult.Visible = true;
                檔案ToolStripMenuItem.Enabled = false;
                檢視ToolStripMenuItem.Enabled = false;
                編輯ToolStripMenuItem.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                CF.Visible = true;
           

            }
        }

        private void CF_Click(object sender, EventArgs e)
        {
            findresult . Visible = false;
            if (showcomplete)
            {
                textBox1.Visible = true;
            }
            else
            {
                hide.Visible = true;
            }

            
            檔案ToolStripMenuItem.Enabled = true;
            檢視ToolStripMenuItem.Enabled = true;
            編輯ToolStripMenuItem.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            CF.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
            if (f3.check != "")
            {
                List<int> l = new List<int>();
                string change = "";


                for (int i = 0; i < textBox1.Lines.Length - 1; i++)
                {
                    if (textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5) == f3.check)
                    {
                        l.Add(i);

                    }
                }



                for (int i = 0; i < textBox1.Lines.Length - 1; i++)
                {
                    if (!l.Contains(i))
                    {
                        change += textBox1.Lines[i] + "\r\n";
                    }
                    else
                    {
                        change+= " [√] "+ textBox1.Lines[i].Substring(5, textBox1.Lines[i].Length - 5) + "\r\n";
                    }
                }
                textBox1.Text = change;


                l = new List<int>();
                change = "";


                for (int i = 0; i < hide.Lines.Length - 1; i++)
                {
                    if (hide.Lines[i].Substring(5, hide.Lines[i].Length - 5) == f3.check)
                    {
                        l.Add(i);

                    }
                }



                for (int i = 0; i < hide.Lines.Length - 1; i++)
                {
                    if (!l.Contains(i))
                    {
                        change += hide.Lines[i] + "\r\n";
                    }
                }
                hide.Text = change;

            }

        }
    }
}
