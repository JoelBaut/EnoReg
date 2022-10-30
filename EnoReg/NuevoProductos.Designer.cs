namespace EnoReg
{
    partial class NuevoProductos
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_imagen = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pcb_imagen = new System.Windows.Forms.PictureBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_unidad = new System.Windows.Forms.TextBox();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.fil_explorar = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(70, 30);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(70, 82);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(41, 13);
            this.lbl_unidad.TabIndex = 1;
            this.lbl_unidad.Text = "Unidad";
            // 
            // lbl_imagen
            // 
            this.lbl_imagen.AutoSize = true;
            this.lbl_imagen.Location = new System.Drawing.Point(73, 135);
            this.lbl_imagen.Name = "lbl_imagen";
            this.lbl_imagen.Size = new System.Drawing.Size(41, 13);
            this.lbl_imagen.TabIndex = 2;
            this.lbl_imagen.Text = "imagen";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(54, 339);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 35);
            this.btn_aceptar.TabIndex = 40;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(147, 339);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 35);
            this.btn_cancelar.TabIndex = 50;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // pcb_imagen
            // 
            this.pcb_imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_imagen.Location = new System.Drawing.Point(73, 163);
            this.pcb_imagen.Name = "pcb_imagen";
            this.pcb_imagen.Size = new System.Drawing.Size(132, 126);
            this.pcb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_imagen.TabIndex = 5;
            this.pcb_imagen.TabStop = false;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(121, 30);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(84, 20);
            this.txb_Nombre.TabIndex = 10;
            // 
            // txb_unidad
            // 
            this.txb_unidad.Location = new System.Drawing.Point(118, 74);
            this.txb_unidad.Name = "txb_unidad";
            this.txb_unidad.Size = new System.Drawing.Size(87, 20);
            this.txb_unidad.TabIndex = 20;
            // 
            // btn_imagen
            // 
            this.btn_imagen.Location = new System.Drawing.Point(157, 131);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(48, 21);
            this.btn_imagen.TabIndex = 30;
            this.btn_imagen.Text = "buscar";
            this.btn_imagen.UseVisualStyleBackColor = true;
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            // 
            // NuevoProductos
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(299, 398);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.txb_unidad);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.pcb_imagen);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_imagen);
            this.Controls.Add(this.lbl_unidad);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NuevoProductos";
            this.Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_imagen;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.PictureBox pcb_imagen;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_unidad;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.OpenFileDialog fil_explorar;
    }
}