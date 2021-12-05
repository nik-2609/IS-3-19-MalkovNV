using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_3_19_MalkovNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public abstract class Components <T>
        {
            private int cost;
            private int yearOfRelease;
            private T article;

            public int Cost { get { return cost; } set { cost = value; } }
            public int YearOfRelease { get { return yearOfRelease; } set { yearOfRelease = value; } }
            public T Article { get { return article; } set { article = value; } }

            public Components(int cost,int yearOfRelease,T article)
            {
                Cost = cost;
                YearOfRelease = yearOfRelease;
                Article = article;
            }

            public virtual void Display()
            {
                MessageBox.Show($"Цена: {Cost}\nГод выпуска {YearOfRelease}\nАртикль {Article}");
            }
        }

        CentralProcessor<string> cpu1 = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            cpu1 = new CentralProcessor<string>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32( textBox6.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cpu1 != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(cpu1.Cost);
                listBox1.Items.Add(cpu1.YearOfRelease);
                listBox1.Items.Add(cpu1.Article);
                listBox1.Items.Add(cpu1.Frequency);
                listBox1.Items.Add(cpu1.Cores);
                listBox1.Items.Add(cpu1.Threads);
            } 
        }

        public class CentralProcessor <T> : Components <T>
        {
            private double frequency;
            private int cores;
            private int threads;

            public double Frequency { get { return frequency; } set { frequency = value; } }
            public int Cores { get { return cores; } set { cores = value; } }
            public int Threads { get { return threads; } set { threads = value; } }

            public CentralProcessor(int cost, int yearOfRelease, T article, double frequency, int cores, int threads) : base( cost, yearOfRelease, article)
            {
                Frequency = frequency;
                Cores = cores;
                Threads = threads;
            }

            public override void Display()
            {
                MessageBox.Show($"Цена: {Cost}\nГод выпуска {YearOfRelease}\nАртикль {Article}\nЧастота: {frequency}\nЯдра {cores}\nПотоки {threads}");
            }
        }

        public class VideoCard<T> : Components<T>
        {
            private double frequency;
            private double efficiency;
            private int memory;

            public double Frequency { get { return frequency; } set { frequency = value; } }
            public double Efficiency { get { return efficiency; } set { efficiency = value; } }
            public int Memory { get { return memory; } set { memory = value; } }


            public VideoCard(int cost, int yearOfRelease, T article, double frequency, double efficiency, int memory) : base(cost, yearOfRelease, article)
            {
                Frequency = frequency;
                Efficiency = efficiency;
                Memory = memory;
            }

            public override void Display()
            {
                MessageBox.Show($"Цена: {Cost}\nГод выпуска {YearOfRelease}\nАртикль {Article}\nЧастота: {frequency}\nЭффективность {efficiency}\nОбъём памяти {memory}");
            }
        }

        VideoCard<string> gpu1 = null;

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }
            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            gpu1 = new VideoCard<string>(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9.Text, Convert.ToDouble(textBox10.Text), Convert.ToDouble(textBox11.Text), Convert.ToInt32(textBox12.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gpu1 != null) 
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(gpu1.Cost);
                listBox2.Items.Add(gpu1.YearOfRelease);
                listBox2.Items.Add(gpu1.Article);
                listBox2.Items.Add(gpu1.Frequency);
                listBox2.Items.Add(gpu1.Efficiency);
                listBox2.Items.Add(gpu1.Memory);
            }
        }
    }
}
