namespace EnoReg
{
    partial class VentanaPrinipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrinipal));
            this.dtgprincipal = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnAñadirSalida = new System.Windows.Forms.Button();
            this.btnAñadirEntrada = new System.Windows.Forms.Button();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picImagenCentro = new System.Windows.Forms.PictureBox();
            this.picImagenProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprincipal)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgprincipal
            // 
            this.dtgprincipal.AllowUserToAddRows = false;
            this.dtgprincipal.AllowUserToDeleteRows = false;
            this.dtgprincipal.AllowUserToOrderColumns = true;
            this.dtgprincipal.AllowUserToResizeColumns = false;
            this.dtgprincipal.AllowUserToResizeRows = false;
            this.dtgprincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgprincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgprincipal.Location = new System.Drawing.Point(174, 106);
            this.dtgprincipal.MultiSelect = false;
            this.dtgprincipal.Name = "dtgprincipal";
            this.dtgprincipal.ReadOnly = true;
            this.dtgprincipal.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dtgprincipal, 7);
            this.dtgprincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgprincipal.Size = new System.Drawing.Size(884, 582);
            this.dtgprincipal.TabIndex = 6;
            this.dtgprincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgprincipal_CellClick);
            this.dtgprincipal.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgprincipal_ColumnHeaderMouseClick);
            // 
            // btnNuevoProducto
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNuevoProducto, 2);
            this.btnNuevoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoProducto.Location = new System.Drawing.Point(1064, 604);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(157, 84);
            this.btnNuevoProducto.TabIndex = 5;
            this.btnNuevoProducto.Text = "NuevoProducto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnAñadirSalida
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAñadirSalida, 2);
            this.btnAñadirSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAñadirSalida.Location = new System.Drawing.Point(1064, 438);
            this.btnAñadirSalida.Name = "btnAñadirSalida";
            this.btnAñadirSalida.Size = new System.Drawing.Size(157, 77);
            this.btnAñadirSalida.TabIndex = 4;
            this.btnAñadirSalida.Text = "Añadir Salida";
            this.btnAñadirSalida.UseVisualStyleBackColor = true;
            this.btnAñadirSalida.Click += new System.EventHandler(this.btnAñadirSalida_Click);
            // 
            // btnAñadirEntrada
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAñadirEntrada, 2);
            this.btnAñadirEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAñadirEntrada.Location = new System.Drawing.Point(1064, 355);
            this.btnAñadirEntrada.Name = "btnAñadirEntrada";
            this.btnAñadirEntrada.Size = new System.Drawing.Size(157, 77);
            this.btnAñadirEntrada.TabIndex = 3;
            this.btnAñadirEntrada.Text = "Añadir Entrada";
            this.btnAñadirEntrada.UseVisualStyleBackColor = true;
            this.btnAñadirEntrada.Click += new System.EventHandler(this.btnAñadirEntrada_Click);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiltros.Location = new System.Drawing.Point(1144, 106);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(77, 77);
            this.btnFiltros.TabIndex = 2;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarTodo.Location = new System.Drawing.Point(1064, 106);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(74, 77);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Controls.Add(this.dtgprincipal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAñadirSalida, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAñadirEntrada, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMostrarTodo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFiltros, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoProducto, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.picImagenCentro, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.picImagenProducto, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 711);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EnoReg.Properties.Resources.logoDptoIndAli;
            this.pictureBox1.InitialImage = global::EnoReg.Properties.Resources.logoDptoIndAli;
            this.pictureBox1.Location = new System.Drawing.Point(1144, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picImagenCentro
            // 
            this.picImagenCentro.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picImagenCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagenCentro.ErrorImage = global::EnoReg.Properties.Resources.logoDptoIndAli;
            this.picImagenCentro.Image = global::EnoReg.Properties.Resources.logoIES;
            this.picImagenCentro.InitialImage = global::EnoReg.Properties.Resources.logoDptoIndAli;
            this.picImagenCentro.Location = new System.Drawing.Point(13, 521);
            this.picImagenCentro.Name = "picImagenCentro";
            this.tableLayoutPanel1.SetRowSpan(this.picImagenCentro, 2);
            this.picImagenCentro.Size = new System.Drawing.Size(155, 167);
            this.picImagenCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenCentro.TabIndex = 0;
            this.picImagenCentro.TabStop = false;
            // 
            // picImagenProducto
            // 
            this.picImagenProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagenProducto.Location = new System.Drawing.Point(13, 106);
            this.picImagenProducto.Name = "picImagenProducto";
            this.tableLayoutPanel1.SetRowSpan(this.picImagenProducto, 2);
            this.picImagenProducto.Size = new System.Drawing.Size(155, 160);
            this.picImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagenProducto.TabIndex = 8;
            this.picImagenProducto.TabStop = false;
            // 
            // VentanaPrinipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "VentanaPrinipal";
            this.Text = "EnoReg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentanaPrinipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgprincipal)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgprincipal;
        private System.Windows.Forms.Button btnAñadirSalida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAñadirEntrada;
        private System.Windows.Forms.PictureBox picImagenCentro;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnNuevoProducto;

        private System.Windows.Forms.PictureBox picImagenProducto;
    }
}
