
namespace week10_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReadCars = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelSelectedGroup = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReportSuccessful = new System.Windows.Forms.Label();
            this.linkOpenReport = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnReadCars
            // 
            this.btnReadCars.Location = new System.Drawing.Point(13, 13);
            this.btnReadCars.Name = "btnReadCars";
            this.btnReadCars.Size = new System.Drawing.Size(133, 40);
            this.btnReadCars.TabIndex = 0;
            this.btnReadCars.Text = "Read Cars";
            this.btnReadCars.UseVisualStyleBackColor = true;
            this.btnReadCars.Click += new System.EventHandler(this.btnReadCars_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 59);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(133, 424);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Group";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(165, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(526, 200);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // labelSelectedGroup
            // 
            this.labelSelectedGroup.AutoSize = true;
            this.labelSelectedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSelectedGroup.Location = new System.Drawing.Point(261, 59);
            this.labelSelectedGroup.Name = "labelSelectedGroup";
            this.labelSelectedGroup.Size = new System.Drawing.Size(43, 13);
            this.labelSelectedGroup.TabIndex = 4;
            this.labelSelectedGroup.Text = "A/B/C";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(327, 291);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(157, 34);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "Generate report as\r\nBrandName, minimumHorsepower, maximumHorsepower\r\ngrouping by " +
    "BrandName\r\n\r\nWrite it to a text file";
            // 
            // labelReportSuccessful
            // 
            this.labelReportSuccessful.AutoSize = true;
            this.labelReportSuccessful.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelReportSuccessful.Location = new System.Drawing.Point(292, 418);
            this.labelReportSuccessful.Name = "labelReportSuccessful";
            this.labelReportSuccessful.Size = new System.Drawing.Size(260, 20);
            this.labelReportSuccessful.TabIndex = 7;
            this.labelReportSuccessful.Text = "Report Generated Successfully";
            this.labelReportSuccessful.Visible = false;
            // 
            // linkOpenReport
            // 
            this.linkOpenReport.AutoSize = true;
            this.linkOpenReport.Location = new System.Drawing.Point(366, 449);
            this.linkOpenReport.Name = "linkOpenReport";
            this.linkOpenReport.Size = new System.Drawing.Size(68, 13);
            this.linkOpenReport.TabIndex = 8;
            this.linkOpenReport.TabStop = true;
            this.linkOpenReport.Text = "Open Report";
            this.linkOpenReport.Visible = false;
            this.linkOpenReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOpenReport_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 495);
            this.Controls.Add(this.linkOpenReport);
            this.Controls.Add(this.labelReportSuccessful);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.labelSelectedGroup);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnReadCars);
            this.Name = "Form1";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadCars;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelSelectedGroup;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelReportSuccessful;
        private System.Windows.Forms.LinkLabel linkOpenReport;
    }
}

