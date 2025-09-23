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
            if (GetEstadoMotor() == EstadoMotor.Encendido)
            {
                return $"El motor no se puede encender por que ya se encuentra en estado {GetEstadoMotor()}";
            }
            else
            {
                SetEstadoMotor(EstadoMotor.Encendido);
                return $"El motor el motor ha cambiado a estado {GetEstadoMotor()}";
            }



        }

        public override string Avanzar(double paKm )
        {
            if (paKm > 0)
            {
                double consumo = paKm * ConsumoPorKmGal;

                SetOdometroTotalKm(GetOdometroTotalKm() + paKm);
                combustibleActual -= consumo;
                string mensaje = $"Haz avanzado {paKm:0.00} K.M. ";
                mensaje += $"\nHaz consumido {consumo:0.00} Gal. de gasolina";
                return mensaje;
            }
            return "Los kilometros para avanzar tienen mayores a cero";
        }

        public override string Detener()
        {
            string mensaje = "";
            if (GetModoMovimiento() == ModoMovimiento.Estacionado)
            {
                SetEstadoMotor(EstadoMotor.Apagado);
                mensaje = $"El motor ha cambiado a estado de {GetEstadoMotor()}";
            }

            if (GetEstadoMotor() == EstadoMotor.Apagado)
            {
                mensaje = $"El motor ya se encuentra en estado {GetEstadoMotor()}, No se puede detener";
            }

            if (GetModoMovimiento() != ModoMovimiento.Estacionado)
            {
                mensaje = $"El motor no se puede detener porque el vechiculo se encuentra en movimiento";
            }
            
            return mensaje;
        }

        public override string Encender()
        {
            if (GetEstadoCarro() != EstadoCarro.Apagado)
                return "El vehiculo ya se encuentra encendido, no se puede enceder nuevamente";

            SetEstadoCarro(EstadoCarro.Encendido);
            return $"El vehiculo ha cambiado su estado ha {GetEstadoCarro()}";
        }

        public override string Retroceder(double paKm)
        {
            if (paKm > 0)
            {
                double consumo = paKm * ConsumoPorKmGal;

                SetOdometroTotalKm(GetOdometroTotalKm() + paKm);
                combustibleActual -= consumo;
                string mensaje = $"Haz retrocedido {paKm:0.00} K.M. ";
                mensaje += $"\nHaz consumido {consumo:0.00} Gal. de gasolina";
                return mensaje;
            }
            return "Los kilometros para retroceder tienen mayores a cero";
        }
    }
}
