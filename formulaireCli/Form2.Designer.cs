namespace formulaireCli
{
    partial class datagrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.choose,
            this.nom,
            this.prnm,
            this.adrss,
            this.em,
            this.num});
            this.dataGridView1.Location = new System.Drawing.Point(45, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 66);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(172, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "BASE DE DONNEES DE VOS CLIENTS ";
            // 
            // choose
            // 
            this.choose.HeaderText = "identité client";
            this.choose.Name = "choose";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prnm
            // 
            this.prnm.HeaderText = "Prenom";
            this.prnm.Name = "prnm";
            // 
            // adrss
            // 
            this.adrss.HeaderText = "adresse";
            this.adrss.Name = "adrss";
            // 
            // em
            // 
            this.em.HeaderText = "Email";
            this.em.Name = "em";
            // 
            // num
            // 
            this.num.HeaderText = "numero de telephone";
            this.num.Name = "num";
            // 
            // datagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::formulaireCli.Properties.Resources.canva_rainbow_gradient_pink_and_purple_zoom_virtual_background__Tcjok_d9b4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "datagrid";
            this.Text = "Nosclients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label3;
        private DataGridViewTextBoxColumn choose;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn prnm;
        private DataGridViewTextBoxColumn adrss;
        private DataGridViewTextBoxColumn em;
        private DataGridViewTextBoxColumn num;
    }
}