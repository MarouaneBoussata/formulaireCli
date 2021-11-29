namespace formulaireCli
{
    partial class formulaireClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulaireClient));
            this.choose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textnom = new System.Windows.Forms.TextBox();
            this.textprnm = new System.Windows.Forms.TextBox();
            this.textadrss = new System.Windows.Forms.TextBox();
            this.textnum = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAj = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgclient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclient)).BeginInit();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.BackColor = System.Drawing.Color.White;
            this.choose.DisplayMember = "sdfgsdfg";
            this.choose.ForeColor = System.Drawing.SystemColors.InfoText;
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "--choisissez votre ID--",
            "0110",
            "0112",
            "0113",
            "0114",
            "0115",
            "0116"});
            this.choose.Location = new System.Drawing.Point(466, 186);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(241, 23);
            this.choose.TabIndex = 0;
            this.choose.Text = "--Choisissez votre ID--";
            this.choose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(237, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id_client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textnom
            // 
            this.textnom.BackColor = System.Drawing.Color.White;
            this.textnom.Location = new System.Drawing.Point(466, 227);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(241, 23);
            this.textnom.TabIndex = 2;
            this.textnom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textprnm
            // 
            this.textprnm.BackColor = System.Drawing.Color.White;
            this.textprnm.Location = new System.Drawing.Point(466, 269);
            this.textprnm.Name = "textprnm";
            this.textprnm.Size = new System.Drawing.Size(241, 23);
            this.textprnm.TabIndex = 3;
            this.textprnm.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textadrss
            // 
            this.textadrss.AllowDrop = true;
            this.textadrss.BackColor = System.Drawing.Color.White;
            this.textadrss.Location = new System.Drawing.Point(466, 334);
            this.textadrss.Multiline = true;
            this.textadrss.Name = "textadrss";
            this.textadrss.Size = new System.Drawing.Size(241, 77);
            this.textadrss.TabIndex = 4;
            this.textadrss.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textnum
            // 
            this.textnum.BackColor = System.Drawing.Color.White;
            this.textnum.Location = new System.Drawing.Point(466, 443);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(241, 23);
            this.textnum.TabIndex = 5;
            this.textnum.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.num.ForeColor = System.Drawing.Color.Black;
            this.num.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.num.ImageKey = "(none)";
            this.num.Location = new System.Drawing.Point(237, 442);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(203, 20);
            this.num.TabIndex = 6;
            this.num.Text = "numero de telephone";
            this.num.Click += new System.EventHandler(this.label2_Click);
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.BackColor = System.Drawing.Color.Transparent;
            this.adresse.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adresse.ForeColor = System.Drawing.Color.Black;
            this.adresse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.adresse.ImageKey = "(none)";
            this.adresse.Location = new System.Drawing.Point(237, 334);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(81, 20);
            this.adresse.TabIndex = 7;
            this.adresse.Text = "Adresse";
            this.adresse.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.BackColor = System.Drawing.Color.Transparent;
            this.prenom.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenom.ForeColor = System.Drawing.Color.Black;
            this.prenom.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.prenom.ImageKey = "(none)";
            this.prenom.Location = new System.Drawing.Point(237, 283);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(76, 20);
            this.prenom.TabIndex = 8;
            this.prenom.Text = "Prenom";
            this.prenom.Click += new System.EventHandler(this.label4_Click);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.BackColor = System.Drawing.Color.Transparent;
            this.nom.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom.ForeColor = System.Drawing.Color.Black;
            this.nom.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nom.ImageKey = "(none)";
            this.nom.Location = new System.Drawing.Point(237, 235);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(49, 20);
            this.nom.TabIndex = 9;
            this.nom.Text = "Nom";
            this.nom.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(237, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // textem
            // 
            this.textem.BackColor = System.Drawing.Color.White;
            this.textem.Location = new System.Drawing.Point(466, 485);
            this.textem.Name = "textem";
            this.textem.Size = new System.Drawing.Size(241, 23);
            this.textem.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(227, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Veuillez renseigner vos information !";
            // 
            // btnMod
            // 
            this.btnMod.AllowDrop = true;
            this.btnMod.AutoSize = true;
            this.btnMod.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMod.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMod.Location = new System.Drawing.Point(255, 554);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(122, 37);
            this.btnMod.TabIndex = 14;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // btnAj
            // 
            this.btnAj.AllowDrop = true;
            this.btnAj.AutoSize = true;
            this.btnAj.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAj.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAj.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAj.Location = new System.Drawing.Point(80, 554);
            this.btnAj.Name = "btnAj";
            this.btnAj.Size = new System.Drawing.Size(122, 37);
            this.btnAj.TabIndex = 15;
            this.btnAj.Text = "Ajouter";
            this.btnAj.UseVisualStyleBackColor = false;
            this.btnAj.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // btnEn
            // 
            this.btnEn.AllowDrop = true;
            this.btnEn.AutoSize = true;
            this.btnEn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEn.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEn.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEn.Location = new System.Drawing.Point(780, 554);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(122, 37);
            this.btnEn.TabIndex = 16;
            this.btnEn.Text = "Enregister";
            this.btnEn.UseVisualStyleBackColor = false;
            this.btnEn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSup
            // 
            this.btnSup.AllowDrop = true;
            this.btnSup.AutoSize = true;
            this.btnSup.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSup.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSup.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSup.Location = new System.Drawing.Point(605, 554);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(122, 37);
            this.btnSup.TabIndex = 17;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = false;
            // 
            // btnRe
            // 
            this.btnRe.AllowDrop = true;
            this.btnRe.AutoSize = true;
            this.btnRe.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRe.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRe.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRe.Location = new System.Drawing.Point(430, 554);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(122, 37);
            this.btnRe.TabIndex = 18;
            this.btnRe.Text = "Réinitialiser";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(324, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "*\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(282, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "*\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(313, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "*\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(446, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "*\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(313, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "*\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(299, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "*\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(86, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 456);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSCRIVEZ VOUS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // quit
            // 
            this.quit.AllowDrop = true;
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quit.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quit.ForeColor = System.Drawing.Color.DarkBlue;
            this.quit.Location = new System.Drawing.Point(949, 35);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(122, 37);
            this.quit.TabIndex = 30;
            this.quit.Text = "Quitter";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(364, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "BASE DE DONNEES DE VOS CLIENTS ";
            // 
            // dgclient
            // 
            this.dgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.dataGridViewButtonColumn3});
            this.dgclient.Location = new System.Drawing.Point(237, 709);
            this.dgclient.Name = "dgclient";
            this.dgclient.RowTemplate.Height = 25;
            this.dgclient.Size = new System.Drawing.Size(643, 169);
            this.dgclient.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id_client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Adresse";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "numero";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "email";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // formulaireClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulaireCli.Properties.Resources._19024_JQC_ConcoursQUIZCarnaval_PageFormulaire_BACKGROUND;
            this.ClientSize = new System.Drawing.Size(1083, 928);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgclient);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textem);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.num);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.textadrss);
            this.Controls.Add(this.textprnm);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formulaireClient";
            this.Text = "Saisie des clients";
            this.Load += new System.EventHandler(this.formulaireClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textnom;
        private TextBox textprnm;
        private TextBox textadrss;
        private TextBox textnum;
        private Label num;
        private Label adresse;
        private Label prenom;
        private Label nom;
        private Label label2;
        private TextBox textem;
        private Label label3;
        private Button btnMod;
        private Button btnAj;
        private Button btnEn;
        private Button btnSup;
        private Button btnRe;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private GroupBox groupBox1;
        private Button quit;
        public ComboBox choose;
        private Label label4;
        private DataGridView dgclient;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}