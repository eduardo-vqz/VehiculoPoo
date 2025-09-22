using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculoPoo.Core.Emuns;

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
        public string LlenarTanque(double paGalones)
        {
            if (paGalones <= 0)
            {
                return "La cantidad a cargar debe ser una cantidad mayor a cero"; 
                 
            }
           
            double espacio = CapacidadTanqueGal - combustibleActual;

            if (espacio <= 0)
            {
                return "El tanque de gasolina se encuentra lleno";
            }
            else {
                double carga = Math.Clamp(paGalones, 0, espacio);
                combustibleActual += carga;
                return $"Se ha cargado {carga:0.00} galones de gasolina al tanque";
            }

        }

        //Encapsulamiento de combustible
        public double GetCombustibleActual() { return combustibleActual; }

        //Implementacion de interfaz

        public override string Apagar()
        {
            if (GetModoMovimiento() != ModoMovimiento.Estacionado || GetEstadoMotor() != EstadoMotor.Apagado) {
                return "El vehiculo debe estar no debe de estar en movimiento y con el motor apago para apagarse"; 
            }
            SetEstadoCarro(EstadoCarro.Apagado);
            return $"El vehiculo se encuentra en estado {GetEstadoCarro}";
        }

        public override string ApagarMotor()
        {
            if(GetModoMovimiento() != ModoMovimiento.Estacionado)
            {
                return $"El vechiculo esta en movimiento, no se puede apagar el motor";
            }
            SetEstadoMotor(EstadoMotor.Apagado);
            return $"El motor se a pasado a estado de {GetEstadoMotor()}";
        }

        public override string ArrancarMotor()
        {
            throw new NotImplementedException();
        }

        public override string Avanzar(double paKm)
        {
            throw new NotImplementedException();
        }

        public override string Detener()
        {
            throw new NotImplementedException();
        }

        public override string Encender()
        {
            throw new NotImplementedException();
        }

        public override string Retroceder(double paKm)
        {
            throw new NotImplementedException();
        }
    }
}
