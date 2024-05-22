using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento //hacerle un override a estos métodos que dan error
    {//COMO ES QUE LOS MAPAS NO TIENEN NUMNORMALIZADO PERO EN EL GRAFICO APARECE QUE EL CONSTRUCTOR LO TIENE??
        #region Atributos
        int alto;
        int ancho;
        #endregion
        

        #region Propiedades
        public int Alto 
        {
            get => this.alto;
        }
        public int Ancho 
        {
            get => this.ancho;
        }
        public int Superficie 
        {
        get => this.Ancho * this.Alto;
        }

        #endregion


        #region Constructor
        public Mapa(int alto, int ancho, string titulo, string autor, int anio, string numNormalizado, string barcode)
            : base(titulo, autor, anio, numNormalizado, barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        #endregion

        #region Metodos
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder constructorTexto = new StringBuilder();

            constructorTexto.Append(base.ToString() + "\n");



            constructorTexto.Append("Superficie: " + this.Alto.ToString() + " * " + this.Ancho.ToString() + " = " + this.Superficie.ToString() + " cm2" +"\n");
            //                      CREO QUE ESTO SE PUEDE HACER MÁS PITUCO, mejor
            
            return constructorTexto.ToString();
        }
        public static bool operator ==(Mapa a, Mapa b)
        {
            bool retorno = ((a.Barcode == b.Barcode) || (a.Autor == b.Autor && a.Titulo == b.Titulo && a.Anio == b.Anio && a.Superficie == b.Superficie));
            return retorno;
        }
        public static bool operator !=(Mapa a, Mapa b)
        {
            bool retorno = !(a == b);
            return retorno;
        }
        #endregion

    }
}
