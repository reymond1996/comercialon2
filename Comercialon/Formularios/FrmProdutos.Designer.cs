namespace Comercialon.Formularios
{
    partial class FrmProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listarMarca = new System.Windows.Forms.Button();
            this.txtSiglaMarca = new System.Windows.Forms.TextBox();
            this.btnMarca = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listarCategoria = new System.Windows.Forms.Button();
            this.txtSiglaCat = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.dgvListarCategoria = new System.Windows.Forms.DataGridView();
            this._idCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nomeCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._siglaCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListarMarca = new System.Windows.Forms.DataGridView();
            this._IdMarcas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._siglaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listarMarca);
            this.groupBox1.Controls.Add(this.txtSiglaMarca);
            this.groupBox1.Controls.Add(this.btnMarca);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Location = new System.Drawing.Point(525, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listarMarca
            // 
            this.listarMarca.Location = new System.Drawing.Point(7, 96);
            this.listarMarca.Name = "listarMarca";
            this.listarMarca.Size = new System.Drawing.Size(75, 23);
            this.listarMarca.TabIndex = 5;
            this.listarMarca.Text = "Listar1";
            this.listarMarca.UseVisualStyleBackColor = true;
            this.listarMarca.Click += new System.EventHandler(this.listarMarca_Click);
            // 
            // txtSiglaMarca
            // 
            this.txtSiglaMarca.Location = new System.Drawing.Point(6, 70);
            this.txtSiglaMarca.Name = "txtSiglaMarca";
            this.txtSiglaMarca.Size = new System.Drawing.Size(80, 20);
            this.txtSiglaMarca.TabIndex = 4;
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(106, 96);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(75, 23);
            this.btnMarca.TabIndex = 0;
            this.btnMarca.Text = "InserirM";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 35);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(175, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listarCategoria);
            this.groupBox2.Controls.Add(this.txtSiglaCat);
            this.groupBox2.Controls.Add(this.txtCat);
            this.groupBox2.Controls.Add(this.btnCategoria);
            this.groupBox2.Location = new System.Drawing.Point(524, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria";
            // 
            // listarCategoria
            // 
            this.listarCategoria.Location = new System.Drawing.Point(7, 103);
            this.listarCategoria.Name = "listarCategoria";
            this.listarCategoria.Size = new System.Drawing.Size(75, 23);
            this.listarCategoria.TabIndex = 4;
            this.listarCategoria.Text = "Listar2";
            this.listarCategoria.UseVisualStyleBackColor = true;
            // 
            // txtSiglaCat
            // 
            this.txtSiglaCat.Location = new System.Drawing.Point(7, 74);
            this.txtSiglaCat.Name = "txtSiglaCat";
            this.txtSiglaCat.Size = new System.Drawing.Size(80, 20);
            this.txtSiglaCat.TabIndex = 3;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(7, 37);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(175, 20);
            this.txtCat.TabIndex = 2;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(107, 103);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "InserirC";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // dgvListarCategoria
            // 
            this.dgvListarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._idCat,
            this._nomeCat,
            this._siglaCat});
            this.dgvListarCategoria.Location = new System.Drawing.Point(40, 261);
            this.dgvListarCategoria.Name = "dgvListarCategoria";
            this.dgvListarCategoria.Size = new System.Drawing.Size(421, 136);
            this.dgvListarCategoria.TabIndex = 3;
            // 
            // _idCat
            // 
            this._idCat.Frozen = true;
            this._idCat.HeaderText = "ID";
            this._idCat.Name = "_idCat";
            this._idCat.ReadOnly = true;
            // 
            // _nomeCat
            // 
            this._nomeCat.Frozen = true;
            this._nomeCat.HeaderText = "Nome";
            this._nomeCat.Name = "_nomeCat";
            this._nomeCat.ReadOnly = true;
            this._nomeCat.Width = 180;
            // 
            // _siglaCat
            // 
            this._siglaCat.Frozen = true;
            this._siglaCat.HeaderText = "Sigla";
            this._siglaCat.Name = "_siglaCat";
            this._siglaCat.ReadOnly = true;
            // 
            // dgvListarMarca
            // 
            this.dgvListarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IdMarcas,
            this._NomeMarca,
            this._siglaMarca});
            this.dgvListarMarca.Location = new System.Drawing.Point(40, 55);
            this.dgvListarMarca.Name = "dgvListarMarca";
            this.dgvListarMarca.Size = new System.Drawing.Size(421, 150);
            this.dgvListarMarca.TabIndex = 2;
            this.dgvListarMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarMarca_CellContentClick);
            // 
            // _IdMarcas
            // 
            this._IdMarcas.Frozen = true;
            this._IdMarcas.HeaderText = "ID";
            this._IdMarcas.Name = "_IdMarcas";
            this._IdMarcas.ReadOnly = true;
            // 
            // _NomeMarca
            // 
            this._NomeMarca.Frozen = true;
            this._NomeMarca.HeaderText = "Nome";
            this._NomeMarca.Name = "_NomeMarca";
            this._NomeMarca.ReadOnly = true;
            this._NomeMarca.Width = 180;
            // 
            // _siglaMarca
            // 
            this._siglaMarca.Frozen = true;
            this._siglaMarca.HeaderText = "Sigla";
            this._siglaMarca.Name = "_siglaMarca";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarCategoria);
            this.Controls.Add(this.dgvListarMarca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSiglaMarca;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSiglaCat;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button listarMarca;
        private System.Windows.Forms.Button listarCategoria;
        private System.Windows.Forms.DataGridView dgvListarCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nomeCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn _siglaCat;
        private System.Windows.Forms.DataGridView dgvListarMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IdMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NomeMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn _siglaMarca;
    }
}