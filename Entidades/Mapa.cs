using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento //hacerle un override a estos métodos que dan error
    {
        #region Atributos
        int alto;
        int ancho;
        #endregion


        #region Propiedades
        /// <summary>
        /// Alto del mapa en cm2.
        /// </summary>
        public int Alto
        {
            get => this.alto;
        }
        /// <summary>
        /// Ancho del mapa en cm2.
        /// </summary>
        public int Ancho
        {
            get => this.ancho;
        }

        /// <summary>
        /// Superficie del mapa (su ancho por su altura)
        /// </summary>
        public int Superficie
        {
            get => this.Ancho * this.Alto;
        }

        #endregion


        #region Constructor
        public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int ancho, int alto)
            : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        #endregion

        #region Metodos
        #endregion

        #region Sobrecargas

        /// <summary>
        /// Convierte el documento en un string que contiene el Titulo, el Autor, el Año, el Codigo de Barras y la Superficie
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder constructorTexto = new StringBuilder();

            constructorTexto.Append(base.ToString() + "\n");
            constructorTexto.Append("Cód. de barras: " + this.Barcode.ToString() + "\n");
            constructorTexto.Append("Superficie: " + this.Alto.ToString() + " * " + this.Ancho.ToString() + " = " + this.Superficie.ToString() + " cm2.\n");

            return constructorTexto.ToString();
        }

        /// <summary>
        /// Dos mapas son iguales si tienen el mismo barcode o si tienen el mismo autor, titulo, año y superficie
        /// </summary>
        /// <param name="a">Mapa a</param>
        /// <param name="b">Mapa b</param>
        /// <returns>bool</returns>
        public static bool operator ==(Mapa a, Mapa b)
        {
            bool retorno = ((a.Barcode == b.Barcode) || (a.Autor == b.Autor && a.Titulo == b.Titulo && a.Anio == b.Anio && a.Superficie == b.Superficie));
            return retorno;
        }

        /// <summary>
        /// Dos mapas son distintos si tienen distinto barcode y si tienen distinto autor, titulo, año o superficie
        /// </summary>
        /// <param name="a">Mapa a</param>
        /// <param name="b">Mapa b</param>
        /// <returns>bool</returns>
        public static bool operator !=(Mapa a, Mapa b)
        {
            bool retorno = !(a == b);
            return retorno;
        }
        #endregion

    }
}
