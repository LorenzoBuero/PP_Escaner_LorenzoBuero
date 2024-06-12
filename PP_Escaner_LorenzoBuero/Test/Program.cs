

using Entidades;


namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MI TESTEO DE LAS EXCEPCIONES
            Libro librito1 = new Libro("El quijote", "Miguel de Cerbantes", 1800, "123812381", "222222123123123", 100);
            Libro librito2 = new Libro("Fisica avanzadísima", "un tipo importante", 1979, "1", "222", 3);
            Libro librito1CopiaError = new Libro("El quijote", "Miguel de Cerbantes", 2003, "21323", "00022", 101);
            Mapa mapaError = new Mapa("mapa del tesoro", "capitán pirata", 1730, "2233", "2233223323", 30, 10);

            Escaner escanerLibrosTesteoErroees = new Escaner("cosito", Escaner.TipoDoc.libro);
            bool funca;

            try
            {
                funca = escanerLibrosTesteoErroees + librito1;
            }

            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }



            try
            {
                funca = escanerLibrosTesteoErroees + librito2;
            }

            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }


            Console.WriteLine("Este debe tirar error en el ==");
            try
            {
                funca = escanerLibrosTesteoErroees + librito1CopiaError;
            }

            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }


            Console.WriteLine("Este debe tirar error en el +");
            try
            {
                funca = escanerLibrosTesteoErroees + mapaError;
            }

            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }





            //ACÁ EMPIEZA EL TESTEO DE LA PROFE CON LAS EXCEPCIONES AGREGADAS

            // LIBROS
            // Caminos felices
            Libro l1 = new Libro("Yerma", "García Lorca, Federico", 1995, "11111", "22222", 100);
            Libro l2 = new Libro("Bodas de sangre", "García Lorca, Federico", 1997, "11112", "22223", 200);
            // Barcode repetido
            Libro l3 = new Libro("Codebar repetido", "García Lorca, Federico", 2003, "11113", "22222", 3);
            // ISBN repetido
            Libro l4 = new Libro("ISBN repetido", "García Lorca, Federico", 2003, "11112", "22224", 2);
            // Título-autor repetido
            Libro l5 = new Libro("Yerma", "García Lorca, Federico", 2003, "55555", "66666", 1);

            //MAPAS 
            // Caminos felices
            Mapa m1 = new Mapa("Buenos Aires", "Instituto Geográfico de Buenos Aires", 2005, "", "99999", 30, 15); //450
            Mapa m2 = new Mapa("Mendoza", "Instituto Geográfico de Mendoza", 2008, "", "99990", 100, 30); //300
            Mapa m3 = new Mapa("Santa Fe", "Instituto Geográfico de Santa Fe", 2010, "", "99991", 80, 30); //2400
            Mapa m4 = new Mapa("Corrientes", "Instituto Geográfico de Corrientes", 2013, "", "99992", 50, 25); //1250
                                                                                                               // Barcode repetido
            Mapa m5 = new Mapa("Barcode repetido", "Instituto Geográfico", 2015, "", "99999", 40, 15);//600
                                                                                                      // Título - autor - superficie
            Mapa m6 = new Mapa("Buenos Aires", "Instituto Geográfico de Buenos Aires", 2005, "", "99993", 30, 15);//200

            //ESCANERS
            Escaner l = new Escaner("HP", Escaner.TipoDoc.libro);
            Escaner m = new Escaner("HP", Escaner.TipoDoc.mapa);



            bool pudo;
            try { 
                pudo = l + l1;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = l + l2;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = l + l3;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = l + l4;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = l + l5;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = m + m1;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }

            try
            {
                pudo = m + m2;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }

            try
            {
                pudo = m + m3;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = m + m4;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = m + m5;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = m + m6;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = m + l1;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }
            try
            {
                pudo = l + m1;
            }
            catch (TipoIncorrectoException tiex)
            {
                Console.WriteLine(tiex.ToString());
            }

            l1.AvanzarEstado();
            l1.AvanzarEstado();
            l2.AvanzarEstado();
            l2.AvanzarEstado();
            m2.AvanzarEstado();
            m3.AvanzarEstado();
            m3.AvanzarEstado();
            m3.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();
            m4.AvanzarEstado();

            Informes.MostrarDistribuidos(l, out int extensionLibroDistr, out int cantidadLibroDistr, out string resumenLibroDistr);
            Informes.MostrarEnEscaner(l, out int extensionLibroEnEsc, out int cantidadLibroEnEsc, out string resumenLibroEnEsc);
            Informes.MostrarEnRevision(l, out int extensionLibroEnRev, out int cantidadLibroEnRev, out string resumenLibroEnRev);
            Informes.MostrarTerminados(l, out int extensionLibroTerminado, out int cantidadLibroTerminado, out string resumenLibroTerminado);

            Informes.MostrarDistribuidos(m, out int extensionMapaDistr, out int cantidadMapaDistr, out string resumenMapaDistr);
            Informes.MostrarEnEscaner(m, out int extensionMapaEnEsc, out int cantidadMapaEnEsc, out string resumenMapaEnEsc); ;
            Informes.MostrarEnRevision(m, out int extensionMapaEnRev, out int cantidadMapaEnRev, out string resumenMapaEnRev);
            Informes.MostrarTerminados(m, out int extensionMapaTerminado, out int cantidadMapaTerminado, out string resumenMapaTerminado);

            int puntos = 0;

            if (extensionLibroDistr == 0) { puntos += 3; }
            if (cantidadLibroDistr == 0) { puntos += 1; }
            if (resumenLibroDistr == "") { puntos += 1; }

            if (extensionLibroEnEsc == 0) { puntos += 3; }
            if (cantidadLibroEnEsc == 0) { puntos += 1; }
            if (resumenLibroEnEsc == "") { puntos += 1; }

            if (extensionLibroEnRev == l1.NumPaginas + l2.NumPaginas) { puntos += 3; }
            if (cantidadLibroEnRev == 2) { puntos += 1; }
            if (resumenLibroEnRev == l1.ToString() + l2.ToString()) { puntos += 1; }

            if (extensionLibroTerminado == 0) { puntos += 3; }
            if (cantidadLibroTerminado == 0) { puntos += 1; }
            if (resumenLibroTerminado == "") { puntos += 1; }

            if (extensionMapaDistr == m1.Superficie) { puntos += 3; }
            if (cantidadMapaDistr == 1) { puntos += 1; }
            if (resumenMapaDistr == m1.ToString()) { puntos += 1; }

            if (extensionMapaEnEsc == m2.Superficie) { puntos += 3; }
            if (cantidadMapaEnEsc == 1) { puntos += 1; }
            if (resumenMapaEnEsc == m2.ToString()) { puntos += 1; }

            if (extensionMapaEnRev == 0) { puntos += 3; }
            if (cantidadMapaEnRev == 0) { puntos += 1; }
            if (resumenMapaEnRev == "") { puntos += 1; }

            if (extensionMapaTerminado == m3.Superficie + m4.Superficie) { puntos += 3; }
            if (cantidadMapaTerminado == 2) { puntos += 1; }
            if (resumenMapaTerminado == m3.ToString() + m4.ToString()) { puntos += 1; }

            Console.WriteLine($"Puntos: {puntos} / 40");

            Console.WriteLine("LIBROS DISTRIBUIDOS");
            Console.WriteLine($"Cantidad de libros ya distribuidos: {cantidadLibroDistr}.");
            Console.WriteLine($"Cantidad de páginas ya distribuidas: {extensionLibroDistr}.");
            Console.WriteLine(resumenLibroDistr);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS EN ESCANER");
            Console.WriteLine($"Cantidad de libros en el escáner: {cantidadLibroEnEsc}.");
            Console.WriteLine($"Cantidad de páginas en el escáner: {extensionLibroEnEsc}.");
            Console.WriteLine(resumenLibroEnEsc);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS EN REVISIÓN");
            Console.WriteLine($"Cantidad de libros en el escáner: {cantidadLibroEnRev}.");
            Console.WriteLine($"Cantidad de páginas en el escáner: {extensionLibroEnRev}.");
            Console.WriteLine(resumenLibroEnRev);
            Console.WriteLine("---------------------");

            Console.WriteLine("LIBROS TERMINADOS");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadLibroTerminado}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionLibroTerminado}.");
            Console.WriteLine(resumenLibroTerminado);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS DISTRIBUIDOS");
            Console.WriteLine($"Cantidad de mapas ya distribuidos: {cantidadMapaDistr}.");
            Console.WriteLine($"Cantidad de cm2 ya distribuidos: {extensionMapaDistr}.");
            Console.WriteLine(resumenMapaDistr);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS EN ESCANER");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaEnEsc}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaEnEsc}.");
            Console.WriteLine(resumenMapaEnEsc);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS EN REVISIÓN");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaEnRev}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaEnRev}.");
            Console.WriteLine(resumenMapaEnRev);
            Console.WriteLine("---------------------");

            Console.WriteLine("MAPAS TERMINADOS");
            Console.WriteLine($"Cantidad de mapas en el escáner: {cantidadMapaTerminado}.");
            Console.WriteLine($"Cantidad de cm2 en el escáner: {extensionMapaTerminado}.");
            Console.WriteLine(resumenMapaTerminado);
            Console.WriteLine("---------------------");

            Console.ReadKey();
        }

    }
}
