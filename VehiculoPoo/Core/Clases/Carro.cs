using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculoPoo.Core.Clases
{
    internal class Carro : Vehiculo
    {
        public const double CapacidadTanqueGal = 32.0;
        public const double ConsumoPorKmGal = 0.32;

        private double combustibleActual;

        //Constructor de la clase
        public Carro(double paCombustibleInicial)
        {
            combustibleActual = Math.Clamp(paCombustibleInicial, 0, CapacidadTanqueGal);
        }

        //Encapsulamiento de combustible
        public double GetCombustibleActual() { return combustibleActual; }

        //Implementacion de interfaz

        public override void Apagar()
        {
            throw new NotImplementedException();
        }

        public override void ApagarMotor()
        {
            throw new NotImplementedException();
        }

        public override void ArrancarMotor()
        {
            throw new NotImplementedException();
        }

        public override void Avanzar(double paKm)
        {
            throw new NotImplementedException();
        }

        public override void Detener()
        {
            throw new NotImplementedException();
        }

        public override void Encender()
        {
            throw new NotImplementedException();
        }

        

        public override void Retroceder(double paKm)
        {
            throw new NotImplementedException();
        }
    }
}
