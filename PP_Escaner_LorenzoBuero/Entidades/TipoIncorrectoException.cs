using System;
using System.Text;


namespace Entidades
{
    public class TipoIncorrectoException : Exception
    {

        #region Atributos
        string nombreClase;
        string nombreMetodo;
        #endregion

        #region Metodos
        public string NombreClase 
        {
            get => nombreClase; 
        }

        public string NombreMetodo
        {
            get => nombreMetodo;
        }
        #endregion


        #region Constructor
        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;

        }

        public TipoIncorrectoException(string mensaje, string nombreClase, string nombreMetodo) 
            : this(mensaje, nombreClase, nombreMetodo, new Exception()) { }

        #endregion

        #region Sobrecargas

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"\nExcepción en el método {NombreMetodo} de la clase {NombreClase}.\n");
            strb.Append("Algo salió mal, revisa los detalles.\n");
            strb.Append($"Detalles: {this.InnerException}.\n");

            return strb.ToString();
        }

        #endregion
    }
}
