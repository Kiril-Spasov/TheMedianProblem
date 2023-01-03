using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMedianProblem
{
    public partial class FormMedian : Form
    {
        public FormMedian()
        {
            InitializeComponent();
        }


        Marks marks = new Marks(1001);

        private void FormMedian_Load(object sender, EventArgs e)
        {
            LoadData();
            Display(marks);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        { 
            marks.ShellSort();
            DisplaySorted(marks);
            MessageBox.Show("The median is: " + marks.FindMedian());
        }

        private void LoadData()
        {
            string path = Application.StartupPath + @"\median.txt";
            StreamReader streamReader = new StreamReader(path);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    marks.Insert(Convert.ToInt32(line));
                }
            }
        }

        private void Display(Marks m)
        {
            for (int i = 1; i <= m.NumElements; i++)
            {
                LstOriginal.Items.Add(m.List[i]);
            }
        }

        private void DisplaySorted(Marks m)
        {
            for (int i = 1; i <= m.NumElements; i++)
            {
                LstSorted.Items.Add(m.SortedList[i]);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
