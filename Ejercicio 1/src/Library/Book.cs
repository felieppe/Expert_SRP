using System;

namespace SRP
{
    public class Book
    {
        // Información del libro:                   TÍTULO
        private string Title { get ; }
        // Información del libro:                   AUTOR
        private string Author { get ; }
        // Información del libro:                   CÓDIGO DE IDENTIFICACIÓN
        private string Code { get ;  }

        // Ubicación en la bibloteca:               SECTOR
        //public string LibrarySector { get ; set; }
        // Ubicación en la bibloteca:               ESTANTE
        //public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        
            La responsabilidad de saber en que ubicación (sector y estante) no debería de recaer en la clase Book.
            Los unicos datos importantes los cuales le corresponde a la clase Book es Title, Author y Code, los adicionales deberian de estar
            comprendidos en otra clase. Este libro conoce información que no debería de conocer.

            Propongo modificar la función ShelveBook deberia estar presentada como una clase aparte, la cual le enviariamos los datos Sector y Shelve.
            Al Book le quitariamos la responsabilidad de saber su ubicacion (el sector y la shelve) y creariamos estos dos como clases.
        
        */ 
        /*public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/

    }
}
