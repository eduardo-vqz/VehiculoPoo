using VehiculoPoo.Core.Clases;
using VehiculoPoo.Core.Emuns;

namespace VehiculoPoo
{
    public partial class frmVehiculoPoo : Form
    {

        Carro carro = new Carro(32);
        public frmVehiculoPoo()
        {
            InitializeComponent();

            //Cargamos datos a nuestro ProgressBard
            pgbEstadoCombustible.Value = (int)Math.Ceiling(carro.GetCombustibleActual());

            // Cargamos los datos en el combobox
            cbxMovimiento.DataSource = Enum.GetValues(typeof(ModoMovimiento));
            cbxMovimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMovimiento.SelectedIndex = -1;

            // Cargamos el checkbox con los datos de la clase inicialmente apagado
            chkEncenderApagarVehiculo.ThreeState = false;
            carro.SetEstadoCarro(EstadoCarro.Apagado);
            chkEncenderApagarVehiculo.Text = carro.GetEstadoCarro().ToString();

            // Cargamos el checkbox con los datos de la clase inicialmente apagado ya rranque de motor
            chkEncendidoApagadoMotor.ThreeState = false;
            carro.SetEstadoMotor(EstadoMotor.Apagado);
            chkEncendidoApagadoMotor.Text = carro.GetEstadoMotor().ToString();
        }

        private void cbxEncender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEncenderApagarVehiculo.Checked)
            {
                lbxResuldo.Items.Add(carro.Encender().ToString());
                chkEncenderApagarVehiculo.Text = carro.GetEstadoCarro().ToString();
            }
            else
            {
                lbxResuldo.Items.Add(carro.Apagar().ToString());
                chkEncenderApagarVehiculo.Text = carro.GetEstadoCarro().ToString();
            }

        }

        private void frmVehiculoPoo_Load(object sender, EventArgs e)
        {

        }

        private void chkEncendidoApagadoMotor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEncendidoApagadoMotor.Checked)
            {
                lbxResuldo.Items.Add(carro.ArrancarMotor().ToString());
                chkEncendidoApagadoMotor.Text = carro.GetEstadoMotor().ToString();
            }
            else
            {
                lbxResuldo.Items.Add(carro.ApagarMotor().ToString());
                chkEncendidoApagadoMotor.Text = carro.GetEstadoMotor().ToString();
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (cbxMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una opción de movimiento");
                return;
            }

            var movimiento = (ModoMovimiento)cbxMovimiento.SelectedItem;

            switch (movimiento)
            {
                case ModoMovimiento.Estacionado:
                    
                    lbxResuldo.Items.Add(carro.Detener());
                    break;
                case ModoMovimiento.Adelante:
                    lbxResuldo.Items.Add($"{carro.Avanzar(double.Parse(numKilometros.Value.ToString()))}");
                    lbxResuldo.Items.Add($"El vehiculo ha cambiado a estado de {carro.GetModoMovimiento()}");
                    pgbEstadoCombustible.Value = (int)Math.Ceiling(carro.GetCombustibleActual());

                    break;
                case ModoMovimiento.Retroceso:
                    lbxResuldo.Items.Add($"{carro.Retroceder(double.Parse(numKilometros.Value.ToString()))}");
                    lbxResuldo.Items.Add($"El vehiculo ha cambiado a estado de {carro.GetModoMovimiento()}");
                    pgbEstadoCombustible.Value = (int)Math.Ceiling(carro.GetCombustibleActual());

                    break;

            }


        }

        private void btnLlenarTanqueCombustible_Click(object sender, EventArgs e)
        {
            lbxResuldo.Items.Add( carro.LlenarTanque(32));
            pgbEstadoCombustible.Value = (int)Math.Ceiling(carro.GetCombustibleActual());
        }
    }
}
