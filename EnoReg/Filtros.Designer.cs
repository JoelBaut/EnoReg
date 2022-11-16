namespace EnoReg
{
    partial class Filtros
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
            this.cbx_registro = new System.Windows.Forms.ComboBox();
            this.dtp_dateFirst = new System.Windows.Forms.DateTimePicker();
            this.cbx_producto = new System.Windows.Forms.ComboBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.txb_destino = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtp_dateLast = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateFirst = new System.Windows.Forms.Label();
            this.lbl_dateLast = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_registro
            // 
            this.cbx_registro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_registro.FormattingEnabled = true;
            this.cbx_registro.Location = new System.Drawing.Point(59, 50);
            this.cbx_registro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_registro.Name = "cbx_registro";
            this.cbx_registro.Size = new System.Drawing.Size(355, 24);
            this.cbx_registro.TabIndex = 10;
            // 
            // dtp_dateFirst
            // 
            this.dtp_dateFirst.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_dateFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateFirst.Location = new System.Drawing.Point(151, 112);
            this.dtp_dateFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_dateFirst.Name = "dtp_dateFirst";
            this.dtp_dateFirst.Size = new System.Drawing.Size(263, 22);
            this.dtp_dateFirst.TabIndex = 20;
            // 
            // cbx_producto
            // 
            this.cbx_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_producto.FormattingEnabled = true;
            this.cbx_producto.Location = new System.Drawing.Point(151, 231);
            this.cbx_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_producto.Name = "cbx_producto";
            this.cbx_producto.Size = new System.Drawing.Size(263, 24);
            this.cbx_producto.TabIndex = 40;
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(85, 295);
            this.lbl_destino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(53, 16);
            this.lbl_destino.TabIndex = 3;
            this.lbl_destino.Text = "Destino";
            // 
            // txb_destino
            // 
            this.txb_destino.Location = new System.Drawing.Point(151, 292);
            this.txb_destino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_destino.Name = "txb_destino";
            this.txb_destino.Size = new System.Drawing.Size(263, 22);
            this.txb_destino.TabIndex = 50;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(217, 519);
            this.btn_filtrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(100, 43);
            this.btn_filtrar.TabIndex = 60;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(328, 519);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 43);
            this.btn_cerrar.TabIndex = 70;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // dtp_dateLast
            // 
            this.dtp_dateLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateLast.Location = new System.Drawing.Point(151, 165);
            this.dtp_dateLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_dateLast.Name = "dtp_dateLast";
            this.dtp_dateLast.Size = new System.Drawing.Size(263, 22);
            this.dtp_dateLast.TabIndex = 30;
            // 
            // lbl_dateFirst
            // 
            this.lbl_dateFirst.AutoSize = true;
            this.lbl_dateFirst.Location = new System.Drawing.Point(55, 121);
            this.lbl_dateFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateFirst.Name = "lbl_dateFirst";
            this.lbl_dateFirst.Size = new System.Drawing.Size(82, 16);
            this.lbl_dateFirst.TabIndex = 8;
            this.lbl_dateFirst.Text = "Fecha inicial";
            // 
            // lbl_dateLast
            // 
            this.lbl_dateLast.AutoSize = true;
            this.lbl_dateLast.Location = new System.Drawing.Point(64, 174);
            this.lbl_dateLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateLast.Name = "lbl_dateLast";
            this.lbl_dateLast.Size = new System.Drawing.Size(72, 16);
            this.lbl_dateLast.TabIndex = 9;
            this.lbl_dateLast.Text = "Fecha final";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(77, 235);
            this.lbl_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(61, 16);
            this.lbl_producto.TabIndex = 71;
            this.lbl_producto.Text = "Producto";
            // 
            // Filtros
            // 
            this.AcceptButton = this.btn_filtrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(505, 586);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.lbl_dateLast);
            this.Controls.Add(this.lbl_dateFirst);
            this.Controls.Add(this.dtp_dateLast);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.txb_destino);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.cbx_producto);
            this.Controls.Add(this.dtp_dateFirst);
            this.Controls.Add(this.cbx_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(1075, 200);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Filtros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.Filtros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_registro;
        private System.Windows.Forms.DateTimePicker dtp_dateFirst;
        private System.Windows.Forms.ComboBox cbx_producto;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.TextBox txb_destino;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DateTimePicker dtp_dateLast;
        private System.Windows.Forms.Label lbl_dateFirst;
        private System.Windows.Forms.Label lbl_dateLast;
        private System.Windows.Forms.Label lbl_producto;
    }
}