using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BuSimulatorApp.Models;

namespace BuSimulatorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RutaDetallePage : ContentPage
    {
        ListaRutasModel rutaSelect;
        string textoButton = "";
        public RutaDetallePage(ListaRutasModel rutaSeleccionada)
        {
            InitializeComponent();
            this.rutaSelect = rutaSeleccionada;
            Title = rutaSeleccionada.nombre_ruta;
            listViewParadas.ItemsSource = rutaSeleccionada.listaParadas.ToList();
            this.textoButton = $"Ver Mapa Recorrido de {rutaSeleccionada.nombre_ruta}";
            btnVerMapa.Text = this.textoButton;
        }

        private async void btnVerMapa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapaRecorridoRutaPage(this.rutaSelect));
        }

        private async void btnVer_Clicked(object sender, EventArgs e)
        {
            //var item = e.SelectedItem as ListaRutasModel;
            //await Navigation.PushAsync(new RutaParadaHorariosPage(item));
        }

        private async void listViewHorarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListaRutasModel item = e.SelectedItem as ListaRutasModel;
            //await Navigation.PushAsync(new RutaParadaHorariosPage(item));
        }
    }
}