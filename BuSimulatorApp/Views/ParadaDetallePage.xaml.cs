using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using BuSimulatorApp.Models;

namespace BuSimulatorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParadaDetallePage : ContentPage
    {
        public ParadaDetallePage(ListaRecorridosModel paradaSeleccionada)
        {
            InitializeComponent();
            Title = paradaSeleccionada.nombre_parada;
            lbltitulo.Text = $"RUTAS QUE PASAN POR '{paradaSeleccionada.nombre_parada}'";
            listaViewRutas.ItemsSource = paradaSeleccionada.listaRutas;
            MapaModel.Instancia.setPosicion(
                mapaParadaSeleccionada, paradaSeleccionada.latitud, paradaSeleccionada.longitud, 0.25
            );
            MapaModel.Instancia.addMarcador(
                mapaParadaSeleccionada, PinType.Place, paradaSeleccionada.nombre_parada, paradaSeleccionada.latitud, paradaSeleccionada.longitud
            );
        }

        private async void listaViewRutas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListaRutasModel item = e.SelectedItem as ListaRutasModel;
            await Navigation.PushAsync(new RutaParadaHorariosPage(item));
        }
    }
}