using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }

        public static int modbatas = 1000000007;

                
        public static bool Valid(int a, int b)
        {
            if (a < 25) return false;
            if (a == 25) return b <= 23;
            return b == (a - 2);
        }
        public static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
        public static int pangkat(int no, int expo, int modbatas)
        { 
             if (expo < 2){
                 if (expo < 1)
                 {
                     return 1;
                 }
                 else
                     return no;
            }
            long kali = pangkat(no, expo >> 1, modbatas);
            kali = (kali*kali) % modbatas;
            if ((expo & 1) == 1)
            {
                return (int)((kali * no) % modbatas);
            }
            else
                return (int)(kali);
        }
        public static int hitungMatch(int c, int d, int modbatas)
        {
            if (c < d) Swap(ref c, ref d);

            if (c < 1 || d < 1) return 1;

            int[] baris = new int[d];
            for (int i = 0; i < d; baris[i++] = 1) { }

            for (int i = 2; i < d; ++i)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    baris[j] = (baris[j] + baris[j - 1]) % modbatas;
                }
            }

            --d;
            int jumlah = baris[d];
            for (int i = 0; i < c; ++i)
            {
                for (int j = d; j > 0; --j)
                {
                    baris[j] = (baris[j] + baris[j - 1]) % modbatas;
                }
                jumlah = (jumlah + baris[d]) % modbatas;
            }

            return jumlah;
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);

            int hasil = 0;

            if (a < b) Swap(ref a, ref b);
            if (!Valid(a, b))
            {
                hasil = 0;
            }
            else
            {
                if (a > 25)
                {
                    hasil = hitungMatch(24, 24, modbatas);
                    hasil = (int)((((long)hasil) * pangkat(2, b - 24, modbatas)) % modbatas);
                }
                else
                {
                    hasil = hitungMatch(a - 1, b, modbatas);
                    /*
                    MessageBox.Show(a.ToString());
                    MessageBox.Show(b.ToString());
                    MessageBox.Show(modbatas.ToString());
                    MessageBox.Show(hitungMatch(3,3,modbatas).ToString());*/
                }

            }
            TxtHasil.Text = hasil.ToString();
        }
    }
}
