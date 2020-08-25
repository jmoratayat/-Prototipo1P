namespace Bodegas_agricolas
{
    partial class FR_COMPRAS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_COMPRAS));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Bodegas_agricolas.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox2 = new System.Windows.Forms.ComboBox();
            this.lbl_examen = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deshacer = new System.Windows.Forms.Button();
            this.dgv_facturacion = new System.Windows.Forms.DataGridView();
            this.pkiddetallecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkidcompradetallecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopagocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidaddetallecompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallecompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new Bodegas_agricolas.DataSet1TableAdapters.proveedorTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Bodegas_agricolas.DataSet1TableAdapters.compraTableAdapter();
            this.detallecompraTableAdapter = new Bodegas_agricolas.DataSet1TableAdapters.detallecompraTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.proveedorBindingSource;
            this.comboBox1.DisplayMember = "nombre_proveedor";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 82;
            this.label2.Text = "Producto";
            // 
            // combobox2
            // 
            this.combobox2.DataSource = this.dataSet1;
            this.combobox2.DisplayMember = "inventario.descripcion_inventario";
            this.combobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox2.FormattingEnabled = true;
            this.combobox2.Location = new System.Drawing.Point(176, 111);
            this.combobox2.Margin = new System.Windows.Forms.Padding(4);
            this.combobox2.Name = "combobox2";
            this.combobox2.Size = new System.Drawing.Size(255, 24);
            this.combobox2.TabIndex = 79;
            // 
            // lbl_examen
            // 
            this.lbl_examen.AutoSize = true;
            this.lbl_examen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_examen.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_examen.Location = new System.Drawing.Point(470, 39);
            this.lbl_examen.Name = "lbl_examen";
            this.lbl_examen.Size = new System.Drawing.Size(87, 37);
            this.lbl_examen.TabIndex = 78;
            this.lbl_examen.Text = "fecha";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(564, 50);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fecha.Size = new System.Drawing.Size(156, 22);
            this.dtp_fecha.TabIndex = 77;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numero.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_numero.Location = new System.Drawing.Point(20, 39);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(150, 37);
            this.lbl_numero.TabIndex = 84;
            this.lbl_numero.Text = "proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 85;
            this.label1.Text = "Cantidad";
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.Image = ((System.Drawing.Image)(resources.GetObject("btn_deshacer.Image")));
            this.btn_deshacer.Location = new System.Drawing.Point(728, 289);
            this.btn_deshacer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(68, 48);
            this.btn_deshacer.TabIndex = 87;
            this.btn_deshacer.UseVisualStyleBackColor = true;
            this.btn_deshacer.Click += new System.EventHandler(this.btn_deshacer_Click);
            // 
            // dgv_facturacion
            // 
            this.dgv_facturacion.AutoGenerateColumns = false;
            this.dgv_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkiddetallecompraDataGridViewTextBoxColumn,
            this.fkidcompradetallecompraDataGridViewTextBoxColumn,
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn,
            this.tipopagocompraDataGridViewTextBoxColumn,
            this.cantidaddetallecompraDataGridViewTextBoxColumn});
            this.dgv_facturacion.DataSource = this.detallecompraBindingSource;
            this.dgv_facturacion.Location = new System.Drawing.Point(29, 289);
            this.dgv_facturacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_facturacion.Name = "dgv_facturacion";
            this.dgv_facturacion.RowHeadersWidth = 51;
            this.dgv_facturacion.Size = new System.Drawing.Size(691, 158);
            this.dgv_facturacion.TabIndex = 86;
            // 
            // pkiddetallecompraDataGridViewTextBoxColumn
            // 
            this.pkiddetallecompraDataGridViewTextBoxColumn.DataPropertyName = "pk_id_detallecompra";
            this.pkiddetallecompraDataGridViewTextBoxColumn.HeaderText = "pk_id_detallecompra";
            this.pkiddetallecompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pkiddetallecompraDataGridViewTextBoxColumn.Name = "pkiddetallecompraDataGridViewTextBoxColumn";
            this.pkiddetallecompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkidcompradetallecompraDataGridViewTextBoxColumn
            // 
            this.fkidcompradetallecompraDataGridViewTextBoxColumn.DataPropertyName = "fk_idcompra_detallecompra";
            this.fkidcompradetallecompraDataGridViewTextBoxColumn.HeaderText = "fk_idcompra_detallecompra";
            this.fkidcompradetallecompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkidcompradetallecompraDataGridViewTextBoxColumn.Name = "fkidcompradetallecompraDataGridViewTextBoxColumn";
            this.fkidcompradetallecompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkidinventariodetallecompraDataGridViewTextBoxColumn
            // 
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn.DataPropertyName = "fk_idinventario_detallecompra";
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn.HeaderText = "fk_idinventario_detallecompra";
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn.Name = "fkidinventariodetallecompraDataGridViewTextBoxColumn";
            this.fkidinventariodetallecompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipopagocompraDataGridViewTextBoxColumn
            // 
            this.tipopagocompraDataGridViewTextBoxColumn.DataPropertyName = "tipopago_compra";
            this.tipopagocompraDataGridViewTextBoxColumn.HeaderText = "tipopago_compra";
            this.tipopagocompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipopagocompraDataGridViewTextBoxColumn.Name = "tipopagocompraDataGridViewTextBoxColumn";
            this.tipopagocompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidaddetallecompraDataGridViewTextBoxColumn
            // 
            this.cantidaddetallecompraDataGridViewTextBoxColumn.DataPropertyName = "cantidad_detallecompra";
            this.cantidaddetallecompraDataGridViewTextBoxColumn.HeaderText = "cantidad_detallecompra";
            this.cantidaddetallecompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidaddetallecompraDataGridViewTextBoxColumn.Name = "cantidaddetallecompraDataGridViewTextBoxColumn";
            this.cantidaddetallecompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // detallecompraBindingSource
            // 
            this.detallecompraBindingSource.DataMember = "detallecompra";
            this.detallecompraBindingSource.DataSource = this.dataSet1;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 88;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "proveedor";
            this.proveedorBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // detallecompraTableAdapter
            // 
            this.detallecompraTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 89;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FR_COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_deshacer);
            this.Controls.Add(this.dgv_facturacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox2);
            this.Controls.Add(this.lbl_examen);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.comboBox1);
            this.Name = "FR_COMPRAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_COMPRAS";
            this.Load += new System.EventHandler(this.FR_COMPRAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox2;
        private System.Windows.Forms.Label lbl_examen;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deshacer;
        private System.Windows.Forms.DataGridView dgv_facturacion;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DataSet1TableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private DataSet1TableAdapters.compraTableAdapter compraTableAdapter;
        private System.Windows.Forms.BindingSource detallecompraBindingSource;
        private DataSet1TableAdapters.detallecompraTableAdapter detallecompraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkiddetallecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkidcompradetallecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkidinventariodetallecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopagocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidaddetallecompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}