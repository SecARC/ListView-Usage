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

namespace week10_1
{
    public partial class Form1 : Form
    {
        public List<Vehicle> vehicles { get; set; }
        public List<Vehicle> filteredList { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initTreeview();
            initListView();
            initUI();
        }

        private void initTreeview()
        {
            treeView1.Nodes.Clear();

            treeView1.Nodes.Add("Load cars...");
        }

        private void initListView()
        {
            listView1.View = View.Details;

            listView1.Columns.Clear();
            listView1.Columns.Add("Car");
            listView1.Columns.Add("MPG");
            listView1.Columns.Add("Cylinders");
            listView1.Columns.Add("Displacement");
            listView1.Columns.Add("Horsepower");
            listView1.Columns.Add("Weight");
            listView1.Columns.Add("Acceleration");
            listView1.Columns.Add("Model");
            listView1.Columns.Add("Origin");
            listView1.Columns.Add("Brand");

            listView1.Items.Clear();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void initUI()
        {
            labelReportSuccessful.Visible = false;
            linkOpenReport.Visible = false;
        }

        private void btnReadCars_Click(object sender, EventArgs e)
        {
            try
            {
                vehicles = new List<Vehicle>();
                using (StreamReader sr = new StreamReader("cars.csv"))
                {
                    string line = sr.ReadLine(); //this will skip the header line
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();

                        Vehicle vehicle = new Vehicle(line);
                        vehicles.Add(vehicle);
                    }
                }

                FillTreeview();
            }
            catch (IOException ex)
            {
                MessageBox.Show("File read error\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
        }

        private void FillTreeview()
        {
            treeView1.Nodes.Clear();

            TreeNode root = treeView1.Nodes.Add("Cars");

            TreeNode node = root.Nodes.Add("Brand");

            string[] items = vehicles.Select(x => x.Brand).Distinct().ToArray();
            Array.Sort(items);
            foreach (var item in items)
            {
                node.Nodes.Add(item).Tag = "brand";
            }

            node = root.Nodes.Add("Origin");

            items = vehicles.Select(x => x.Origin).Distinct().ToArray();
            Array.Sort(items);
            foreach (var item in items)
            {
                node.Nodes.Add(item).Tag = "origin";
            }

            node = root.Nodes.Add("Model");

            items = vehicles.Select(x => x.Model.ToString()).Distinct().ToArray();
            Array.Sort(items);
            foreach (var item in items)
            {
                node.Nodes.Add(item).Tag = "model";
            }

            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            labelSelectedGroup.Text = e.Node.FullPath;

            fillListView(e.Node);
        }

        private void fillListView(TreeNode node)
        {
            filteredList = new List<Vehicle>();
            switch (node.Tag)
            {
                case "brand":
                    filteredList = vehicles.FindAll(x => x.Brand == node.Text);
                    break;
                case "origin":
                    filteredList = vehicles.FindAll(x => x.Origin == node.Text);
                    break;
                case "model":
                    filteredList = vehicles.FindAll(x => x.Model.ToString() == node.Text);
                    break;
                default:
                    break;
            }

            listView1.Items.Clear();
            foreach (var item in filteredList)
            {
                var listItem = listView1.Items.Add(item.Car);

                listItem.SubItems.Add(item.MPG.ToString());
                listItem.SubItems.Add(item.Cylinders.ToString());
                listItem.SubItems.Add(item.Displacement.ToString());
                listItem.SubItems.Add(item.Horsepower.ToString());
                listItem.SubItems.Add(item.Weight.ToString());
                listItem.SubItems.Add(item.Acceleration.ToString());
                listItem.SubItems.Add(item.Model.ToString());
                listItem.SubItems.Add(item.Origin);
                listItem.SubItems.Add(item.Brand);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                string[] brandNames = filteredList.Select(x => x.Brand).Distinct().ToArray();
                Array.Sort(brandNames);

                using (StreamWriter sw = new StreamWriter("report.txt"))
                {
                    foreach (var brandName in brandNames)
                    {
                        var min = filteredList.FindAll(x => x.Brand == brandName).Min(y => y.Horsepower);
                        var max = filteredList.FindAll(x => x.Brand == brandName).Max(y => y.Horsepower);

                        sw.WriteLine(brandName + "," + min + "," + max);
                    }
                }
                labelReportSuccessful.Visible = true;
                linkOpenReport.Visible = true;
            }
            catch (IOException ex)
            {
                labelReportSuccessful.Visible = false;
                linkOpenReport.Visible = false;
                MessageBox.Show("File write error\n" + ex.Message);
            }
            catch (Exception ex)
            {
                labelReportSuccessful.Visible = false;
                linkOpenReport.Visible = false;
                MessageBox.Show("Error\n" + ex.Message);
            }
        }

        private void linkOpenReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("report.txt");
        }
    }
}
