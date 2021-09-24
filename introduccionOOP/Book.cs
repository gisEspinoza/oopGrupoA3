using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccionOOP
{
    class Book
    {
        //DEFINIR LOS MIEMBROS DE LA CLASE
        //propiedades
        private int _bookId;
        private string _title;
        private string _subtitle;

        //propiedades autoimplementadas
        public string _ISBN { get; set; }
        public string _publishedYear { get; set; }


        //METODO CONSTRUCTOR
        public Book() //metodo vacío
        { }

        //soporte de sobrecarga de constructor
        public Book(int bookId, string title, string subtitle,
            string publisherYear, string ISBN)
        {
            _bookId = bookId;
            _title = title;
            _subtitle = subtitle;
            _publishedYear = publisherYear;
            _ISBN = ISBN;
        }


        //metodos de propiedad
        //get -- permite obtener el codigo de libro
        public int getBookId()
        {
            return _bookId;
        }

        //set -- permite asignar un codigo a libro
        public void setBookId(int bookId)
        {
            _bookId = bookId;
        }

        //titulo de libro
        public string getTitle()
        {
            return _title;
        }
        public void setTitle(string title)
        {
            _title = title;
        }
        //subtitulo
        public string getSubtitle()
        {
            return _subtitle;
        }
        public void setSubtitle(string subtitle)
        {
            _subtitle = subtitle;
        }

        //metodo para mostrar la informacion del libro
        public string getBookInfo()
        {
            return "ID: " + _bookId + " titulo: " + _title +
                " subtitulo: " + _subtitle + " Año: " + _publishedYear
                + " ISBN: " + _ISBN;
        }
    }
}
