using codeAPP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace codeAPP.paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {   
        // variable
        private SQLiteAsyncConnection _connection;
        public login()
        {
            InitializeComponent();
            _connection = DependencyService.Get<Database>().GetConnection();
        }

        public static IEnumerable<usuario> Obtener_usuario(SQLiteConnection db, string usuario, string password)
        {
            return db.Query<usuario>("SELECT * FROM usuario where correo = ? and password = ?", usuario, password);
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            try
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.exc");
                var db = new SQLiteConnection(databasePath);

                db.CreateTable<usuario>();
                IEnumerable<usuario> resultado = Obtener_usuario(db, txtUser.Text, txtPass.Text);
                if (resultado.Count() > 0)
                {
                    Navigation.PushAsync(new consultaRegistro());
                }
                else
                {
                    var msj = "Verificar usuario y contraseña";
                    DependencyService.Get<mensaje>().LongAlert(msj);

                }


            }catch (Exception ex){
                var msj = ex;
                DependencyService.Get<mensaje>().LongAlert(msj.ToString());

            }
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registro());
        }
    }
}