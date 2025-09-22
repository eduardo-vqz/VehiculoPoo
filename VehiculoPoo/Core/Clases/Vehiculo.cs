using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculoPoo.Core.Emuns;

namespace VehiculoPoo.Core.Clases
{
    internal class Vehiculo
    {
        private EstadoCarro estadoCarro;
        private EstadoMotor estadoMotor;
        private ModoMovimiento modoMovimiento;
        private double odometroTotalKm = 0;

        public EstadoCarro GetEstadoCarro() { return estadoCarro; }

        public EstadoMotor GetEstadoMotor() { return estadoMotor; }

        public ModoMovimiento GetModoMovimiento() { return modoMovimiento; }

        public double GetOdometroTotalKm() { return odometroTotalKm; }

        public void Encender()
        {

        }
        public void Apagar()
        {

        }
        public void ArrancarMotor()
        {

        }
        public void ApagarMotor()
        {

        }



        public void Avanzar(double paKm)
        {

        }

        public void Retroceder(double paKm)
        {

        }

        public void Detener()
        {

        }

    }
}
