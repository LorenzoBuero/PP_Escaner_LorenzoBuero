using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {
        #region Metodos   

        /// <summary>
        /// devuelve los documentos en estado "Distribuido" de la lista del escaner
        /// </summary>
        /// <param name="e"escaner></param>
        /// <param name="extension">cantidad de contenido escaneado</param>
        /// <param name="cantidad">cantidad de documentos escaneados</param>
        /// <param name="resumen">datos de los documentos escaneados</param>
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen) 
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.Distribuido, out extension, out cantidad, out resumen);      
        }

        /// <summary>
        /// devuelve los documentos en el estado seleccionado de la lista del escaner
        /// </summary>
        /// <param name="e"></param>
        /// <param name="estado"></param>
        /// <param name="extension"></param>
        /// <param name="cantidad"></param>
        /// <param name="resumen"></param>
        private static void MostrarDocumentoPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen) 
        {
            extension = 0;
            cantidad = 0;
            resumen = "";
            if (e.Tipo == Escaner.TipoDoc.libro)
            {
                foreach (Libro libro in e.ListaDocumentos)
                {
                    if (libro.Estado == estado)
                    {
                        extension += (int)libro.NumPaginas;
                        cantidad++;
                        resumen = resumen + libro.ToString();
                    }
                }
            }
            else
            {
                foreach (Mapa mapa in e.ListaDocumentos)
                {
                    if (mapa.Estado == estado)
                    {
                        extension += (int)mapa.Superficie;
                        cantidad++;
                        resumen = resumen + mapa.ToString();
                    }
                }
            }
            
        }

        /// <summary>
        /// devuelve los documentos en estado "EnEscaner" de la lista del escaner
        /// </summary>
        /// <param name="e"escaner></param>
        /// <param name="extension">cantidad de contenido escaneado</param>
        /// <param name="cantidad">cantidad de documentos escaneados</param>
        /// <param name="resumen">datos de los documentos escaneados</param>
        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }


        /// <summary>
        /// devuelve los documentos en estado "EnRevision" de la lista del escaner
        /// </summary>
        /// <param name="e"escaner></param>
        /// <param name="extension">cantidad de contenido escaneado</param>
        /// <param name="cantidad">cantidad de documentos escaneados</param>
        /// <param name="resumen">datos de los documentos escaneados</param>
        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        /// <summary>
        /// Devuelve los documentos en estado "Terminado" de la lista del escaner
        /// </summary>
        /// <param name="e"escaner></param>
        /// <param name="extension">cantidad de contenido escaneado</param>
        /// <param name="cantidad">cantidad de documentos escaneados</param>
        /// <param name="resumen">datos de los documentos escaneados</param>
        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentoPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }


        #endregion
    }
}
