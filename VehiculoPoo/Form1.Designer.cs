namespace VehiculoPoo
{
    partial class frmVehiculoPoo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pgbEstadoCombustible = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chkEncenderApagarVehiculo = new CheckBox();
            chkEncendidoApagadoMotor = new CheckBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            cbxMovimiento = new ComboBox();
            label7 = new Label();
            btnMover = new Button();
            label4 = new Label();
            numKilometros = new NumericUpDown();
            groupBox3 = new GroupBox();
            btnLlenarTanqueCombustible = new Button();
            lbxResuldo = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometros).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pgbEstadoCombustible
            // 
            pgbEstadoCombustible.Location = new Point(29, 56);
            pgbEstadoCombustible.Maximum = 32;
            pgbEstadoCombustible.Name = "pgbEstadoCombustible";
            pgbEstadoCombustible.Size = new Size(323, 33);
            pgbEstadoCombustible.Style = ProgressBarStyle.Continuous;
            pgbEstadoCombustible.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 30);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Estado Combustible";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(358, 63);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 2;
            label2.Text = "F";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 3;
            label3.Text = "E";
            // 
            // chkEncenderApagarVehiculo
            // 
            chkEncenderApagarVehiculo.Appearance = Appearance.Button;
            chkEncenderApagarVehiculo.AutoSize = true;
            chkEncenderApagarVehiculo.Location = new Point(126, 43);
            chkEncenderApagarVehiculo.Name = "chkEncenderApagarVehiculo";
            chkEncenderApagarVehiculo.Size = new Size(80, 30);
            chkEncenderApagarVehiculo.TabIndex = 4;
            chkEncenderApagarVehiculo.Text = "Encender";
            chkEncenderApagarVehiculo.UseVisualStyleBackColor = true;
            chkEncenderApagarVehiculo.CheckedChanged += cbxEncender_CheckedChanged;
            // 
            // chkEncendidoApagadoMotor
            // 
            chkEncendidoApagadoMotor.Appearance = Appearance.Button;
            chkEncendidoApagadoMotor.AutoSize = true;
            chkEncendidoApagadoMotor.Location = new Point(125, 95);
            chkEncendidoApagadoMotor.Name = "chkEncendidoApagadoMotor";
            chkEncendidoApagadoMotor.Size = new Size(81, 30);
            chkEncendidoApagadoMotor.TabIndex = 5;
            chkEncendidoApagadoMotor.Text = "Apagado";
            chkEncendidoApagadoMotor.TextAlign = ContentAlignment.TopCenter;
            chkEncendidoApagadoMotor.UseVisualStyleBackColor = true;
            chkEncendidoApagadoMotor.CheckedChanged += chkEncendidoApagadoMotor_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(chkEncenderApagarVehiculo);
            groupBox1.Controls.Add(chkEncendidoApagadoMotor);
            groupBox1.Location = new Point(12, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 143);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadio Vehiculo / Motor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 100);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 11;
            label6.Text = "Motor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 48);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "Vehiculo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxMovimiento);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnMover);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numKilometros);
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 215);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Movimientos Vehiculo";
            // 
            // cbxMovimiento
            // 
            cbxMovimiento.FormattingEnabled = true;
            cbxMovimiento.Location = new Point(96, 100);
            cbxMovimiento.Name = "cbxMovimiento";
            cbxMovimiento.Size = new Size(131, 28);
            cbxMovimiento.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 103);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 12;
            label7.Text = "Acción";
            // 
            // btnMover
            // 
            btnMover.Location = new Point(6, 162);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(221, 30);
            btnMover.TabIndex = 10;
            btnMover.Text = "Estacionar";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 8;
            label4.Text = "Kilometros";
            // 
            // numKilometros
            // 
            numKilometros.DecimalPlaces = 2;
            numKilometros.Location = new Point(96, 46);
            numKilometros.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numKilometros.Name = "numKilometros";
            numKilometros.Size = new Size(131, 27);
            numKilometros.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLlenarTanqueCombustible);
            groupBox3.Controls.Add(pgbEstadoCombustible);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(279, 18);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(381, 143);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Movimientos Vehiculo";
            // 
            // btnLlenarTanqueCombustible
            // 
            btnLlenarTanqueCombustible.Location = new Point(29, 95);
            btnLlenarTanqueCombustible.Name = "btnLlenarTanqueCombustible";
            btnLlenarTanqueCombustible.Size = new Size(323, 30);
            btnLlenarTanqueCombustible.TabIndex = 9;
            btnLlenarTanqueCombustible.Text = "Cargar Tanque Combustible";
            btnLlenarTanqueCombustible.UseVisualStyleBackColor = true;
            btnLlenarTanqueCombustible.Click += btnLlenarTanqueCombustible_Click;
            // 
            // lbxResuldo
            // 
            lbxResuldo.FormattingEnabled = true;
            lbxResuldo.Location = new Point(279, 185);
            lbxResuldo.Name = "lbxResuldo";
            lbxResuldo.ScrollAlwaysVisible = true;
            lbxResuldo.Size = new Size(381, 204);
            lbxResuldo.TabIndex = 12;
            // 
            // frmVehiculoPoo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(lbxResuldo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmVehiculoPoo";
            Text = "Vehiculo POO";
            Load += frmVehiculoPoo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometros).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar pgbEstadoCombustible;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chkEncenderApagarVehiculo;
        private CheckBox chkEncendidoApagadoMotor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private NumericUpDown numKilometros;
        private Button btnMover;
        private GroupBox groupBox3;
        private Button btnLlenarTanqueCombustible;
        private Label label6;
        private Label label5;
        private ListBox lbxResuldo;
        private ComboBox cbxMovimiento;
        private Label label7;
    }
}
