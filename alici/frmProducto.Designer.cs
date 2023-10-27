namespace alici
{
    partial class frmNuevoProducto
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
            this.lblPVenta = new System.Windows.Forms.Label();
            this.lblPCompra = new System.Windows.Forms.Label();
            this.txtDescripcionP = new System.Windows.Forms.TextBox();
            this.lblDescripcionP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameProducto = new System.Windows.Forms.TextBox();
            this.lblNameP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.dgProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPVenta
            // 
            this.lblPVenta.AutoSize = true;
            this.lblPVenta.Location = new System.Drawing.Point(11, 236);
            this.lblPVenta.Name = "lblPVenta";
            this.lblPVenta.Size = new System.Drawing.Size(57, 20);
            this.lblPVenta.TabIndex = 28;
            this.lblPVenta.Text = "Precio:";
            // 
            // lblPCompra
            // 
            this.lblPCompra.AutoSize = true;
            this.lblPCompra.Location = new System.Drawing.Point(11, 220);
            this.lblPCompra.Name = "lblPCompra";
            this.lblPCompra.Size = new System.Drawing.Size(0, 20);
            this.lblPCompra.TabIndex = 27;
            // 
            // txtDescripcionP
            // 
            this.txtDescripcionP.Location = new System.Drawing.Point(186, 56);
            this.txtDescripcionP.Multiline = true;
            this.txtDescripcionP.Name = "txtDescripcionP";
            this.txtDescripcionP.Size = new System.Drawing.Size(328, 144);
            this.txtDescripcionP.TabIndex = 2;
            // 
            // lblDescripcionP
            // 
            this.lblDescripcionP.AutoSize = true;
            this.lblDescripcionP.Location = new System.Drawing.Point(11, 59);
            this.lblDescripcionP.Name = "lblDescripcionP";
            this.lblDescripcionP.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcionP.TabIndex = 26;
            this.lblDescripcionP.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 25;
            // 
            // txtNameProducto
            // 
            this.txtNameProducto.Location = new System.Drawing.Point(190, 12);
            this.txtNameProducto.Name = "txtNameProducto";
            this.txtNameProducto.Size = new System.Drawing.Size(328, 26);
            this.txtNameProducto.TabIndex = 1;
            this.txtNameProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameProducto_KeyPress);
            // 
            // lblNameP
            // 
            this.lblNameP.AutoSize = true;
            this.lblNameP.Location = new System.Drawing.Point(11, 12);
            this.lblNameP.Name = "lblNameP";
            this.lblNameP.Size = new System.Drawing.Size(162, 20);
            this.lblNameP.TabIndex = 16;
            this.lblNameP.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(190, 283);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(145, 32);
            this.btnRegistrarProducto.TabIndex = 7;
            this.btnRegistrarProducto.Text = "Registrar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(186, 236);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(328, 26);
            this.txtVenta.TabIndex = 4;
            this.txtVenta.TextChanged += new System.EventHandler(this.txtVenta_TextChanged);
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Location = new System.Drawing.Point(373, 283);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(145, 32);
            this.btnLimpiarP.TabIndex = 29;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // dgProducto
            // 
            this.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducto.Location = new System.Drawing.Point(534, 12);
            this.dgProducto.Name = "dgProducto";
            this.dgProducto.Size = new System.Drawing.Size(358, 250);
            this.dgProducto.TabIndex = 30;
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(897, 326);
            this.Controls.Add(this.dgProducto);
            this.Controls.Add(this.btnLimpiarP);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lblPVenta);
            this.Controls.Add(this.lblPCompra);
            this.Controls.Add(this.txtDescripcionP);
            this.Controls.Add(this.lblDescripcionP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameProducto);
            this.Controls.Add(this.lblNameP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo producto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPVenta;
        private System.Windows.Forms.Label lblPCompra;
        private System.Windows.Forms.TextBox txtDescripcionP;
        private System.Windows.Forms.Label lblDescripcionP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameProducto;
        private System.Windows.Forms.Label lblNameP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.DataGridView dgProducto;
    }
}