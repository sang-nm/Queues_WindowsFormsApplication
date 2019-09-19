using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Queues_WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt = new Button[Q.arr.Length];
        }
        QueuesClass Q = new QueuesClass();
        Button[] bt;

        private void btInsert_Click(object sender, EventArgs e)
        {
            string[] arrTxt = textBoxNum.Text.Split(';');
            
            foreach (var item in arrTxt)
            {
                Q.insert(Convert.ToInt32(item));
            }
            
            buttonshow();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Q.delete();
            buttonshow();
        }

        private void clearBT()
        {
            for (int i = 0; i < Q.arr.Length; i++)
            {
                if (bt[i] != null)
                {
                    this.Controls.Remove(bt[i]);
                    bt[i].Dispose();
                }
            }
        }
        int z = 0;
        private void buttonshow()
        {
            clearBT();
            int[] Q_Arr;
            Q.display(out Q_Arr);
            for (int i = 0; i < Q.arr.Length; i++)
            {
                bt[i] = new Button();
                bt[i].Location = new Point(100 + i * 100, 150);
                bt[i].Name = "Button" + Q_Arr[i];
                bt[i].Size = new Size(50, 50);
                if (Q_Arr[i] == 0)
                {
                    bt[i].Text = "";
                }
                else
                {
                    bt[i].Text = Convert.ToString(Q_Arr[i]);
                }
                
                //bt[i].UseVisualStyleBackColor = true;
                this.Controls.Add(bt[i]);
            }
            z++;
        }
    }
}
