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
    public partial class RutasPage : ContentPage
    {
        List<ListaRutasModel> listaBusitos = new List<ListaRutasModel>()
        {
            //Primer Busito
            new ListaRutasModel
            {
                nombre_ruta = "Ruta 11",
                listaParadas = new List<ListaParadasModel>
                {
                    //ITEM 1
                    new ListaParadasModel
                    {
                        nombre_parada = "Metrocentro",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "11:00 A.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Juan Perez",
                                placa = "123-321"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "1:00 P.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Juanito Alonso",
                                placa = "432-986"
                            }
                        },
                        latitud = 13.462324,
                        longitud = -88.165141
                    },
                    //ITEM 2
                    new ListaParadasModel
                    {
                        nombre_parada = "Palo Blanco",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "11:15 A.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Pepe Gomez",
                                placa = "675-345"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "1:15 P.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Jose Guzman",
                                placa = "841-423"
                            },
                        },
                        latitud = 13.460908,
                        longitud = -88.161179
                    },
                    //ITEM 3
                    new ListaParadasModel
                    {
                        nombre_parada = "Parque Guzman",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "12:00 M.D.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Miguel Hernandez",
                                placa = "102-450"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "2:00 P.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Hernan Lopez",
                                placa = "340-078"
                            },
                        },
                        latitud = 13.483152,
                        longitud = -88.175336
                    }

                },
            },
            //Segundo Busito
            new ListaRutasModel
            {
                nombre_ruta = "Ruta 2",
                listaParadas = new List<ListaParadasModel>
                {
                    //ITEM 1
                    new ListaParadasModel
                    {
                        nombre_parada = "Ofelia Herrera",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "07:00 A.M.",
                                nombre_bus = "Bus Ruta 2",
                                nombre_motorista = "Juan Perez",
                                placa = "123-321"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "09:00 A.M.",
                                nombre_bus = "Bus Ruta 2",
                                nombre_motorista = "Juanito Alonso",
                                placa = "432-986"
                            }
                        },
                        latitud = 13.478018,
                        longitud = -88.166585
                    },
                    //ITEM 2
                    new ListaParadasModel
                    {
                        nombre_parada = "Sarita",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "07:10 A.M.",
                                nombre_bus = "Bus Ruta 2",
                                nombre_motorista = "Pepe Gomez",
                                placa = "675-345"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "09:10 A.M.",
                                nombre_bus = "Bus Ruta 2",
                                nombre_motorista = "Jose Guzman",
                                placa = "841-423"
                            }
                        },
                        latitud = 13.477797,
                        longitud = -88.174054
                    },
                    //ITEM 3
                    new ListaParadasModel
                    {
                        nombre_parada = "Parque Guzman",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "07:25 A.M.",
                                nombre_bus = "Bus Ruta 2",
                                nombre_motorista = "Miguel Hernandez",
                                placa = "102-450"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "09:25 A.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Hernan Lopez",
                                placa = "340-078"
                            }
                        },
                        latitud = 13.483152,
                        longitud = -88.175336
                    }

                },
            },
            //Tercer Busito
            new ListaRutasModel
            {
                nombre_ruta = "Ruta 90F",
                listaParadas = new List<ListaParadasModel>
                {
                    //ITEM 1
                    new ListaParadasModel
                    {
                        nombre_parada = "UNIVO",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "07:00 A.M.",
                                nombre_bus = "Bus Ruta 90F",
                                nombre_motorista = "Juanito Alonso",
                                placa = "432-986"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "09:00 A.M.",
                                nombre_bus = "Bus Ruta 11",
                                nombre_motorista = "Juan Perez",
                                placa = "123-321"
                            }
                        },
                        latitud = 13.481888,
                        longitud = -88.183634
                    },
                    //ITEM 2
                    new ListaParadasModel
                    {
                        nombre_parada = "Parque Guzman",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "07:10 A.M.",
                                nombre_bus = "Bus Ruta 90F",
                                nombre_motorista = "Pepe Gomez",
                                placa = "675-345"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "09:10 A.M.",
                                nombre_bus = "Bus Ruta 90F",
                                nombre_motorista = "Jose Guzman",
                                placa = "841-423"
                            }
                        },
                        latitud = 13.483152,
                        longitud = -88.175336
                    },
                    //ITEM 3
                    new ListaParadasModel
                    {
                        nombre_parada = "Sarita",
                        horarios = new List<ListaBusesModel>
                        {
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "07:25 A.M.",
                                nombre_bus = "Bus Ruta 90F",
                                nombre_motorista = "Miguel Hernandez",
                                placa = "102-450"
                            },
                            new ListaBusesModel 
                            { 
                                hora_llegada_a_parada = "09:25 A.M.",
                                nombre_bus = "Bus Ruta 90F",
                                nombre_motorista = "Hernan Lopez",
                                placa = "340-078",
                            }
                        },
                        latitud = 13.477797,
                        longitud = -88.174054
                    }

                },
            }
        };
        public RutasPage()
        {
            InitializeComponent();
            listaViewRutas.ItemsSource = listaBusitos;
        }

        private async void listaViewRutas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListaRutasModel item = e.SelectedItem as ListaRutasModel;
            await Navigation.PushAsync(new RutaDetallePage(item));
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<ListaRutasModel> busqueda = listaBusitos.Where(item => item.nombre_ruta.Contains(txtBuscar.Text)).ToList();
            listaViewRutas.ItemsSource = busqueda;
        }
    }
}