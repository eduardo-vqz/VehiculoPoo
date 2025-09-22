using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculoPoo.Core.Emuns;

namespace VehiculoPoo.Core.Clases
{
    internal abstract class Vehiculo
    {
        private EstadoCarro estadoCarro = EstadoCarro.Apagado;
        private EstadoMotor estadoMotor = EstadoMotor.Apagado;
        private ModoMovimiento modoMovimiento = ModoMovimiento.Estacionado;
        private double odometroTotalKm = 0;

        public EstadoCarro GetEstadoCarro() { return estadoCarro; }

        public EstadoMotor GetEstadoMotor() { return estadoMotor; }

        public ModoMovimiento GetModoMovimiento() { return modoMovimiento; }

        public double GetOdometroTotalKm() { return odometroTotalKm; }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void ArrancarMotor();
        public abstract void ApagarMotor();
        public abstract void Avanzar(double paKm);
        public abstract void Retroceder(double paKm);
        public abstract void Detener();

    }
}
