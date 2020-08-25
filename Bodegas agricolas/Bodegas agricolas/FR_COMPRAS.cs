using System;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bodegas_agricolas
{
    public partial class FR_COMPRAS : Form
    {
        public FR_COMPRAS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FR_COMPRAS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.detallecompra' table. You can move, or remove it, as needed.
            this.detallecompraTableAdapter.Fill(this.dataSet1.detallecompra);
            // TODO: This line of code loads data into the 'dataSet1.compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.dataSet1.compra);
            // TODO: This line of code loads data into the 'dataSet1.proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.dataSet1.proveedor);
            // TODO: This line of code loads data into the 'dataSet1.DataTable' table. You can move, or remove it, as need

        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {

        }

        Conexion cn = new Conexion();

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT INTO `bodega`.`tbl_detallecompra` ( `fk_idcompra_detallecompra`, `fk_idinventario_detallecompra`, `tipopago_compra`, `cantidad_detallecompra`) VALUES ('1', 'asd', 'asdf', 'asdf', 'asdf');

         
            try
                {
                    string cadena = "INSERT INTO tbl_detallecompra ( fk_idinventario_detallecompra, tipopago_compra, cantidad_detallecompra) VALUES ('" + comboBox1.Text + "', '" + combobox2.Text + "','" + 1 + "') ;";
                    OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                    consulta.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine("Error");
                }
            
        }
    }
}
