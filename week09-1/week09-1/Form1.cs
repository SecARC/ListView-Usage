using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week09_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Horse");
            listBox1.Items.Add("Hound");

            btnDeleteItem.Enabled = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemTitle.Text.Trim()))
                return;


            bool found = false;
            foreach (string item in listBox1.Items)
            {
                if (string.Compare(item, txtItemTitle.Text.Trim(), true) == 0)
                    found = true;
            }
            if (found)
                return;

            listBox1.Items.Add(txtItemTitle.Text.Trim());

            txtItemTitle.Focus();
            txtItemTitle.SelectAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                labelSelectedItem1.Text = "Select an item";
                btnDeleteItem.Enabled = false;
                return;
            }

            labelSelectedItem1.Text = listBox1.SelectedItem.ToString();
            btnDeleteItem.Enabled = true;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            ListBox.SelectedObjectCollection items = new ListBox.SelectedObjectCollection(listBox1);

            for (int i = items.Count-1; i >= 0; i--)
            {
                listBox1.Items.Remove(items[i]);
            }

            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Animal> list = new List<Animal>();

            list.Add(new Animal() { id = 1, type = "Cow", fullName = "Sarıkız" });
            list.Add(new Animal() { id = 2, type = "Cow", fullName = "Benekli" });
            list.Add(new Animal() { id = 3, type = "Cat", fullName = "Tekir" });
            list.Add(new Animal() { id = 4, type = "Horse", fullName = "AliRıza Bey" });
            list.Add(new Animal() { id = 5, type = "Cat", fullName = "Pamuk" });

            listBox2.DataSource = list;
            FillListBox(listBox2, list);

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                labelSelectedItem2.Text = "Select an item";
                return;
            }

            //Animal item = listBox2.SelectedItem as Animal;
            //if (item == null)
            //{
            //    labelSelectedItem2.Text = "Select an item";
            //    return;
            //}

            string itemString = "";
            foreach (Animal item in listBox2.SelectedItems)
            {
                itemString += item.fullName + " (" + item.type + ") " + Environment.NewLine;
            }

            labelSelectedItem2.Text = itemString;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                return;
            }

            var list = listBox2.DataSource as List<Animal>;
            list.Remove((Animal)listBox2.SelectedItem);

            FillListBox(listBox2, list);
        }

        private void FillListBox(ListBox listBox, List<Animal> list)
        {
            listBox2.DataSource = null;
            listBox2.DataSource = list;
            listBox2.DisplayMember = "fullName";
            listBox2.ValueMember = "id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;


            Bitmap bitmap = new Bitmap(160, 160);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            switch (comboBox1.SelectedIndex)
            {
                case 0: //DrawCircle
                    g.DrawEllipse(Pens.DarkMagenta, 5, 5, 150, 150);
                    g.DrawString("X", new Font("Courier New", 40), Brushes.DarkMagenta, 55, 55);
                    break;
                case 1: //FillCircle
                    g.FillEllipse(Brushes.Magenta, 5, 5, 150, 150);
                    g.DrawString("O", new Font("Courier New", 40), Brushes.DarkMagenta, 55, 55);
                    break;
                default:
                    break;
            }

            pictureBox1.Image = bitmap;
        }
    }
}
