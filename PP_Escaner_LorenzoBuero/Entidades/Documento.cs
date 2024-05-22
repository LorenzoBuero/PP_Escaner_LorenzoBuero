using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {

        /// <summary>
        /// Enum paso, representa el estado actual del documento
        /// </summary>
        public enum Paso
        
        {
            /// <summary>
            /// El socumento se encuentra en un escaner
            /// </summary>
            Inicio,
            /// <summary>
            /// El documento se encuentra esperando para ser escaneado
            /// </summary>
            Distribuido,
            /// <summary>
            /// El documento está siendo estudiando
            /// </summary>
            EnEscaner,
            /// <summary>
            /// El documento está siendo revisado para confirmar si el escaneo
            /// </summary>
            EnRevision,
            /// <summary>
            /// El documento ya fué escaneado correctamente
            /// </summary>
            Terminado
        }

        #region Atributos 

        int anio;
        string autor;
        string barcode;
        Paso estado = 0;
        string numNormalizado;
        string titulo;


        #endregion



        #region Propiedades
        /// <summary>
        /// Año de emision del documento
        /// </summary>
        public int Anio
        {
            get => this.anio;
        }

        /// <summary>
        /// Autor de la documento
        /// </summary>

        public string Autor
        {
            get => this.autor;
        }

        /// <summary>
        /// Codigo de barras del documento
        /// </summary>

        public string Barcode
        {
            get => this.barcode;
        }


        /// <summary>
        /// Estado del libro en el proceso de escaneo
        /// </summary>
        public Paso Estado
        {
            get => this.estado;
        }



        /// <summary>
        /// ID del documento
        /// </summary>
        protected string NumNormalizado
        {
            get => this.numNormalizado;
        }

        /// <summary>
        /// Titulo del documento
        /// </summary>
        public string Titulo
        {
            get => this.titulo;
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Contructor de la clase documento
        /// </summary>
        /// <param name="titulo">Titulo del documento</param>
        /// <param name="autor">Autor de la documento</param>
        /// <param name="anio">Año de emision del documento</param>
        /// <param name="numNormalizado">ID del documento</param>
        /// <param name="barcode">Codigo de barras del documento</param>
        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.barcode = barcode;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
        }

        #endregion



        #region Metodos
        /// <summary>
        /// Avanza el estado del documento al siguiente paso del proceso
        /// </summary>
        /// <returns>bool</returns>
        public bool AvanzarEstado()
        {
            bool retorno = false;

            if (this.Estado != Paso.Terminado) 
            {
                this.estado ++;
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Convierte el documento en un string que contiene el Titulo, el Autor y el Año
        /// </summary>
        /// <returns>string</returns>
        public virtual string ToString() //resolver este errorcito
        {
            StringBuilder constructorTexto = new StringBuilder();//CÓMO HAGO PARA QUE CUANDO LO HAGA EN LIBRO, LEO LOS PRIMEROS 3, DESPUES MUESTRE UNA COSA DE LIBRO Y LUEGO MUESTRE EL CUARTO???????????

            constructorTexto.Append("Titulo: " + this.Titulo.ToString() + "\n");
            constructorTexto.Append("Autor: " + this.Autor.ToString() + "\n");
            constructorTexto.Append("Año: " + this.Anio.ToString());//hace falta + "\n"???
            


            return constructorTexto.ToString();
        }
        #endregion
    }
}
