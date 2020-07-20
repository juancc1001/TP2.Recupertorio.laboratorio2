using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        #region atributos

        public enum ETipo { Monovolumen, Sedan }
        ETipo tipo;

        #endregion

        #region constructores

        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color, ETipo.Monovolumen)
        {
        }

        public Automovil(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base (chasis, marca, color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region propiedades

        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region metodos
        /// <summary>
        /// Muestra los datos del automovil
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine((string)this);
            sb.Append("TAMAÑO : ");
            sb.AppendLine(this.Tamanio.ToString());
            sb.Append("TIPO : ");
            sb.AppendLine(this.tipo.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
