using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        /// <summary>
        /// Es una lista de los posibles departamentos a los que pertenece el examen
        /// </summary>
        public enum Departamento
        {
            /// <summary>
            /// no pertenece a ningun departamento
            /// </summary>
            nulo,
            /// <summary>
            /// pertenece a la mapoteca
            /// </summary>
            mapoteca,
            /// <summary>
            /// pertenece al area de procesos técnicos
            /// </summary>
            procesosTecnicos
        }
        /// <summary>
        /// Es una lista de los tipos de documentos escaneables
        /// </summary>
        public enum TipoDoc 
        {
            /// <summary>
            /// Un documento que es un libro
            /// </summary>
            libro,
            /// <summary>
            /// Uno documento que es un mapa
            /// </summary>
            mapa
        }


        #region Atributos

        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;


        #endregion


        #region Propiedades
        /// <summary>
        /// Lista de los documentos escaneados, guarda sus estados y sus datos
        /// </summary>
        public List<Documento> ListaDocumentos
        {
            get => this.listaDocumentos;
        }

        /// <summary>
        /// Departamento al que pertenece el escaner
        /// </summary>
        public Departamento Locacion
        {
            get => this.locacion;
        }


        /// <summary>
        /// Es la marca del escaner
        /// </summary>
        public string Marca
        {
            get => this.marca;
        }


        /// <summary>
        /// Tipos de documentos escaneables
        /// </summary>
        public TipoDoc Tipo
        {
            get => this.tipo;
        }
        #endregion





        #region Constructores

        /// <summary>
        /// Construvtor del escaner
        /// </summary>
        /// <param name="marca">marca del escaner</param>
        /// <param name="tipo">tipo de documentos que escanea el escaenr</param>
        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.listaDocumentos = new List<Documento>();

            if (this.tipo == TipoDoc.libro)
            {
                this.locacion = Departamento.procesosTecnicos;
            }
            else if (this.tipo == TipoDoc.mapa) 
            {
                this.locacion = Departamento.mapoteca;
            }//PARA QUÉ SIRVE EL NULO?????????????

        }
        #endregion

        /// <summary>
        /// Incrementa el estado del documento
        /// </summary>
        /// <param name="d">documento</param>
        /// <returns></returns>
        #region Metodos
        public bool CambiarEstadoDocumento(Documento d)
        {
            bool retorno = d.AvanzarEstado();

            return retorno;
        }
        #endregion


        #region Sobrecargas


        /// <summary>
        /// Un escaner y un documento son "iguales" si en la lista de documentos del escaner se encuentra el documento
        /// </summary>
        /// <param name="e">escaner</param>
        /// <param name="d">documento</param>
        /// <returns>bool</returns>
        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;

            foreach (Documento doc in e.listaDocumentos)
            {

                

                if (d.GetType() == doc.GetType())
                {

                    if (d.GetType() == typeof(Libro))
                    {
                        Libro aux1 = (Libro)doc;
                        Libro aux2 = (Libro)d;
                        if (aux1 == aux2)
                        {
                            retorno = true;
                        }
                    }
                    else
                    {
                        Mapa aux1 = (Mapa)doc;
                        Mapa aux2 = (Mapa)d;

                        if (aux1 == aux2)
                        {
                            retorno = true;
                        }
                    }
                }
                
            }
            return retorno;
        }
        /// <summary>
        /// Un escaner y un documento son "distintos" si en la lista de documentos del escaner no se encuentra el documento
        /// </summary>
        /// <param name="e">escaner</param>
        /// <param name="d">documento</param>
        /// <returns>bool</returns>
        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }


        /// <summary>
        /// Se suma un documento a un escaner al agregarlo a la lista del escaner (solo lo hace si no se encuentra en ella anteriormente)
        /// </summary>
        /// <param name="e">escaner</param>
        /// <param name="d">documento</param>
        /// <returns>bool</returns>
        public static bool operator +(Escaner e, Documento d)
        {
            bool retorno = false;
            //Console.WriteLine(d.GetType());

            
            if ((d.GetType() == typeof(Libro) && e.locacion == Departamento.procesosTecnicos) || (d.GetType() == typeof(Mapa) && e.locacion == Departamento.mapoteca))
            {
                if (e != d && d.Estado == Documento.Paso.Inicio)
                {
                    

                    if (d.AvanzarEstado() && d.Estado == Documento.Paso.Distribuido)
                    {
                        e.ListaDocumentos.Add(d);
                        retorno = true;
                    }
                }
            }//else lanzar excepción?


            return retorno;
        }



        #endregion
    }
}
