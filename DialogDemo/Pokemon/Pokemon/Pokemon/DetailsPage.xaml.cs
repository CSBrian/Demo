using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokedexNET;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokemonto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        private PokedexNET.Pokemon _pokemonUrl;// new PokedexNET.PokemonInfo();
        public DetailsPage(PokedexNET.Pokemon pokemon)
        {
            InitializeComponent();
            var _pokedex = new Pokedex();
            _pokemonUrl = pokemon;
            var _pokemon = _pokedex.GetPokemonInfo(pokemon);
            lblName.Text = _pokemon.Names.ToString();
            lblWeight.Text = _pokemon.WeightEu.ToString();
            lblHeight.Text = _pokemon.WeightUs.ToString();
            //imgpoke.Source= ImageSource.FromUri(new Uri(_pokemon.))
            lblDescription.Text = _pokemon.Evolutions.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var url = "http://www.pokemon.com/us/pokedex/" + _pokemonUrl.Slug;
            Device.OpenUri(new Uri(url));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}