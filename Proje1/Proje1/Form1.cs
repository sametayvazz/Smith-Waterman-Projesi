using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int match = 1, mismatch = -1, gap = -2;
        string[] dizin1;
        string[] dizin2;
        int dizib, dizib2;

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                dizin1 = File.ReadAllLines(@"C:\Users\samet\OneDrive\masaüstü\seq1.txt");
                textDizin1.Text = dizin1[1];
                dizib = Convert.ToInt32(dizin1[0]);

                dizin2 = File.ReadAllLines(@"C:\Users\samet\OneDrive\masaüstü\seq2.txt");
                textDizin2.Text = dizin2[1];
                dizib2 = Convert.ToInt32(dizin2[0]);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Dosya bulunamadý");

            }
            textMatch.Text = match.ToString();
            textMismatch.Text = mismatch.ToString();
            textGap.Text = gap.ToString();
        }

        private double Runtime;
        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sure = new Stopwatch();
            sure.Start();

            match = Convert.ToInt32(textMatch.Text);
            mismatch = Convert.ToInt32(textMismatch.Text);
            gap = Convert.ToInt32(textGap.Text);

            textMatch.Text = match.ToString();
            textMismatch.Text = mismatch.ToString();
            textGap.Text = gap.ToString();
            textSon1.Clear();
            textSon2.Clear();
            textSkor.Clear();

            string seq1 = textDizin1.Text;
            string seq2 = textDizin2.Text;
            string[] dizi1 = new string[dizib];
            string[] dizi2 = new string[dizib2];
            DataTable tablo = new DataTable();

            for (int i = 0; i < seq1.Length; i++)  // 1.girdiyi diziye
            {
                dizi1[i] = seq1[i].ToString();
            }
            for (int i = 0; i < seq2.Length; i++) // 2.girdiyi diziye
            {
                dizi2[i] = seq2[i].ToString();
            }

            string bos = " ";
            tablo.Columns.Add(bos);
            tablo.Columns.Add();
            tablo.Rows.Add();
            tablo.Rows.Add();

            dataGridView1.DataSource = tablo;

            for (int i = 0; i < dizi1.Length; i++)//yana kolon oluþtur
            {
                tablo.Columns.Add();
            }

            for (int i = 0; i < dizi2.Length; i++)//aþaðý doðru oluþtur 
            {
                DataRow satir = tablo.NewRow();
                satir[bos] = dizi2[i];              //aþaðý doðru 2.girdiyi yazma
                tablo.Rows.Add(satir);
            }
            for (int i = 0; i < dizi1.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i + 2].Value = dizi1[i];  //yana doðru 1.girdiyi yazma
            }
            dataGridView1.Rows[1].Cells[1].Value = 0; // 0 

            FormulleYerlestir(dizi1, dizi2);
            TabloBoya(dizi1, dizi2);
            sure.Stop();
            Runtime = sure.Elapsed.Milliseconds;
            label9.Text = Runtime.ToString() + " Milisaniye";
        }
        public int DizileriKarsilastir(int i, int j) //formül match mismatch hesabý
        {
            int match = Convert.ToInt32(textMatch.Text);
            int mismatch = Convert.ToInt32(textMismatch.Text);
            int sonuc;

            if (String.Compare(dataGridView1.Rows[0].Cells[j + 1].Value.ToString(), dataGridView1.Rows[i + 1].Cells[0].Value.ToString()) == 0)
            {
                sonuc = match;
            }
            else
            {
                sonuc = mismatch;
            }
            return sonuc;
        }
        void FormulleYerlestir(string[] dizi1, string[] dizi2)
        {

            int gap = Convert.ToInt32(textGap.Text);
            int formul1 = 0, formul2 = 0, formul3 = 0;
            for (int j = 1; j < dizi1.Length + 2; j++)
            {
                for (int i = 1; i < dizi2.Length + 2; i++)
                {

                    if (i == 1 && j == 1)
                    {
                        //0 noktasý
                    }
                    else if (i - 1 >= 1 && j - 1 >= 1)  //i ve j 1'den büyük olma durumu
                    {
                        int karsilastirma = DizileriKarsilastir(i - 1, j - 1);
                        int a = Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[j - 1].Value); 
                        formul1 = karsilastirma + a;
                        int b = Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[j].Value); 
                        formul2 = gap + b;
                        int c = Convert.ToInt32(dataGridView1.Rows[i].Cells[j - 1].Value);                     
                        formul3 = gap + c;
                    }
                    else if (i - 1 >= 1 && j >= 1) //sadece i-1 1'den büyük olma durumu    aþaðý doðru gapýn katlarý
                    {
                        int b = Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[j].Value);
                        formul2 = gap + b;
                        formul1 = formul2;
                        formul3 = formul2;

                    }
                    else if (i >= 1 && j - 1 >= 1) //sadece j-1 1'den büyük olma durumu     yana doðru gapýn katlarý
                    {
                        int c = Convert.ToInt32(dataGridView1.Rows[i].Cells[j - 1].Value);
                        formul3 = gap + c;
                        formul1 = formul3;
                        formul2 = formul3;
                    }
                    int sonuc = FormulKarsilastir(formul1, formul2, formul3);

                    if (sonuc < 0)
                    {
                        sonuc = 0;
                    }
                    dataGridView1.Rows[i].Cells[j].Value = sonuc;

                }
            }
        }

        public int FormulKarsilastir(int f1, int f2, int f3) // 3 förmülü karþýlaþtýrma
        {
            int buyukFormul = f1; //gecici atama

            if (f1 > f2 && f1 > f3)
            {
                buyukFormul = f1;
            }
            else if (f2 > f1 && f2 > f3)
            {
                buyukFormul = f2;
            }
            else if (f3 > f1 && f3 > f2)
            {
                buyukFormul = f3;
            }
            return buyukFormul;

        }
        public int BuyukKomsuBul(int k1, int k2, int k3)
        {
            int BuyukKomsu = k1; //gecici

            if (k1 > k2 && k1 > k3)
            {
                BuyukKomsu = k1;
            }
            else if (k2 > k1 && k2 > k3)
            {
                BuyukKomsu = k2;
            }
            else if (k3 > k2 && k3 > k1)
            {
                BuyukKomsu = k3;
            }
            
            return BuyukKomsu;
        }
        void TabloBoya(string[] bdizin, string[] idizin)
        {

            int i = dizib + 1;
            int j = dizib2 + 1;
            int k1, k2, k3;

            while (i > 1 && j > 1)
            {
                k1 = Convert.ToInt32(dataGridView1.Rows[j].Cells[i - 1].Value);
                k2 = Convert.ToInt32(dataGridView1.Rows[j - 1].Cells[i - 1].Value);
                k3 = Convert.ToInt32(dataGridView1.Rows[j - 1].Cells[i].Value);
                   
                int enBuyukKomsu = BuyukKomsuBul(k1, k2, k3);
                if (enBuyukKomsu == k2)
                {

                    j = j - 1;
                    i = i - 1;
                    if (enBuyukKomsu != 0)
                    {
                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Cyan;
                    }
                    else
                        break;
                   
                }

                else if (enBuyukKomsu == k1)
                {
                    i = i - 1;
                    if (enBuyukKomsu != 0)
                    {

                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Cyan;
                    }
                    else
                        break;
                }
                else if (enBuyukKomsu == k3)
                {
                    j = j - 1;
                    if (enBuyukKomsu != 0)
                    {

                        dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Cyan;
                    }
                    else
                        break;
                }                
            }
        }
    }
}