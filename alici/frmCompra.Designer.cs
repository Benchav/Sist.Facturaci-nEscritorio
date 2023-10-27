namespace alici
{
    partial class frmCompra
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
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPCompra = new System.Windows.Forms.Label();
            this.txtDescripcionComp = new System.Windows.Forms.TextBox();
            this.lblDescripcionComp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFCompra = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFExpiracion = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.DataTCompra = new System.Windows.Forms.DateTimePicker();
            this.DataTExpiracion = new System.Windows.Forms.DateTimePicker();
            this.dgCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Location = new System.Drawing.Point(208, 397);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(153, 32);
            this.btnRegistrarCompra.TabIndex = 6;
            this.btnRegistrarCompra.Text = "Registrar Producto";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(208, 233);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(328, 26);
            this.txtCompra.TabIndex = 3;
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(33, 233);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 40;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblPCompra
            // 
            this.lblPCompra.AutoSize = true;
            this.lblPCompra.Location = new System.Drawing.Point(33, 217);
            this.lblPCompra.Name = "lblPCompra";
            this.lblPCompra.Size = new System.Drawing.Size(0, 20);
            this.lblPCompra.TabIndex = 39;
            // 
            // txtDescripcionComp
            // 
            this.txtDescripcionComp.Location = new System.Drawing.Point(208, 53);
            this.txtDescripcionComp.Multiline = true;
            this.txtDescripcionComp.Name = "txtDescripcionComp";
            this.txtDescripcionComp.Size = new System.Drawing.Size(328, 144);
            this.txtDescripcionComp.TabIndex = 2;
            // 
            // lblDescripcionComp
            // 
            this.lblDescripcionComp.AutoSize = true;
            this.lblDescripcionComp.Location = new System.Drawing.Point(33, 56);
            this.lblDescripcionComp.Name = "lblDescripcionComp";
            this.lblDescripcionComp.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcionComp.TabIndex = 38;
            this.lblDescripcionComp.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 37;
            // 
            // lblFCompra
            // 
            this.lblFCompra.AutoSize = true;
            this.lblFCompra.Location = new System.Drawing.Point(33, 300);
            this.lblFCompra.Name = "lblFCompra";
            this.lblFCompra.Size = new System.Drawing.Size(140, 20);
            this.lblFCompra.TabIndex = 36;
            this.lblFCompra.Text = "Fecha de Compra:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 35;
            this.lblCategoria.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 34;
            // 
            // lblFExpiracion
            // 
            this.lblFExpiracion.AutoSize = true;
            this.lblFExpiracion.Location = new System.Drawing.Point(33, 356);
            this.lblFExpiracion.Name = "lblFExpiracion";
            this.lblFExpiracion.Size = new System.Drawing.Size(157, 20);
            this.lblFExpiracion.TabIndex = 42;
            this.lblFExpiracion.Text = "Fecha de Expiracion:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Aceite",
            "Harina",
            "Cremas",
            "Levadura",
            "Azucar",
            "Sal",
            "Huevos",
            "Otros ingredientes"});
            this.cbCategoria.Location = new System.Drawing.Point(208, 9);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(328, 28);
            this.cbCategoria.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(383, 397);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(153, 32);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // DataTCompra
            // 
            this.DataTCompra.Location = new System.Drawing.Point(208, 300);
            this.DataTCompra.Name = "DataTCompra";
            this.DataTCompra.Size = new System.Drawing.Size(328, 26);
            this.DataTCompra.TabIndex = 44;
            // 
            // DataTExpiracion
            // 
            this.DataTExpiracion.Location = new System.Drawing.Point(208, 351);
            this.DataTExpiracion.Name = "DataTExpiracion";
            this.DataTExpiracion.Size = new System.Drawing.Size(327, 26);
            this.DataTExpiracion.TabIndex = 45;
            // 
            // dgCompra
            // 
            this.dgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompra.Location = new System.Drawing.Point(543, 9);
            this.dgCompra.Name = "dgCompra";
            this.dgCompra.Size = new System.Drawing.Size(370, 368);
            this.dgCompra.TabIndex = 46;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(926, 461);
            this.Controls.Add(this.dgCompra);
            this.Controls.Add(this.DataTExpiracion);
            this.Controls.Add(this.DataTCompra);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblFExpiracion);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPCompra);
            this.Controls.Add(this.txtDescripcionComp);
            this.Controls.Add(this.lblDescripcionComp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFCompra);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPCompra;
        private System.Windows.Forms.TextBox txtDescripcionComp;
        private System.Windows.Forms.Label lblDescripcionComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFCompra;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFExpiracion;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker DataTCompra;
        private System.Windows.Forms.DateTimePicker DataTExpiracion;
        private System.Windows.Forms.DataGridView dgCompra;
    }
}