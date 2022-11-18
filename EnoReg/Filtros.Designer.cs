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
            this.cbx_registro.Location = new System.Drawing.Point(44, 41);
            this.cbx_registro.Name = "cbx_registro";
            this.cbx_registro.Size = new System.Drawing.Size(267, 21);
            this.cbx_registro.TabIndex = 10;
            // 
            // dtp_dateFirst
            // 
            this.dtp_dateFirst.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_dateFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateFirst.Location = new System.Drawing.Point(113, 91);
            this.dtp_dateFirst.Name = "dtp_dateFirst";
            this.dtp_dateFirst.Size = new System.Drawing.Size(198, 20);
            this.dtp_dateFirst.TabIndex = 20;
            // 
            // cbx_producto
            // 
            this.cbx_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_producto.FormattingEnabled = true;
            this.cbx_producto.Location = new System.Drawing.Point(113, 188);
            this.cbx_producto.Name = "cbx_producto";
            this.cbx_producto.Size = new System.Drawing.Size(198, 21);
            this.cbx_producto.TabIndex = 40;
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(64, 240);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(43, 13);
            this.lbl_destino.TabIndex = 3;
            this.lbl_destino.Text = "Destino";
            // 
            // txb_destino
            // 
            this.txb_destino.Location = new System.Drawing.Point(113, 237);
            this.txb_destino.Name = "txb_destino";
            this.txb_destino.Size = new System.Drawing.Size(198, 20);
            this.txb_destino.TabIndex = 50;
            this.txb_destino.TextChanged += new System.EventHandler(this.txb_destino_TextChanged);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(163, 422);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 35);
            this.btn_filtrar.TabIndex = 60;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.Location = new System.Drawing.Point(246, 422);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 35);
            this.btn_cerrar.TabIndex = 70;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // dtp_dateLast
            // 
            this.dtp_dateLast.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateLast.Location = new System.Drawing.Point(113, 134);
            this.dtp_dateLast.Name = "dtp_dateLast";
            this.dtp_dateLast.Size = new System.Drawing.Size(198, 20);
            this.dtp_dateLast.TabIndex = 30;
            // 
            // lbl_dateFirst
            // 
            this.lbl_dateFirst.AutoSize = true;
            this.lbl_dateFirst.Location = new System.Drawing.Point(41, 98);
            this.lbl_dateFirst.Name = "lbl_dateFirst";
            this.lbl_dateFirst.Size = new System.Drawing.Size(66, 13);
            this.lbl_dateFirst.TabIndex = 8;
            this.lbl_dateFirst.Text = "Fecha inicial";
            // 
            // lbl_dateLast
            // 
            this.lbl_dateLast.AutoSize = true;
            this.lbl_dateLast.Location = new System.Drawing.Point(48, 141);
            this.lbl_dateLast.Name = "lbl_dateLast";
            this.lbl_dateLast.Size = new System.Drawing.Size(59, 13);
            this.lbl_dateLast.TabIndex = 9;
            this.lbl_dateLast.Text = "Fecha final";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Location = new System.Drawing.Point(58, 191);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(50, 13);
            this.lbl_producto.TabIndex = 71;
            this.lbl_producto.Text = "Producto";
            // 
            // Filtros
            // 
            this.AcceptButton = this.btn_filtrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(379, 476);
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
            this.MaximizeBox = false;
            this.Name = "Filtros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filtros";
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