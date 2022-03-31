using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections;
using System.IO;

namespace JSON_cars
{
    public partial class Form1 : Form
    {
        private ArrayList cary = new ArrayList();
        int current;

        public Form1()
        {
            InitializeComponent();

             
        }

        public void add()
        {
            string N;
            N = Name_textBox.Text;

            int M;
            M = Int32.Parse(MPG_textBox.Text);

            int H;
            H = Int32.Parse(MPG_textBox.Text);

        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            add();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader infile = File.OpenText("car.json");
            while (infile.Peek() != -1)
            {
                string cString = infile.ReadLine();
                Car c = JsonSerializer.Deserialize<Car>(cString);
                cary.Add(c);
            }
            infile.Close();
            show();
        }

        public void show()
        {
            if (current>=0&&current<cary.Count)
            {
            Car c = (Car)cary[current];
            Name_textBox.Text = c.Name;
            MPG_textBox.Text = c.MPG;
            HP_textBox.Text = c.HP;
            }
            
        }

        public void save()
        {
            var C = new Car
            {
                Name = Name_textBox.Text,
                MPG = MPG_textBox.Text,
                HP = HP_textBox.Text,
            };

            cary.Add(C);
            StreamWriter outfile = File.CreateText("car.json");
            foreach (var item in cary)
            {
                outfile.WriteLine(JsonSerializer.Serialize(item));
                
            }
            outfile.Close();
        }

        //Next
        private void button2_Click(object sender, EventArgs e)
        {

            current = current + 1;
            show();
        }

        //back
        private void back_button_Click(object sender, EventArgs e)
        {
            current = current-1;
            show();
        }

        //last
        private void Last_button_Click(object sender, EventArgs e)
        {
            current = cary.Count - 1;
            show();
        }

        //first
        private void button1_Click(object sender, EventArgs e)
        {
            current = 0;
            show();
        }
    }
}
