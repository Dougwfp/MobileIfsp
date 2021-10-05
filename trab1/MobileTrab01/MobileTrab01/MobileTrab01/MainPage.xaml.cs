using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileTrab01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Ok_Clicked(object sender, EventArgs e)
        {
            if (login.Text == "admin" && senha.Text == "senha@admin")
            {
                DisplayAlert("Mensagem", "Logado com Sucesso", "OK");
            }
            else
            {
                DisplayAlert("Mensagem", "Ling não Autorizado", "OK");
            }
        }

        private void Limpar_Clicked(object sender, EventArgs e)
        {
            login.Text = "";
            senha.Text = "";
        }

        private void Cred_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Creditos", " Douglas Willian CB3005348 e João Vitor Gino CB3005488 ", "OK");
        }
    }
}
