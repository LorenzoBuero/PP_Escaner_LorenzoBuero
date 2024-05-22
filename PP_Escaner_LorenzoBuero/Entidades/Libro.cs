using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento //hacerle un override a estos métodos que dan error
    {
        #region Atributos
        int numPaginas;
        #endregion



        #region Propiedades
        /// <summary>
        /// Numero de paginas del libro
        /// </summary>
        public int NumPaginas
        {
            get => this.numPaginas;
        }

        /// <summary>
        /// Numero de identificacion del libro
        /// </summary>
        public string ISBN
        {
            get => this.NumNormalizado;
        }
        #endregion


        /// <summary>
        /// Constructor del libro
        /// </summary>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="autor">Autor de la libro</param>
        /// <param name="anio">Año de emision del libro</param>
        /// <param name="numNormalizado">ID del libro</param>
        /// <param name="barcode">Codigo de barras del libro</param>
        /// <param name="numPaginas">Numero de páginas del libro</param>
        #region Constructor

        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
            : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }

        #endregion

        #region Metodos
        #endregion

        #region Sobrecargas

        /// <summary>
        /// Convierte el documento en un string que contiene el Titulo, el Autor, el Año, el ISBN, el Código de barras y el numero de páginas
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder constructorTexto = new StringBuilder();

            constructorTexto.Append(base.ToString() + "\n");
            constructorTexto.Append("ISBN: " + this.ISBN.ToString() + "\n");
            constructorTexto.Append("Cód. de barras: " + this.Barcode.ToString() + "\n");
            constructorTexto.Append("Número de páginas: " + this.NumPaginas.ToString() + ".\n");

            return constructorTexto.ToString();
        }



        /// <summary>
        /// Dos libros son iguales si tienen el mismo ISBN, si el mismo barcode o si tienen el mismo autor y título
        /// </summary>
        /// <param name="a">Libro 1</param>
        /// <param name="b">Libro 2</param>
        /// <returns>bool</returns>
        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = ((a.ISBN == b.ISBN) || (a.Barcode == b.Barcode) || (a.Autor == b.Autor && a.Titulo == b.Titulo));
            return retorno;
        }

        /// <summary>
        /// Dos libros son distintos si tienen el distinto ISBN, distinto barcode y si no tienen el mismo autor o título
        /// </summary>
        /// <param name="a">Libro 1</param>
        /// <param name="b">Libro 2</param>
        /// <returns>bool</returns>
        public static bool operator !=(Libro a, Libro b)
        {
            bool retorno = !(a == b);
            return retorno;
        }
        #endregion
    }
}
