namespace ClienteWin2
{
    partial class Join
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.Empleado = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(733, 407);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 169);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(648, 290);
            this.dgvDatos.TabIndex = 1;
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(80, 52);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(75, 23);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(208, 52);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnProveedor.TabIndex = 3;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(349, 52);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(91, 23);
            this.btnOrden.TabIndex = 4;
            this.btnOrden.Text = "Detalle Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // Empleado
            // 
            this.Empleado.Location = new System.Drawing.Point(509, 52);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(75, 23);
            this.Empleado.TabIndex = 5;
            this.Empleado.Text = "Nombre";
            this.Empleado.UseVisualStyleBackColor = true;
            this.Empleado.Click += new System.EventHandler(this.Empleado_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(199, 103);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 7;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(349, 103);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProducto.TabIndex = 8;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(497, 104);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "JOIN";
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnRegresar);
            this.Name = "Join";
            this.Text = "Join";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.Button Empleado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label1;
    }
}