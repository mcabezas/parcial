using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parcial
{
    class ArticuloView : UserControl
    {
        private Label Articulos;
        private TextBox idTextBox;
        private Label label1;
        private Button altaButton;
        private Button bajaButton;
        private Button editarButton;
        private TextBox descTextBox;
        private Label label2;
        private DataGridView dataGridView1;

        public ArticuloView() {
            InitializeComponent();
            dataGridView1.DataSource = createData();
        }

        private DataTable createData() {
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("DESC");
            DataRow _ravi = dt.NewRow();
            _ravi["ID"] = "1";
            _ravi["DESC"] = "DESC1";
            dt.Rows.Add(_ravi);
            DataRow _ravi2 = dt.NewRow();
            _ravi2["ID"] = "2";
            _ravi2["DESC"] = "DESC2";
            dt.Rows.Add(_ravi2);
            DataRow _ravi3 = dt.NewRow();
            _ravi3["ID"] = "3";
            _ravi3["DESC"] = "DESC3";
            dt.Rows.Add(_ravi3);
            return dt;
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Articulos = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altaButton = new System.Windows.Forms.Button();
            this.bajaButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(335, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // Articulos
            // 
            this.Articulos.AutoSize = true;
            this.Articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulos.Location = new System.Drawing.Point(90, 19);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(87, 25);
            this.Articulos.TabIndex = 1;
            this.Articulos.Text = "Articulos";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(71, 78);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // altaButton
            // 
            this.altaButton.Location = new System.Drawing.Point(24, 362);
            this.altaButton.Name = "altaButton";
            this.altaButton.Size = new System.Drawing.Size(75, 23);
            this.altaButton.TabIndex = 4;
            this.altaButton.Text = "Alta";
            this.altaButton.UseVisualStyleBackColor = true;
            // 
            // bajaButton
            // 
            this.bajaButton.Location = new System.Drawing.Point(124, 362);
            this.bajaButton.Name = "bajaButton";
            this.bajaButton.Size = new System.Drawing.Size(75, 23);
            this.bajaButton.TabIndex = 5;
            this.bajaButton.Text = "Baja";
            this.bajaButton.UseVisualStyleBackColor = true;
            this.bajaButton.Click += new System.EventHandler(this.bajaButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(223, 362);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 6;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(71, 118);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(100, 20);
            this.descTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DESC";
            // 
            // ArticuloView
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.bajaButton);
            this.Controls.Add(this.altaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.Articulos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ArticuloView";
            this.Size = new System.Drawing.Size(805, 613);
            this.Load += new System.EventHandler(this.ArticuloView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            //BE.delete(new Articulo);
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            //BE.update(new Articulo);
        }

        private void ArticuloView_Load(object sender, EventArgs e)
        {
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            descTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
