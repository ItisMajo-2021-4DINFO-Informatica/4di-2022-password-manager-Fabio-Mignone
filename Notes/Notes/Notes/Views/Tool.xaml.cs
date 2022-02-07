using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tool : ContentPage
    {
        public Tool()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            string output;
            int lenght = 0;
            int lunghezza = 0;
            lenght = NumeroCaratteri(lunghezza);
            if(lenght == 1)
            {
                output = "ERRORE INSERIRE UN NUMERO DI CARATTERI VALIDO";
                Output.Text = output;
            }
            else
            {
                output = GeneraPassword(lenght);
                Output.Text = output;
            }
        }

        public int NumeroCaratteri(int lunghezza)
        {
            if (charone.IsChecked == true)
            {
                return lunghezza = 12; 
            }
            else if (chartwo.IsChecked == true) 
            {
                return lunghezza = 16;
            }
            else if (chartre.IsChecked == true)
            {
                return lunghezza = 20;
            }
            else if(charone.IsChecked == false & chartwo.IsChecked == false & chartre.IsChecked == false)
            {
                return lunghezza = 1;
            }
            return lunghezza = 1;
        }

        public string CaratteriSpeciali()
        {
            if(charyes.IsChecked == true)
            {
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-.*!,^|%";
            }
            else if(charno.IsChecked == true)
            {
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }
            else if(charyes.IsChecked == false & charno.IsChecked == false)
            {
                return "error";
            }
            return "error";
        }

        public string GeneraPassword(int length)
        {
            string valid = CaratteriSpeciali();
            if (valid == "error")
            {
                return "ERRORE INSERIRE UN OPZIONE VALIDA";
            }
            else
            {
                StringBuilder res = new StringBuilder();
                Random rnd = new Random();
                while (0 < length--)
                {
                    res.Append(valid[rnd.Next(valid.Length)]);
                }
                return res.ToString();
            }
        }

        private void btnsave_Clicked(object sender, EventArgs e)
        {
            string copypass = Output.Text.ToString();
            Clipboard.SetTextAsync(copypass);

        }
    }
}