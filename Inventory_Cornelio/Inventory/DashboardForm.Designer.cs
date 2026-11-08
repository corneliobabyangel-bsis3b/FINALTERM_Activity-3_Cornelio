using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Inventory
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.Categories = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblY0 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblY10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblY20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblY30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblY40 = new System.Windows.Forms.Label();
            this.lblY50 = new System.Windows.Forms.Label();
            this.pnlOverviewHeader = new System.Windows.Forms.Panel();
            this.lblOverviewTitle = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPctInStock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDotInStock = new System.Windows.Forms.Label();
            this.lblLegendInStock = new System.Windows.Forms.Label();
            this.lblCountInStock = new System.Windows.Forms.Label();
            this.lblDotLowStock = new System.Windows.Forms.Label();
            this.lblLegendLowStock = new System.Windows.Forms.Label();
            this.lblCountLowStock = new System.Windows.Forms.Label();
            this.lblDotOutofStock = new System.Windows.Forms.Label();
            this.lblLegendOutofStock = new System.Windows.Forms.Label();
            this.lblCountOutofStock = new System.Windows.Forms.Label();
            this.pnlStatusHeader = new System.Windows.Forms.Panel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblActIcon1 = new System.Windows.Forms.Label();
            this.pnlActivityHeader = new System.Windows.Forms.Panel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.lblActText1 = new System.Windows.Forms.Label();
            this.lblActText2 = new System.Windows.Forms.Label();
            this.lblActDate1 = new System.Windows.Forms.Label();
            this.lineActV = new System.Windows.Forms.Panel();
            this.lblActIcon2 = new System.Windows.Forms.Label();
            this.lblActDate3 = new System.Windows.Forms.Label();
            this.lblActText3 = new System.Windows.Forms.Label();
            this.lblActDate2 = new System.Windows.Forms.Label();
            this.lblActIcon3 = new System.Windows.Forms.Label();
            this.pnlAlerts = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblAlertIcon1 = new System.Windows.Forms.Label();
            this.pnlAlertsHeader = new System.Windows.Forms.Panel();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.lblAlertName2 = new System.Windows.Forms.Label();
            this.lblAlertQty1 = new System.Windows.Forms.Label();
            this.lblAlertName1 = new System.Windows.Forms.Label();
            this.lblAlertQty3 = new System.Windows.Forms.Label();
            this.lblAlertName3 = new System.Windows.Forms.Label();
            this.lblAlertIcon2 = new System.Windows.Forms.Label();
            this.lblAlertIcon3 = new System.Windows.Forms.Label();
            this.lineAlertV = new System.Windows.Forms.Panel();
            this.lblAlertQty2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlOverview.SuspendLayout();
            this.pnlOverviewHeader.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStatusHeader.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.pnlActivityHeader.SuspendLayout();
            this.pnlAlerts.SuspendLayout();
            this.pnlAlertsHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(21, 577);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(176, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "⏻️ Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(21, 199);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "🖥️Dashboard";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(111)))), ((int)(((byte)(216)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(21, 262);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 40);
            this.button3.TabIndex = 31;
            this.button3.Text = "🛍️Products";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(111)))), ((int)(((byte)(216)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(21, 325);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 40);
            this.button4.TabIndex = 32;
            this.button4.Text = "🏪Suppliers";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(111)))), ((int)(((byte)(216)))));
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(21, 514);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 40);
            this.button5.TabIndex = 33;
            this.button5.Text = "⚙️ Settings";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(111)))), ((int)(((byte)(216)))));
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.button6.Location = new System.Drawing.Point(21, 451);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 40);
            this.button6.TabIndex = 34;
            this.button6.Text = "📑Reports";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(111)))), ((int)(((byte)(216)))));
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.button7.Location = new System.Drawing.Point(21, 388);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 40);
            this.button7.TabIndex = 35;
            this.button7.Text = "📊Logs";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.textBox2.Location = new System.Drawing.Point(238, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 52);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "Welcome, Admin!";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.textBox4.Location = new System.Drawing.Point(0, 67);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 73);
            this.textBox4.TabIndex = 41;
            this.textBox4.Text = "IMS";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(215, 723);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // pnlOverview
            // 
            this.pnlOverview.BackColor = System.Drawing.Color.White;
            this.pnlOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOverview.Controls.Add(this.Categories);
            this.pnlOverview.Controls.Add(this.panel4);
            this.pnlOverview.Controls.Add(this.lblY0);
            this.pnlOverview.Controls.Add(this.panel3);
            this.pnlOverview.Controls.Add(this.panel5);
            this.pnlOverview.Controls.Add(this.lblY10);
            this.pnlOverview.Controls.Add(this.panel6);
            this.pnlOverview.Controls.Add(this.lblY20);
            this.pnlOverview.Controls.Add(this.panel2);
            this.pnlOverview.Controls.Add(this.lblY30);
            this.pnlOverview.Controls.Add(this.panel1);
            this.pnlOverview.Controls.Add(this.lblY40);
            this.pnlOverview.Controls.Add(this.lblY50);
            this.pnlOverview.Controls.Add(this.pnlOverviewHeader);
            this.pnlOverview.Location = new System.Drawing.Point(237, 234);
            this.pnlOverview.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(655, 229);
            this.pnlOverview.TabIndex = 0;
            this.pnlOverview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOverview_Paint);
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.Location = new System.Drawing.Point(302, 206);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(73, 16);
            this.Categories.TabIndex = 47;
            this.Categories.Text = "Categories";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(76, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 3);
            this.panel4.TabIndex = 46;
            // 
            // lblY0
            // 
            this.lblY0.BackColor = System.Drawing.Color.Transparent;
            this.lblY0.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblY0.ForeColor = System.Drawing.Color.Black;
            this.lblY0.Location = new System.Drawing.Point(14, 171);
            this.lblY0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(44, 22);
            this.lblY0.TabIndex = 17;
            this.lblY0.Text = "0";
            this.lblY0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(76, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 3);
            this.panel3.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(76, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(557, 3);
            this.panel5.TabIndex = 45;
            // 
            // lblY10
            // 
            this.lblY10.BackColor = System.Drawing.Color.Transparent;
            this.lblY10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblY10.ForeColor = System.Drawing.Color.Black;
            this.lblY10.Location = new System.Drawing.Point(14, 148);
            this.lblY10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY10.Name = "lblY10";
            this.lblY10.Size = new System.Drawing.Size(44, 22);
            this.lblY10.TabIndex = 18;
            this.lblY10.Text = "10";
            this.lblY10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(76, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(557, 3);
            this.panel6.TabIndex = 44;
            // 
            // lblY20
            // 
            this.lblY20.BackColor = System.Drawing.Color.Transparent;
            this.lblY20.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblY20.ForeColor = System.Drawing.Color.Black;
            this.lblY20.Location = new System.Drawing.Point(14, 123);
            this.lblY20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY20.Name = "lblY20";
            this.lblY20.Size = new System.Drawing.Size(44, 22);
            this.lblY20.TabIndex = 19;
            this.lblY20.Text = "20";
            this.lblY20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(76, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 3);
            this.panel2.TabIndex = 43;
            // 
            // lblY30
            // 
            this.lblY30.BackColor = System.Drawing.Color.Transparent;
            this.lblY30.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblY30.ForeColor = System.Drawing.Color.Black;
            this.lblY30.Location = new System.Drawing.Point(14, 96);
            this.lblY30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY30.Name = "lblY30";
            this.lblY30.Size = new System.Drawing.Size(44, 22);
            this.lblY30.TabIndex = 20;
            this.lblY30.Text = "30";
            this.lblY30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(76, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 3);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblY40
            // 
            this.lblY40.BackColor = System.Drawing.Color.Transparent;
            this.lblY40.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblY40.ForeColor = System.Drawing.Color.Black;
            this.lblY40.Location = new System.Drawing.Point(14, 72);
            this.lblY40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY40.Name = "lblY40";
            this.lblY40.Size = new System.Drawing.Size(44, 22);
            this.lblY40.TabIndex = 21;
            this.lblY40.Text = "40";
            this.lblY40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblY50
            // 
            this.lblY50.BackColor = System.Drawing.Color.Transparent;
            this.lblY50.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblY50.ForeColor = System.Drawing.Color.Black;
            this.lblY50.Location = new System.Drawing.Point(14, 46);
            this.lblY50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY50.Name = "lblY50";
            this.lblY50.Size = new System.Drawing.Size(44, 22);
            this.lblY50.TabIndex = 22;
            this.lblY50.Text = "50";
            this.lblY50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlOverviewHeader
            // 
            this.pnlOverviewHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(145)))));
            this.pnlOverviewHeader.Controls.Add(this.lblOverviewTitle);
            this.pnlOverviewHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOverviewHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlOverviewHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOverviewHeader.Name = "pnlOverviewHeader";
            this.pnlOverviewHeader.Size = new System.Drawing.Size(653, 38);
            this.pnlOverviewHeader.TabIndex = 29;
            // 
            // lblOverviewTitle
            // 
            this.lblOverviewTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOverviewTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOverviewTitle.ForeColor = System.Drawing.Color.White;
            this.lblOverviewTitle.Location = new System.Drawing.Point(0, 0);
            this.lblOverviewTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverviewTitle.Name = "lblOverviewTitle";
            this.lblOverviewTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblOverviewTitle.Size = new System.Drawing.Size(653, 38);
            this.lblOverviewTitle.TabIndex = 0;
            this.lblOverviewTitle.Text = "Inventory Overview";
            this.lblOverviewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.label6);
            this.pnlStatus.Controls.Add(this.lblPctInStock);
            this.pnlStatus.Controls.Add(this.label5);
            this.pnlStatus.Controls.Add(this.pictureBox1);
            this.pnlStatus.Controls.Add(this.lblDotInStock);
            this.pnlStatus.Controls.Add(this.lblLegendInStock);
            this.pnlStatus.Controls.Add(this.lblCountInStock);
            this.pnlStatus.Controls.Add(this.lblDotLowStock);
            this.pnlStatus.Controls.Add(this.lblLegendLowStock);
            this.pnlStatus.Controls.Add(this.lblCountLowStock);
            this.pnlStatus.Controls.Add(this.lblDotOutofStock);
            this.pnlStatus.Controls.Add(this.lblLegendOutofStock);
            this.pnlStatus.Controls.Add(this.lblCountOutofStock);
            this.pnlStatus.Controls.Add(this.pnlStatusHeader);
            this.pnlStatus.Location = new System.Drawing.Point(903, 235);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(464, 229);
            this.pnlStatus.TabIndex = 1;
            this.pnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatus_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(176, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "20%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPctInStock
            // 
            this.lblPctInStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(175)))));
            this.lblPctInStock.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPctInStock.ForeColor = System.Drawing.Color.White;
            this.lblPctInStock.Location = new System.Drawing.Point(157, 183);
            this.lblPctInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPctInStock.Name = "lblPctInStock";
            this.lblPctInStock.Size = new System.Drawing.Size(67, 22);
            this.lblPctInStock.TabIndex = 1;
            this.lblPctInStock.Text = "40%";
            this.lblPctInStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(157, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "40%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Inventory.Properties.Resources.Screenshot_2026_11_08_105007;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 150);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblDotInStock
            // 
            this.lblDotInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblDotInStock.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblDotInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(82)))), ((int)(((byte)(175)))));
            this.lblDotInStock.Location = new System.Drawing.Point(245, 55);
            this.lblDotInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDotInStock.Name = "lblDotInStock";
            this.lblDotInStock.Size = new System.Drawing.Size(32, 30);
            this.lblDotInStock.TabIndex = 4;
            this.lblDotInStock.Text = "●";
            this.lblDotInStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendInStock
            // 
            this.lblLegendInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendInStock.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblLegendInStock.ForeColor = System.Drawing.Color.Black;
            this.lblLegendInStock.Location = new System.Drawing.Point(276, 57);
            this.lblLegendInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegendInStock.Name = "lblLegendInStock";
            this.lblLegendInStock.Size = new System.Drawing.Size(117, 30);
            this.lblLegendInStock.TabIndex = 5;
            this.lblLegendInStock.Text = "In Stock";
            this.lblLegendInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountInStock
            // 
            this.lblCountInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblCountInStock.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCountInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.lblCountInStock.Location = new System.Drawing.Point(388, 55);
            this.lblCountInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountInStock.Name = "lblCountInStock";
            this.lblCountInStock.Size = new System.Drawing.Size(46, 30);
            this.lblCountInStock.TabIndex = 6;
            this.lblCountInStock.Text = "2";
            this.lblCountInStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCountInStock.Click += new System.EventHandler(this.lblCountInStock_Click);
            // 
            // lblDotLowStock
            // 
            this.lblDotLowStock.BackColor = System.Drawing.Color.Transparent;
            this.lblDotLowStock.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblDotLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.lblDotLowStock.Location = new System.Drawing.Point(245, 98);
            this.lblDotLowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDotLowStock.Name = "lblDotLowStock";
            this.lblDotLowStock.Size = new System.Drawing.Size(32, 30);
            this.lblDotLowStock.TabIndex = 7;
            this.lblDotLowStock.Text = "●";
            this.lblDotLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendLowStock
            // 
            this.lblLegendLowStock.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendLowStock.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblLegendLowStock.ForeColor = System.Drawing.Color.Black;
            this.lblLegendLowStock.Location = new System.Drawing.Point(276, 100);
            this.lblLegendLowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegendLowStock.Name = "lblLegendLowStock";
            this.lblLegendLowStock.Size = new System.Drawing.Size(117, 30);
            this.lblLegendLowStock.TabIndex = 8;
            this.lblLegendLowStock.Text = "Low Stock";
            this.lblLegendLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountLowStock
            // 
            this.lblCountLowStock.BackColor = System.Drawing.Color.Transparent;
            this.lblCountLowStock.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCountLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.lblCountLowStock.Location = new System.Drawing.Point(388, 98);
            this.lblCountLowStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountLowStock.Name = "lblCountLowStock";
            this.lblCountLowStock.Size = new System.Drawing.Size(46, 30);
            this.lblCountLowStock.TabIndex = 9;
            this.lblCountLowStock.Text = "2";
            this.lblCountLowStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDotOutofStock
            // 
            this.lblDotOutofStock.BackColor = System.Drawing.Color.Transparent;
            this.lblDotOutofStock.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblDotOutofStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblDotOutofStock.Location = new System.Drawing.Point(245, 142);
            this.lblDotOutofStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDotOutofStock.Name = "lblDotOutofStock";
            this.lblDotOutofStock.Size = new System.Drawing.Size(32, 30);
            this.lblDotOutofStock.TabIndex = 10;
            this.lblDotOutofStock.Text = "●";
            this.lblDotOutofStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLegendOutofStock
            // 
            this.lblLegendOutofStock.BackColor = System.Drawing.Color.Transparent;
            this.lblLegendOutofStock.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblLegendOutofStock.ForeColor = System.Drawing.Color.Black;
            this.lblLegendOutofStock.Location = new System.Drawing.Point(276, 144);
            this.lblLegendOutofStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegendOutofStock.Name = "lblLegendOutofStock";
            this.lblLegendOutofStock.Size = new System.Drawing.Size(117, 30);
            this.lblLegendOutofStock.TabIndex = 11;
            this.lblLegendOutofStock.Text = "Out of Stock";
            this.lblLegendOutofStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountOutofStock
            // 
            this.lblCountOutofStock.BackColor = System.Drawing.Color.Transparent;
            this.lblCountOutofStock.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCountOutofStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.lblCountOutofStock.Location = new System.Drawing.Point(388, 142);
            this.lblCountOutofStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountOutofStock.Name = "lblCountOutofStock";
            this.lblCountOutofStock.Size = new System.Drawing.Size(46, 30);
            this.lblCountOutofStock.TabIndex = 12;
            this.lblCountOutofStock.Text = "1";
            this.lblCountOutofStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlStatusHeader
            // 
            this.pnlStatusHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(145)))));
            this.pnlStatusHeader.Controls.Add(this.lblStatusTitle);
            this.pnlStatusHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatusHeader.Name = "pnlStatusHeader";
            this.pnlStatusHeader.Size = new System.Drawing.Size(462, 38);
            this.pnlStatusHeader.TabIndex = 13;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatusTitle.Location = new System.Drawing.Point(0, 0);
            this.lblStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblStatusTitle.Size = new System.Drawing.Size(462, 38);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Stock Status";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusTitle.Click += new System.EventHandler(this.lblStatusTitle_Click);
            // 
            // pnlActivity
            // 
            this.pnlActivity.BackColor = System.Drawing.Color.White;
            this.pnlActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActivity.Controls.Add(this.panel10);
            this.pnlActivity.Controls.Add(this.panel9);
            this.pnlActivity.Controls.Add(this.panel8);
            this.pnlActivity.Controls.Add(this.lblActIcon1);
            this.pnlActivity.Controls.Add(this.pnlActivityHeader);
            this.pnlActivity.Controls.Add(this.lblActText1);
            this.pnlActivity.Controls.Add(this.lblActText2);
            this.pnlActivity.Controls.Add(this.lblActDate1);
            this.pnlActivity.Controls.Add(this.lineActV);
            this.pnlActivity.Controls.Add(this.lblActIcon2);
            this.pnlActivity.Controls.Add(this.lblActDate3);
            this.pnlActivity.Controls.Add(this.lblActText3);
            this.pnlActivity.Controls.Add(this.lblActDate2);
            this.pnlActivity.Controls.Add(this.lblActIcon3);
            this.pnlActivity.Location = new System.Drawing.Point(237, 490);
            this.pnlActivity.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(656, 212);
            this.pnlActivity.TabIndex = 2;
            this.pnlActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlActivity_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gainsboro;
            this.panel10.Location = new System.Drawing.Point(20, 195);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(615, 1);
            this.panel10.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.Location = new System.Drawing.Point(20, 147);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(615, 1);
            this.panel9.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Location = new System.Drawing.Point(20, 95);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(615, 1);
            this.panel8.TabIndex = 13;
            // 
            // lblActIcon1
            // 
            this.lblActIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblActIcon1.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold);
            this.lblActIcon1.ForeColor = System.Drawing.Color.White;
            this.lblActIcon1.Location = new System.Drawing.Point(16, 54);
            this.lblActIcon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActIcon1.Name = "lblActIcon1";
            this.lblActIcon1.Size = new System.Drawing.Size(32, 30);
            this.lblActIcon1.TabIndex = 0;
            this.lblActIcon1.Text = "+";
            this.lblActIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActivityHeader
            // 
            this.pnlActivityHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(145)))));
            this.pnlActivityHeader.Controls.Add(this.lblActivityTitle);
            this.pnlActivityHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActivityHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlActivityHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActivityHeader.Name = "pnlActivityHeader";
            this.pnlActivityHeader.Size = new System.Drawing.Size(654, 38);
            this.pnlActivityHeader.TabIndex = 13;
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblActivityTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.White;
            this.lblActivityTitle.Location = new System.Drawing.Point(0, 0);
            this.lblActivityTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblActivityTitle.Size = new System.Drawing.Size(654, 38);
            this.lblActivityTitle.TabIndex = 0;
            this.lblActivityTitle.Text = "Recent Activity";
            this.lblActivityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActText1
            // 
            this.lblActText1.BackColor = System.Drawing.Color.Transparent;
            this.lblActText1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActText1.ForeColor = System.Drawing.Color.Black;
            this.lblActText1.Location = new System.Drawing.Point(64, 50);
            this.lblActText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActText1.Name = "lblActText1";
            this.lblActText1.Size = new System.Drawing.Size(355, 37);
            this.lblActText1.TabIndex = 1;
            this.lblActText1.Text = "New product added — Velvet Matte Lipstick";
            this.lblActText1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActText2
            // 
            this.lblActText2.BackColor = System.Drawing.Color.Transparent;
            this.lblActText2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActText2.ForeColor = System.Drawing.Color.Black;
            this.lblActText2.Location = new System.Drawing.Point(64, 100);
            this.lblActText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActText2.Name = "lblActText2";
            this.lblActText2.Size = new System.Drawing.Size(355, 37);
            this.lblActText2.TabIndex = 5;
            this.lblActText2.Text = "Stock updated — Hydrating Serum";
            this.lblActText2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActText2.Click += new System.EventHandler(this.lblActText2_Click);
            // 
            // lblActDate1
            // 
            this.lblActDate1.BackColor = System.Drawing.Color.Transparent;
            this.lblActDate1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActDate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblActDate1.Location = new System.Drawing.Point(446, 47);
            this.lblActDate1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActDate1.Name = "lblActDate1";
            this.lblActDate1.Size = new System.Drawing.Size(189, 37);
            this.lblActDate1.TabIndex = 2;
            this.lblActDate1.Text = "Nov 3, 2025 10:24 AM";
            this.lblActDate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineActV
            // 
            this.lineActV.BackColor = System.Drawing.Color.Gainsboro;
            this.lineActV.Location = new System.Drawing.Point(427, 46);
            this.lineActV.Margin = new System.Windows.Forms.Padding(4);
            this.lineActV.Name = "lineActV";
            this.lineActV.Size = new System.Drawing.Size(1, 150);
            this.lineActV.TabIndex = 12;
            // 
            // lblActIcon2
            // 
            this.lblActIcon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(115)))), ((int)(((byte)(230)))));
            this.lblActIcon2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold);
            this.lblActIcon2.ForeColor = System.Drawing.Color.White;
            this.lblActIcon2.Location = new System.Drawing.Point(16, 104);
            this.lblActIcon2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActIcon2.Name = "lblActIcon2";
            this.lblActIcon2.Size = new System.Drawing.Size(32, 30);
            this.lblActIcon2.TabIndex = 4;
            this.lblActIcon2.Text = "✎";
            this.lblActIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActDate3
            // 
            this.lblActDate3.BackColor = System.Drawing.Color.Transparent;
            this.lblActDate3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActDate3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblActDate3.Location = new System.Drawing.Point(446, 148);
            this.lblActDate3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActDate3.Name = "lblActDate3";
            this.lblActDate3.Size = new System.Drawing.Size(189, 37);
            this.lblActDate3.TabIndex = 10;
            this.lblActDate3.Text = "Nov 3, 2025 09:15 AM";
            this.lblActDate3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActText3
            // 
            this.lblActText3.BackColor = System.Drawing.Color.Transparent;
            this.lblActText3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActText3.ForeColor = System.Drawing.Color.Black;
            this.lblActText3.Location = new System.Drawing.Point(64, 152);
            this.lblActText3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActText3.Name = "lblActText3";
            this.lblActText3.Size = new System.Drawing.Size(340, 37);
            this.lblActText3.TabIndex = 9;
            this.lblActText3.Text = "Supplier added — Allure Glow";
            this.lblActText3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActDate2
            // 
            this.lblActDate2.BackColor = System.Drawing.Color.Transparent;
            this.lblActDate2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblActDate2.Location = new System.Drawing.Point(444, 101);
            this.lblActDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActDate2.Name = "lblActDate2";
            this.lblActDate2.Size = new System.Drawing.Size(189, 37);
            this.lblActDate2.TabIndex = 6;
            this.lblActDate2.Text = "Nov 3, 2025 09:50 AM";
            this.lblActDate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActIcon3
            // 
            this.lblActIcon3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblActIcon3.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold);
            this.lblActIcon3.ForeColor = System.Drawing.Color.White;
            this.lblActIcon3.Location = new System.Drawing.Point(16, 155);
            this.lblActIcon3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActIcon3.Name = "lblActIcon3";
            this.lblActIcon3.Size = new System.Drawing.Size(32, 30);
            this.lblActIcon3.TabIndex = 8;
            this.lblActIcon3.Text = "☺";
            this.lblActIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAlerts
            // 
            this.pnlAlerts.BackColor = System.Drawing.Color.White;
            this.pnlAlerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlerts.Controls.Add(this.panel13);
            this.pnlAlerts.Controls.Add(this.panel12);
            this.pnlAlerts.Controls.Add(this.panel11);
            this.pnlAlerts.Controls.Add(this.lblAlertIcon1);
            this.pnlAlerts.Controls.Add(this.pnlAlertsHeader);
            this.pnlAlerts.Controls.Add(this.lblAlertName2);
            this.pnlAlerts.Controls.Add(this.lblAlertQty1);
            this.pnlAlerts.Controls.Add(this.lblAlertName1);
            this.pnlAlerts.Controls.Add(this.lblAlertQty3);
            this.pnlAlerts.Controls.Add(this.lblAlertName3);
            this.pnlAlerts.Controls.Add(this.lblAlertIcon2);
            this.pnlAlerts.Controls.Add(this.lblAlertIcon3);
            this.pnlAlerts.Controls.Add(this.lineAlertV);
            this.pnlAlerts.Controls.Add(this.lblAlertQty2);
            this.pnlAlerts.Location = new System.Drawing.Point(904, 490);
            this.pnlAlerts.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAlerts.Name = "pnlAlerts";
            this.pnlAlerts.Size = new System.Drawing.Size(464, 212);
            this.pnlAlerts.TabIndex = 3;
            this.pnlAlerts.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAlerts_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gainsboro;
            this.panel13.Location = new System.Drawing.Point(20, 197);
            this.panel13.Margin = new System.Windows.Forms.Padding(4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(427, 1);
            this.panel13.TabIndex = 14;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gainsboro;
            this.panel12.Location = new System.Drawing.Point(20, 146);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(427, 1);
            this.panel12.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gainsboro;
            this.panel11.Location = new System.Drawing.Point(20, 95);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(427, 1);
            this.panel11.TabIndex = 13;
            // 
            // lblAlertIcon1
            // 
            this.lblAlertIcon1.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertIcon1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F);
            this.lblAlertIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblAlertIcon1.Location = new System.Drawing.Point(17, 49);
            this.lblAlertIcon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertIcon1.Name = "lblAlertIcon1";
            this.lblAlertIcon1.Size = new System.Drawing.Size(37, 34);
            this.lblAlertIcon1.TabIndex = 0;
            this.lblAlertIcon1.Text = "⚠";
            this.lblAlertIcon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAlertsHeader
            // 
            this.pnlAlertsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(145)))));
            this.pnlAlertsHeader.Controls.Add(this.lblAlertsTitle);
            this.pnlAlertsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAlertsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAlertsHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAlertsHeader.Name = "pnlAlertsHeader";
            this.pnlAlertsHeader.Size = new System.Drawing.Size(462, 38);
            this.pnlAlertsHeader.TabIndex = 13;
            // 
            // lblAlertsTitle
            // 
            this.lblAlertsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = System.Drawing.Color.White;
            this.lblAlertsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAlertsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertsTitle.Name = "lblAlertsTitle";
            this.lblAlertsTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblAlertsTitle.Size = new System.Drawing.Size(462, 38);
            this.lblAlertsTitle.TabIndex = 0;
            this.lblAlertsTitle.Text = "Low Stock Alerts";
            this.lblAlertsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlertName2
            // 
            this.lblAlertName2.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertName2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblAlertName2.ForeColor = System.Drawing.Color.Black;
            this.lblAlertName2.Location = new System.Drawing.Point(65, 100);
            this.lblAlertName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertName2.Name = "lblAlertName2";
            this.lblAlertName2.Size = new System.Drawing.Size(251, 37);
            this.lblAlertName2.TabIndex = 5;
            this.lblAlertName2.Text = "Matte Lipstick";
            this.lblAlertName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlertQty1
            // 
            this.lblAlertQty1.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertQty1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlertQty1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.lblAlertQty1.Location = new System.Drawing.Point(343, 52);
            this.lblAlertQty1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertQty1.Name = "lblAlertQty1";
            this.lblAlertQty1.Size = new System.Drawing.Size(93, 37);
            this.lblAlertQty1.TabIndex = 2;
            this.lblAlertQty1.Text = "3 pcs";
            this.lblAlertQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlertName1
            // 
            this.lblAlertName1.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertName1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblAlertName1.ForeColor = System.Drawing.Color.Black;
            this.lblAlertName1.Location = new System.Drawing.Point(65, 48);
            this.lblAlertName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertName1.Name = "lblAlertName1";
            this.lblAlertName1.Size = new System.Drawing.Size(251, 37);
            this.lblAlertName1.TabIndex = 1;
            this.lblAlertName1.Text = "Hydrating Serum";
            this.lblAlertName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlertQty3
            // 
            this.lblAlertQty3.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertQty3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlertQty3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.lblAlertQty3.Location = new System.Drawing.Point(348, 152);
            this.lblAlertQty3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertQty3.Name = "lblAlertQty3";
            this.lblAlertQty3.Size = new System.Drawing.Size(88, 37);
            this.lblAlertQty3.TabIndex = 10;
            this.lblAlertQty3.Text = "20 pcs";
            this.lblAlertQty3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlertName3
            // 
            this.lblAlertName3.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertName3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblAlertName3.ForeColor = System.Drawing.Color.Black;
            this.lblAlertName3.Location = new System.Drawing.Point(65, 152);
            this.lblAlertName3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertName3.Name = "lblAlertName3";
            this.lblAlertName3.Size = new System.Drawing.Size(251, 37);
            this.lblAlertName3.TabIndex = 9;
            this.lblAlertName3.Text = "Liquid Foundation";
            this.lblAlertName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlertIcon2
            // 
            this.lblAlertIcon2.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertIcon2.Font = new System.Drawing.Font("Segoe UI Symbol", 13F);
            this.lblAlertIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblAlertIcon2.Location = new System.Drawing.Point(17, 101);
            this.lblAlertIcon2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertIcon2.Name = "lblAlertIcon2";
            this.lblAlertIcon2.Size = new System.Drawing.Size(37, 34);
            this.lblAlertIcon2.TabIndex = 4;
            this.lblAlertIcon2.Text = "⚠";
            this.lblAlertIcon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlertIcon3
            // 
            this.lblAlertIcon3.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertIcon3.Font = new System.Drawing.Font("Segoe UI Symbol", 13F);
            this.lblAlertIcon3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblAlertIcon3.Location = new System.Drawing.Point(17, 153);
            this.lblAlertIcon3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertIcon3.Name = "lblAlertIcon3";
            this.lblAlertIcon3.Size = new System.Drawing.Size(37, 34);
            this.lblAlertIcon3.TabIndex = 8;
            this.lblAlertIcon3.Text = "⚠";
            this.lblAlertIcon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineAlertV
            // 
            this.lineAlertV.BackColor = System.Drawing.Color.Gainsboro;
            this.lineAlertV.Location = new System.Drawing.Point(334, 44);
            this.lineAlertV.Margin = new System.Windows.Forms.Padding(4);
            this.lineAlertV.Name = "lineAlertV";
            this.lineAlertV.Size = new System.Drawing.Size(1, 150);
            this.lineAlertV.TabIndex = 12;
            // 
            // lblAlertQty2
            // 
            this.lblAlertQty2.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertQty2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAlertQty2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.lblAlertQty2.Location = new System.Drawing.Point(338, 101);
            this.lblAlertQty2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertQty2.Name = "lblAlertQty2";
            this.lblAlertQty2.Size = new System.Drawing.Size(98, 37);
            this.lblAlertQty2.TabIndex = 6;
            this.lblAlertQty2.Text = "12 pcs";
            this.lblAlertQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAlertQty2.Click += new System.EventHandler(this.lblAlertQty2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.label9.Location = new System.Drawing.Point(152, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 42);
            this.label9.TabIndex = 3;
            this.label9.Text = "⛔";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label10.Location = new System.Drawing.Point(150, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 42);
            this.label10.TabIndex = 4;
            this.label10.Text = "🏷️";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(116)))), ((int)(((byte)(217)))));
            this.label7.Location = new System.Drawing.Point(149, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 42);
            this.label7.TabIndex = 1;
            this.label7.Text = "📦";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(284, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 76);
            this.panel7.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Products";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(204)))));
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label12);
            this.panel14.Controls.Add(this.label2);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(553, 132);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(227, 76);
            this.panel14.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label12.Location = new System.Drawing.Point(36, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Low Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(149, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 42);
            this.label8.TabIndex = 2;
            this.label8.Text = "⚠️";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(229)))));
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.label13);
            this.panel15.Controls.Add(this.label3);
            this.panel15.Controls.Add(this.label9);
            this.panel15.Location = new System.Drawing.Point(822, 132);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(227, 76);
            this.panel15.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label13.Location = new System.Drawing.Point(31, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 28);
            this.label13.TabIndex = 5;
            this.label13.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Out of Stock";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.label14);
            this.panel16.Controls.Add(this.label11);
            this.panel16.Controls.Add(this.label10);
            this.panel16.Location = new System.Drawing.Point(1091, 132);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(227, 76);
            this.panel16.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label14.Location = new System.Drawing.Point(27, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 28);
            this.label14.TabIndex = 6;
            this.label14.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(154)))));
            this.label11.Location = new System.Drawing.Point(12, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Categories";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1392, 723);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlAlerts);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlActivity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY MANAGEMENT SYSTEM_Cornelio";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.pnlOverviewHeader.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStatusHeader.ResumeLayout(false);
            this.pnlActivity.ResumeLayout(false);
            this.pnlActivityHeader.ResumeLayout(false);
            this.pnlAlerts.ResumeLayout(false);
            this.pnlAlertsHeader.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Splitter splitter1;
        private Panel pnlOverview;
        private Panel pnlStatus;
        private Panel pnlActivity;
        private Panel pnlAlerts;
        private Label lblY0;
        private Label lblY10;
        private Label lblY20;
        private Label lblY30;
        private Label lblY40;
        private Label lblPctInStock;
        private Label lblDotInStock;
        private Label lblLegendInStock;
        private Label lblCountInStock;
        private Label lblDotLowStock;
        private Label lblLegendLowStock;
        private Label lblCountLowStock;
        private Label lblDotOutofStock;
        private Label lblLegendOutofStock;
        private Label lblCountOutofStock;
        private Label lblActIcon1;
        private Label lblActText1;
        private Label lblActDate1;
        private Label lblActIcon2;
        private Label lblActText2;
        private Label lblActDate2;
        private Label lblActIcon3;
        private Label lblActText3;
        private Label lblActDate3;
        private Panel lineActV;
        private Label lblAlertIcon1;
        private Label lblAlertName1;
        private Label lblAlertQty1;
        private Label lblAlertIcon2;
        private Label lblAlertName2;
        private Label lblAlertQty2;
        private Label lblAlertIcon3;
        private Label lblAlertName3;
        private Label lblAlertQty3;
        private Panel lineAlertV;
        private Panel pnlOverviewHeader;
        private Label lblOverviewTitle;
        private Panel pnlStatusHeader;
        private Label lblStatusTitle;
        private Panel pnlActivityHeader;
        private Label lblActivityTitle;
        private Panel pnlAlertsHeader;
        private Label lblAlertsTitle;
        private Label lblY50;
        private Panel panel1;
        private Label Categories;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private Label label7;
        private Panel panel7;
        private Label label1;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Panel panel14;
        private Label label2;
        private Label label8;
        private Panel panel15;
        private Label label3;
        private Panel panel16;
        private Label label11;
        private Label label4;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
