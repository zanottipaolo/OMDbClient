namespace OMDbSearch
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button_pagina_prima = new System.Windows.Forms.Button();
            this.button_pagina_dopo = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel_control = new System.Windows.Forms.Panel();
            this.label_film10 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label_film5 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label_film9 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label_film4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label_film8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label_film3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label_film7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_film2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_film6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_film1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_pageNumber = new System.Windows.Forms.Label();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Software sviluppato da Paolo Zanotti - I.T.I.S. P.Paleocapa 2020";
            // 
            // button_pagina_prima
            // 
            this.button_pagina_prima.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_pagina_prima.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_pagina_prima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pagina_prima.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pagina_prima.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_pagina_prima.Location = new System.Drawing.Point(335, 481);
            this.button_pagina_prima.Name = "button_pagina_prima";
            this.button_pagina_prima.Size = new System.Drawing.Size(55, 42);
            this.button_pagina_prima.TabIndex = 1;
            this.button_pagina_prima.Text = "<";
            this.button_pagina_prima.UseVisualStyleBackColor = false;
            this.button_pagina_prima.Click += new System.EventHandler(this.button_pagina_prima_Click);
            // 
            // button_pagina_dopo
            // 
            this.button_pagina_dopo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_pagina_dopo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_pagina_dopo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pagina_dopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pagina_dopo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_pagina_dopo.Location = new System.Drawing.Point(590, 481);
            this.button_pagina_dopo.Name = "button_pagina_dopo";
            this.button_pagina_dopo.Size = new System.Drawing.Size(55, 42);
            this.button_pagina_dopo.TabIndex = 3;
            this.button_pagina_dopo.Text = ">";
            this.button_pagina_dopo.UseVisualStyleBackColor = false;
            this.button_pagina_dopo.Click += new System.EventHandler(this.button_pagina_dopo_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(12, 23);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(199, 23);
            this.textBox_search.TabIndex = 4;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(217, 23);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Cerca";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_control.Controls.Add(this.label_film10);
            this.panel_control.Controls.Add(this.pictureBox10);
            this.panel_control.Controls.Add(this.label_film5);
            this.panel_control.Controls.Add(this.pictureBox9);
            this.panel_control.Controls.Add(this.label_film9);
            this.panel_control.Controls.Add(this.pictureBox8);
            this.panel_control.Controls.Add(this.label_film4);
            this.panel_control.Controls.Add(this.pictureBox7);
            this.panel_control.Controls.Add(this.label_film8);
            this.panel_control.Controls.Add(this.pictureBox6);
            this.panel_control.Controls.Add(this.label_film3);
            this.panel_control.Controls.Add(this.pictureBox5);
            this.panel_control.Controls.Add(this.label_film7);
            this.panel_control.Controls.Add(this.pictureBox4);
            this.panel_control.Controls.Add(this.label_film2);
            this.panel_control.Controls.Add(this.pictureBox3);
            this.panel_control.Controls.Add(this.label_film6);
            this.panel_control.Controls.Add(this.pictureBox2);
            this.panel_control.Controls.Add(this.label_film1);
            this.panel_control.Controls.Add(this.pictureBox1);
            this.panel_control.Location = new System.Drawing.Point(12, 75);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(926, 400);
            this.panel_control.TabIndex = 6;
            this.panel_control.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_control_Paint);
            // 
            // label_film10
            // 
            this.label_film10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film10.Location = new System.Drawing.Point(758, 360);
            this.label_film10.Name = "label_film10";
            this.label_film10.Size = new System.Drawing.Size(142, 29);
            this.label_film10.TabIndex = 28;
            this.label_film10.Text = "label_film10";
            this.label_film10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film10.Visible = false;
            this.label_film10.Click += new System.EventHandler(this.label_film10_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.InitialImage = null;
            this.pictureBox10.Location = new System.Drawing.Point(778, 208);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(98, 149);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            this.pictureBox10.MouseEnter += new System.EventHandler(this.pictureBox10_MouseEnter);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox10_MouseLeave);
            // 
            // label_film5
            // 
            this.label_film5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film5.Location = new System.Drawing.Point(755, 168);
            this.label_film5.Name = "label_film5";
            this.label_film5.Size = new System.Drawing.Size(145, 37);
            this.label_film5.TabIndex = 26;
            this.label_film5.Text = "label_film5";
            this.label_film5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film5.Visible = false;
            this.label_film5.Click += new System.EventHandler(this.label_film5_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.InitialImage = null;
            this.pictureBox9.Location = new System.Drawing.Point(599, 208);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(98, 149);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.MouseEnter += new System.EventHandler(this.pictureBox9_MouseEnter);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox9_MouseLeave);
            // 
            // label_film9
            // 
            this.label_film9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film9.Location = new System.Drawing.Point(578, 360);
            this.label_film9.Name = "label_film9";
            this.label_film9.Size = new System.Drawing.Size(147, 29);
            this.label_film9.TabIndex = 24;
            this.label_film9.Text = "label_film9";
            this.label_film9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film9.Visible = false;
            this.label_film9.Click += new System.EventHandler(this.label_film9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(414, 208);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(98, 149);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            this.pictureBox8.MouseEnter += new System.EventHandler(this.pictureBox8_MouseEnter);
            this.pictureBox8.MouseLeave += new System.EventHandler(this.pictureBox8_MouseLeave);
            // 
            // label_film4
            // 
            this.label_film4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film4.Location = new System.Drawing.Point(575, 168);
            this.label_film4.Name = "label_film4";
            this.label_film4.Size = new System.Drawing.Size(150, 37);
            this.label_film4.TabIndex = 22;
            this.label_film4.Text = "label_film4";
            this.label_film4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film4.Visible = false;
            this.label_film4.Click += new System.EventHandler(this.label_film4_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(229, 208);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(98, 149);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            this.pictureBox7.MouseEnter += new System.EventHandler(this.pictureBox7_MouseEnter);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pictureBox7_MouseLeave);
            // 
            // label_film8
            // 
            this.label_film8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film8.Location = new System.Drawing.Point(394, 360);
            this.label_film8.Name = "label_film8";
            this.label_film8.Size = new System.Drawing.Size(143, 29);
            this.label_film8.TabIndex = 20;
            this.label_film8.Text = "label_film8";
            this.label_film8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film8.Visible = false;
            this.label_film8.Click += new System.EventHandler(this.label_film8_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(42, 208);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 149);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            // 
            // label_film3
            // 
            this.label_film3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film3.Location = new System.Drawing.Point(391, 168);
            this.label_film3.Name = "label_film3";
            this.label_film3.Size = new System.Drawing.Size(146, 37);
            this.label_film3.TabIndex = 18;
            this.label_film3.Text = "label_film3";
            this.label_film3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film3.Visible = false;
            this.label_film3.Click += new System.EventHandler(this.label_film3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(778, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 149);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            // 
            // label_film7
            // 
            this.label_film7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film7.Location = new System.Drawing.Point(205, 360);
            this.label_film7.Name = "label_film7";
            this.label_film7.Size = new System.Drawing.Size(145, 29);
            this.label_film7.TabIndex = 16;
            this.label_film7.Text = "label_film7";
            this.label_film7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film7.Visible = false;
            this.label_film7.Click += new System.EventHandler(this.label_film7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(599, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 149);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // label_film2
            // 
            this.label_film2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film2.Location = new System.Drawing.Point(205, 168);
            this.label_film2.Name = "label_film2";
            this.label_film2.Size = new System.Drawing.Size(145, 37);
            this.label_film2.TabIndex = 14;
            this.label_film2.Text = "label_film2";
            this.label_film2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film2.Visible = false;
            this.label_film2.Click += new System.EventHandler(this.label_film2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(414, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // label_film6
            // 
            this.label_film6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film6.Location = new System.Drawing.Point(18, 360);
            this.label_film6.Name = "label_film6";
            this.label_film6.Size = new System.Drawing.Size(153, 29);
            this.label_film6.TabIndex = 12;
            this.label_film6.Text = "label_film6";
            this.label_film6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film6.Visible = false;
            this.label_film6.Click += new System.EventHandler(this.label_film6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(229, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // label_film1
            // 
            this.label_film1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_film1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_film1.Location = new System.Drawing.Point(15, 168);
            this.label_film1.Name = "label_film1";
            this.label_film1.Size = new System.Drawing.Size(156, 37);
            this.label_film1.TabIndex = 10;
            this.label_film1.Text = "label_film1";
            this.label_film1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_film1.Visible = false;
            this.label_film1.Click += new System.EventHandler(this.label_film1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(42, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(358, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtri";
            // 
            // label_pageNumber
            // 
            this.label_pageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pageNumber.Location = new System.Drawing.Point(440, 488);
            this.label_pageNumber.Name = "label_pageNumber";
            this.label_pageNumber.Size = new System.Drawing.Size(100, 31);
            this.label_pageNumber.TabIndex = 29;
            this.label_pageNumber.Text = "pages";
            this.label_pageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_pageNumber.Visible = false;
            this.label_pageNumber.Click += new System.EventHandler(this.label_pageNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(950, 555);
            this.Controls.Add(this.label_pageNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_pagina_dopo);
            this.Controls.Add(this.button_pagina_prima);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OMDbSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_pagina_prima;
        private System.Windows.Forms.Button button_pagina_dopo;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_film1;
        private System.Windows.Forms.Label label_film6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_film10;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label_film5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label_film9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label_film4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label_film8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label_film3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_film7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_film2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_pageNumber;
    }
}

