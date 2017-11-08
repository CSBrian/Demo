using Android.App;
using Android.Content;
using PokedexNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Pokemonto
{
    public partial class MainPage : ContentPage
    {
        private Pokedex _pokedex;
        private PokedexNET.Pokemon _pokemon;
        //Android.Content.Context context;
        public MainPage()
        {
            InitializeComponent();
            _pokedex = new Pokedex();
            _pokemon = new PokedexNET.Pokemon();
            
        }
        private void ButtonFind_Clicked(object sender, EventArgs e)
        {
            var text = txtInput.Text;
            if (string.IsNullOrEmpty(text))
            {
                lblName.Text = "Input object name!";
            }

            else if (int.TryParse(text, out int index))
            {
                if (index != 0)
                {
                    _pokemon = _pokedex.GetPokemon(index);
                    lblName.Text = _pokemon.Name;
                    imgPoke.Source = ImageSource.FromUri(new Uri(_pokemon.ImageUrl));
                }
                else
                {
                    lblName.Text = "Invalid object!";
                }

            }
        }
        private void btnViewDetail_Clicked(object sender, EventArgs e)
        {
            if (_pokemon.Slug!=null)
            {
                Navigation.PushAsync(new DetailsPage(_pokemon));
            }
        }

        private void btnExit_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Confirmation", "Are you sure!", "yes", "no");
            //AlertDialog.Builder builder = new AlertDialog.Builder();
            //builder.SetTitle("confirmation");
            //builder.SetPositiveButton("yes", (s, a) =>
            //{
            //   //Finish();
            //});
            //builder.SetNegativeButton("No", (s, a) =>
            //{
            //    builder.Dispose();
            //});
            //AlertDialog alert = builder.Create();
            //alert.Show();
        }
    }
}
