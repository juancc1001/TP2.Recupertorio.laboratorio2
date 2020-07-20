﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {

        #region enumerados
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        #endregion

        #region atributos

        EMarca marca;
        string chasis;
        ConsoleColor color;

        #endregion

        #region constructores

        protected Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }


        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
      
        protected abstract ETamanio Tamanio { get; }

        #endregion

        #region Metodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public abstract string Mostrar();

        #endregion

        #region operadores
        /// <summary>
        /// Castea el vehiculo a string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("CHASIS: ");
            sb.AppendLine(p.chasis);
            sb.Append("MARCA: ");
            sb.AppendLine(p.marca.ToString());
            sb.Append("COLOR: ");
            sb.AppendLine(p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}