namespace MiniPaint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Kwadrat", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Koło", 2);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Trójkąt", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Przycisk_wyjscia = new System.Windows.Forms.Button();
            this.Narzedzia = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gumka = new System.Windows.Forms.PictureBox();
            this.Kształty = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Wielkoscołowka = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.Kolory = new System.Windows.Forms.ListBox();
            this.panel_do_rys = new MiniPaint.DoubleBufferedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gumka)).BeginInit();
            this.SuspendLayout();
            // 
            // Przycisk_wyjscia
            // 
            this.Przycisk_wyjscia.BackColor = System.Drawing.Color.Red;
            this.Przycisk_wyjscia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Przycisk_wyjscia.Location = new System.Drawing.Point(12, 3);
            this.Przycisk_wyjscia.Name = "Przycisk_wyjscia";
            this.Przycisk_wyjscia.Size = new System.Drawing.Size(123, 24);
            this.Przycisk_wyjscia.TabIndex = 0;
            this.Przycisk_wyjscia.Text = "Wyjście";
            this.Przycisk_wyjscia.UseVisualStyleBackColor = false;
            this.Przycisk_wyjscia.Click += new System.EventHandler(this.Przycisk_wyjscia_Click);
            // 
            // Narzedzia
            // 
            this.Narzedzia.AutoSize = true;
            this.Narzedzia.Location = new System.Drawing.Point(207, 9);
            this.Narzedzia.Name = "Narzedzia";
            this.Narzedzia.Size = new System.Drawing.Size(54, 13);
            this.Narzedzia.TabIndex = 1;
            this.Narzedzia.Text = "Narzedzia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::MiniPaint.Properties.Resources.ołówek;
            this.pictureBox2.Location = new System.Drawing.Point(196, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // gumka
            // 
            this.gumka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gumka.Image = global::MiniPaint.Properties.Resources.gumka1;
            this.gumka.Location = new System.Drawing.Point(241, 25);
            this.gumka.Name = "gumka";
            this.gumka.Size = new System.Drawing.Size(29, 27);
            this.gumka.TabIndex = 2;
            this.gumka.TabStop = false;
            this.gumka.Click += new System.EventHandler(this.gumka_Click);
            // 
            // Kształty
            // 
            this.Kształty.AutoSize = true;
            this.Kształty.Location = new System.Drawing.Point(548, 3);
            this.Kształty.Name = "Kształty";
            this.Kształty.Size = new System.Drawing.Size(45, 13);
            this.Kształty.TabIndex = 0;
            this.Kształty.Text = "Kształty";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zmień Rozmiar Okna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wielkoscołowka
            // 
            this.Wielkoscołowka.AutoSize = true;
            this.Wielkoscołowka.Location = new System.Drawing.Point(379, 3);
            this.Wielkoscołowka.Name = "Wielkoscołowka";
            this.Wielkoscołowka.Size = new System.Drawing.Size(90, 13);
            this.Wielkoscołowka.TabIndex = 11;
            this.Wielkoscołowka.Text = "Wielkość ołowka";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(382, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(428, 19);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(382, 35);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "15";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(428, 35);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.Text = "20";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(382, 51);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 17);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.Text = "25";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(428, 52);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(37, 17);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.Text = "30";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(375, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Zmien wielkosc";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kolory
            // 
            this.Kolory.BackColor = System.Drawing.Color.LemonChiffon;
            this.Kolory.FormattingEnabled = true;
            this.Kolory.Items.AddRange(new object[] {
            "Czarny",
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Różowy",
            "Fioletowy",
            "Biały",
            "Żółty",
            "Pomarańczowy",
            "Brązowy",
            "Szary"});
            this.Kolory.Location = new System.Drawing.Point(750, 19);
            this.Kolory.Name = "Kolory";
            this.Kolory.Size = new System.Drawing.Size(116, 82);
            this.Kolory.TabIndex = 19;
            this.Kolory.SelectedIndexChanged += new System.EventHandler(this.Kolory_SelectedIndexChanged);
            // 
            // panel_do_rys
            // 
            this.panel_do_rys.BackColor = System.Drawing.Color.White;
            this.panel_do_rys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_do_rys.Location = new System.Drawing.Point(28, 107);
            this.panel_do_rys.Name = "panel_do_rys";
            this.panel_do_rys.Size = new System.Drawing.Size(1815, 784);
            this.panel_do_rys.TabIndex = 8;
            this.panel_do_rys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_do_rys_MouseDown);
            this.panel_do_rys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_do_rys_MouseMove);
            this.panel_do_rys.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_do_rys_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kolory";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(551, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(146, 82);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Figura";
            this.columnHeader2.Width = 141;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kwadracik.png");
            this.imageList1.Images.SetKeyName(1, "trójkąt.png");
            this.imageList1.Images.SetKeyName(2, "koło.png");
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(12, 61);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 23);
            this.Save.TabIndex = 22;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 895);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kolory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Wielkoscołowka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kształty);
            this.Controls.Add(this.panel_do_rys);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gumka);
            this.Controls.Add(this.Narzedzia);
            this.Controls.Add(this.Przycisk_wyjscia);
            this.Name = "Form1";
            this.Text = "+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gumka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Przycisk_wyjscia;
        private System.Windows.Forms.Label Narzedzia;
        private System.Windows.Forms.PictureBox gumka;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DoubleBufferedPanel panel_do_rys;
        private System.Windows.Forms.Label Kształty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Wielkoscołowka;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Kolory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

