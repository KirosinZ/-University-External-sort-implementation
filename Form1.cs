using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRIALG_EXTERNAL_SORT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Comparisons.Rows.Add(4);
            Comparisons.Rows[0].Cells[0].Value = "1000";
            Comparisons.Rows[1].Cells[0].Value = "5000";
            Comparisons.Rows[2].Cells[0].Value = "10000";
            Comparisons.Rows[3].Cells[0].Value = "50000";

            Iterations.Rows.Add(4);
            Iterations.Rows[0].Cells[0].Value = "1000";
            Iterations.Rows[1].Cells[0].Value = "5000";
            Iterations.Rows[2].Cells[0].Value = "10000";
            Iterations.Rows[3].Cells[0].Value = "50000";

            ElapsedTime.Rows.Add(4);
            ElapsedTime.Rows[0].Cells[0].Value = "1000";
            ElapsedTime.Rows[1].Cells[0].Value = "5000";
            ElapsedTime.Rows[2].Cells[0].Value = "10000";
            ElapsedTime.Rows[3].Cells[0].Value = "50000";

            GenerateFilesStrip.Click += (ob, ev) =>
            {
                GenerateRandomFile(1000, -1500, 1500);
                GenerateRandomFile(5000, -7500, 7500);
                GenerateRandomFile(10000, -15000, 15000);
                GenerateRandomFile(50000, -75000, 75000);

                GenerateDescendingFile(1000);
                GenerateDescendingFile(5000);
                GenerateDescendingFile(10000);
                GenerateDescendingFile(50000);
            };

            TestSortsStrip.Click += (ob, ev) =>
            {
                ApplyChanges("random numbers 1000.txt", 0, 1);
                ApplyChanges("random numbers 5000.txt", 1, 1);
                ApplyChanges("random numbers 10000.txt", 2, 1);
                ApplyChanges("random numbers 50000.txt", 3, 1);

                ApplyChanges("descending numbers 1000.txt", 0, 2);
                ApplyChanges("descending numbers 5000.txt", 1, 2);
                ApplyChanges("descending numbers 10000.txt", 2, 2);
                ApplyChanges("descending numbers 50000.txt", 3, 2);
            };
        }

        void ApplyChanges(string filename, int row, int col)
        {
            int[] ret = SortFile(filename);
            Comparisons.Rows[row].Cells[col].Value = ret[0];
            Iterations.Rows[row].Cells[col].Value = ret[1];
            ElapsedTime.Rows[row].Cells[col].Value = ret[2].ToString() + "мс";
        }

        int[] SortFile(string filename)
        {
            int[] res = new int[3]
            {
                0, 0, 0
            };
            var start = DateTime.Now;
            StreamReader sr, srA, srB;
            StreamWriter sw, swA, swB;
            for (int i = 0; ;i++)
            {
                sr = new StreamReader(filename);
                swA = new StreamWriter("A.tmp", false);
                swB = new StreamWriter("B.tmp", false);
                int count = 0;
                for (int j = 0; !sr.EndOfStream; j++, count++)
                {
                    (j / (1 << i) % 2 == 0 ? swA : swB).WriteLine(Convert.ToInt32(sr.ReadLine()));
                }
                sr.Close();
                swA.Close();
                swB.Close();
                res[1]++;

                if (count <= (1 << i))
                {
                    res[2] = (int)(DateTime.Now - start).TotalMilliseconds;
                    File.Delete("A.tmp");
                    File.Delete("B.tmp");
                    return res;
                }

                sw = new StreamWriter(filename, false);
                srA = new StreamReader("A.tmp");
                srB = new StreamReader("B.tmp");

                int countleft = 0;
                int countright = 0;
                string left = srA.ReadLine();
                string right = srB.ReadLine();

                for (;left != null && right != null;)
                {
                    res[0]++;
                    int firstorder = (countleft / (1 << i)).CompareTo(countright / (1 << i));
                    switch (firstorder)
                    {
                        case -1:
                        {
                            sw.WriteLine(left);
                            left = srA.ReadLine();
                            countleft++;
                            break;
                        }
                        case 1:
                        {
                            sw.WriteLine(right);
                            right = srB.ReadLine();
                            countright++;
                            break;
                        }
                        case 0:
                        {
                            if (left == null || right == null) break;
                            int secondorder = Convert.ToInt32(left).CompareTo(Convert.ToInt32(right));
                            switch (secondorder)
                            {
                                case -1:
                                {
                                    sw.WriteLine(left);
                                    left = srA.ReadLine();
                                    countleft++;
                                    break;
                                }
                                case 1:
                                {
                                    sw.WriteLine(right);
                                    right = srB.ReadLine();
                                    countright++;
                                    break;
                                }
                                case 0:
                                {
                                    sw.WriteLine(left);
                                    sw.WriteLine(right);
                                    left = srA.ReadLine();
                                    right = srB.ReadLine();
                                    countleft++;
                                    countright++;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                for (; left != null;)
                {
                    sw.WriteLine(left);
                    left = srA.ReadLine();
                }
                for (; right != null;)
                {
                    sw.WriteLine(right);
                    right = srB.ReadLine();
                }

                sw.Close();
                srA.Close();
                srB.Close();
                res[1]++;
            }
        }

        void GenerateRandomFile(int size, int lowerbound, int upperbound)
        {
            StreamWriter sw = new StreamWriter("random numbers " + size.ToString() + ".txt");
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                sw.WriteLine(rand.Next(lowerbound, upperbound + 1));
            }
            sw.Close();
        }

        void GenerateDescendingFile(int size)
        {
            StreamWriter sw = new StreamWriter("descending numbers " + size.ToString() + ".txt");

            for (int i = size; i>0;i--)
            {
                sw.WriteLine(i);
            }
            sw.Close();
        }
    }
}
