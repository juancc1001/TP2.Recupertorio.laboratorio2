using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Constructores
        public Moto(EMarca marca, string chasis, ConsoleColor color) : base (chasis, marca, color)
        {
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Las motos son chicas
        /// </summary>
        /// 
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos de la moto
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine((string)this);
            sb.Append("TAMAÑO : ");
            sb.Append(this.Tamanio.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
