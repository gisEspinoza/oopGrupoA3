using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introduccionOOP
{
    public partial class Form1 : Form
    {
        public Form1()        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creamos la instancia de la clase Book
            //book es una instancia de la clase Book()
            //la cual permite crear objetos
            Book book = new Book();//intacia de clase Book(), meidante constructor vacio

            //creamos un objeto

            //asignar valores a las variabels de propiedad
            //a traves de los metodos de propiedad
            book.setBookId(1);
            book.setTitle("Seguridad en SGDB");
            book.setSubtitle("Seguridad de los datos");

            //asignar valores a propiedades autoimplementadas
            book._publishedYear= "2015";
            book._ISBN = "12113154787987";

            //mostrar los datos del libro
            /*MessageBox.Show(
                "Datos del Libro: " +
                   "\nID: " + book.getBookId() +
                   " \ntitulo: " + book.getTitle() +
                   " \nsubtitulo: "+ book.getSubtitle() +
                   " \npublicacion: " + book._publishedYear +
                   " \nISBN: " +  book._ISBN
                );*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //instancia de la clase utilizando constructores

            //utilizando constructor vacío
            Book book = new Book();
            book.setBookId(Convert.ToInt32(txtId.Text));
            book.setTitle(txtTitle.Text);
            book.setSubtitle(txtSubtitle.Text);
            book._publishedYear = txtPublishedYear.Text;
            book._ISBN = txtISBN.Text;

            //utilizando el constructor que inicializa todas las propiedas
            Book book1 = new Book(Convert.ToInt32(txtId.Text), 
                txtTitle.Text,txtSubtitle.Text, 
                txtPublishedYear.Text, txtISBN.Text);

            //agregar los datos a listbox
            lstBookInfo.Items.Add("Mediante constructor vacío: " +book.getBookInfo());
            lstBookInfo.Items.Add("Mediante constructor inicializando las propiedades: "+ book1.getBookInfo());
        }
    }
}
