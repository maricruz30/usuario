using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace usuario.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageUsuario : ContentPage
    {
        public PageUsuario()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var user = new Models.Usuario
            {
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Edad = txtEdad.Text,
                Correo = txtEmails.Text,
            };

            var page = new Views.PageResultado();
            page.BindingContext = user;
            await Navigation.PushAsync(page);

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
            txtEmails.Text = "";

        }
    }
}