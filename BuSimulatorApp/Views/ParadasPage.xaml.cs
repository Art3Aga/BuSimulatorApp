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
    public partial class ParadasPage : ContentPage
    {
        List<ListaRecorridosModel> listaParadas = new List<ListaRecorridosModel>()
        {
            //Parada 1
            new ListaRecorridosModel
            {
                nombre_parada = "Metrocentro",
                latitud = 13.462324,
                longitud = -88.165141,
                listaRutas = new List<ListaRutasModel>()
                {
                    //ITEM 1
                    new ListaRutasModel
                    { 
                        nombre_ruta = "Ruta 11",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "11:00 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "1:00 P.M." }
                        }
                    },
                }
            },
            //Parada 2
            new ListaRecorridosModel
            {
                nombre_parada = "Palo Blanco",
                latitud = 13.460908,
                longitud = -88.161179,
                listaRutas = new List<ListaRutasModel>()
                {
                    //ITEM 1
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 11",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "11:15 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "1:15 P.M." },
                        }
                    },
                }
            },
            //Parada 3
            new ListaRecorridosModel
            {
                nombre_parada = "Parque Guzman",
                latitud = 13.483152,
                longitud = -88.175336,
                listaRutas = new List<ListaRutasModel>()
                {
                    //ITEM 1
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 11",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "12:00 M.D." },
                            new ListaBusesModel { hora_llegada_a_parada = "2:00 P.M." },
                        }
                    },
                    //ITEM 2
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 2",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "07:25 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "09:25 A.M." }
                        }
                    },
                    //ITEM 3
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 90F",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "07:10 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "09:10 A.M." }
                        }
                    },
                }
            },
            //Parada 4
            new ListaRecorridosModel
            {
                nombre_parada = "Ofelia Herrera",
                latitud = 13.478018,
                longitud = -88.166585,
                listaRutas = new List<ListaRutasModel>()
                {
                    //ITEM 1
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 2",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "07:00 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "09:00 A.M." }
                        }
                    },
                }
            },
            //Parada 5
            new ListaRecorridosModel
            {
                nombre_parada = "Sarita",
                latitud = 13.477797,
                longitud = -88.174054,
                listaRutas = new List<ListaRutasModel>()
                {
                    //ITEM 1
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 2",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "07:10 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "09:10 A.M." }
                        }
                    },
                    //ITEM 2
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 90F",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "07:25 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "09:25 A.M." }
                        }
                    },
                }
            },
            //Parada 6
            new ListaRecorridosModel
            {
                nombre_parada = "UNIVO",
                latitud = 13.481888,
                longitud = -88.183634,
                listaRutas = new List<ListaRutasModel>()
                {
                    //ITEM 1
                    new ListaRutasModel
                    {
                        nombre_ruta = "Ruta 90F",
                        horario = new List<ListaBusesModel>
                        {
                            new ListaBusesModel { hora_llegada_a_parada = "07:00 A.M." },
                            new ListaBusesModel { hora_llegada_a_parada = "09:00 A.M." }
                        }
                    },
                }
            },
        };
        public ParadasPage()
        {
            InitializeComponent();
            listaViewParadas.ItemsSource = listaParadas;
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<ListaRecorridosModel> busqueda = listaParadas.Where(
                item => item.nombre_parada.Contains(txtBuscar.Text)).ToList();
            listaViewParadas.ItemsSource = busqueda;
        }

        private async void listaViewParadas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListaRecorridosModel item = e.SelectedItem as ListaRecorridosModel;
            await Navigation.PushAsync(new ParadaDetallePage(item));
        }
    }
}