using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjBuscador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();//Cierro el buscador
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            WebBrowser.GoBack();//Voy a la página anterior

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pongo por defecto a Google como la web que aparece apenas cargo el formulario
            WebBrowser.Navigate("Google.com");
            TxtUrl.Text = "Https://Google.com";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String URL;//URL del buscador
            URL = TxtUrl.Text;//Guardo el URL actual
            WebBrowser.Refresh();//Refresco el WebBrowser
            TxtUrl.Text = URL;//Cargo el URL
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            String URL;//URL a cargar
            
                URL = TxtUrl.Text;//Asigno el URL a cargar
                WebBrowser.Navigate(URL);//Cargo el URL seleccionado
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            ClsCarp.ClsUsuario ObjUs = new ClsCarp.ClsUsuario();
            ClsCarp.ClsBusqueda ObjBus = new ClsCarp.ClsBusqueda();
            String URL;//URL actual
            URL = e.Url.ToString();//Guardo el URL 
            TxtUrl.Text = URL;//Cada vez que navego entre webs actualizo el URL
            ObjBus.SetURL(URL);
            ObjUs.ABusqueda(ObjBus);
            DTHist.DataSource = ObjUs.BuscarBusquedas();//Actualizo la grilla con lo buscado
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();//Redirijo hacia la siguiente web en el caso de que se haya ido hacia atrás
        }

        private void TxtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            String URL; //URL a visitar
            if ((int)(e.KeyChar) == (int)Keys.Enter) {//Si se presionó enter en la caja de texto del URL redirijo
                URL = TxtUrl.Text;//Asigno URL
                WebBrowser.Navigate(URL);//Redirijo hacia la web del URL ingresado
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            PnlHist.Visible = true;//Hago visible el panel del historial
            ClsCarp.ClsUsuario ObjUs = new ClsCarp.ClsUsuario();
            DTHist.DataSource = ObjUs.BuscarBusquedas();//Actualizo la grilla con lo buscado
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            PnlHist.Visible = false;//Oculto el panel del historial
        }
        private void DTHist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string URL;
            //Obtengo los valores insertados en la grilla según su dato correspondiente ingresado
            URL = (DTHist.Rows[e.RowIndex].Cells[0].Value.ToString());
            WebBrowser.Navigate(URL);//Busco lo seleccionado
        }
    }
}
