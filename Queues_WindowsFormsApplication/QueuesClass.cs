using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queues_WindowsFormsApplication
{
    class QueuesClass : Form
    {
        public static int Max = 5;
        public int[] arr = new int[Max];
        public int Front, Rear;
        public QueuesClass()
        {
            Front = Rear = -1;
        }

        public void insert(int item)
        {
            if ((Front == 0 && Rear == Max - 1) || (Front == Rear + 1))
            {
                MessageBox.Show("Full slot");
            }
            if (Front == -1)
            {
                Front = 0;
                Rear = 0;
                arr[Rear] = item;
            }
            else
            {
                if (!arr.Contains(item))
                {
                    if (Rear == Max - 1)
                    {
                        Rear = 0;
                    }
                    else
                    {
                        Rear = Rear + 1;
                    }
                    arr[Rear] = item;
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
        }
        
        public void delete()
        {
            if (Front == -1)
            {

                MessageBox.Show("Empty slot");
                return;
            }
            MessageBox.Show("\n The element deleted from the queue is: " + arr[Front] + "\n");
            if (Front == Rear)
            {
                Front = -1;
                Rear = -1;
            }
            else
            {
                if (Front == Max - 1)
                {
                    Front = 0;
                }
                else
                {
                    Front = Front + 1;
                }
            }
        }

        public void display(out int[] arrQ)
        {
            
            int Front_pos = Front;
            int Rear_pos = Rear;
            arrQ = new int[5];
            
            if (Front == -1)
            {
                MessageBox.Show("Queue is empty");
            }
            else if (Front_pos <= Rear_pos)
            {
                while (Front_pos <= Rear_pos)
                {
                    arrQ[Front_pos] = arr[Front_pos];
                    Front_pos++;
                }
            }
            else
            {
                while (Front_pos <= Max - 1)
                {
                    arrQ[Front_pos] = arr[Front_pos];
                    Front_pos++;
                }
                Front_pos = 0;
                while (Front_pos <= Rear)
                {
                    arrQ[Front_pos] = arr[Front_pos];
                    Front_pos++;
                }
            }
        }
    }
}
