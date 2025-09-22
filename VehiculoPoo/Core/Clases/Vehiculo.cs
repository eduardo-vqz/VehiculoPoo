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

        //Encapsulamiento de los atributos privados
        public EstadoCarro GetEstadoCarro() { return estadoCarro; }
        public void SetEstadoCarro(EstadoCarro paEstadoCarro) 
        { 
            estadoCarro = paEstadoCarro; 
        }

        public EstadoMotor GetEstadoMotor() { return estadoMotor; }
        public void SetEstadoMotor(EstadoMotor paEstadoMotor)
        {
            estadoMotor = paEstadoMotor;
        }

        public ModoMovimiento GetModoMovimiento() { return modoMovimiento; }
        public void SetModoMovimiento(ModoMovimiento paModoMovimiento)
        {
            modoMovimiento = paModoMovimiento;
        }

        public double GetOdometroTotalKm() { return odometroTotalKm; }

        public void SetOdometroTotalKm(double paSetOdometroTotalKm)
        {
            odometroTotalKm = paSetOdometroTotalKm;
        }

        //Metodos a utilizar

        public abstract string Encender();
        public abstract string Apagar();
        public abstract string ArrancarMotor();
        public abstract string ApagarMotor();
        public abstract string Avanzar(double paKm);
        public abstract string Retroceder(double paKm);
        public abstract string Detener();

    }
}
