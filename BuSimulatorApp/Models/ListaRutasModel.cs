using System;
using System.Collections.Generic;
using System.Text;

namespace BuSimulatorApp.Models
{
    public class ListaRutasModel
    {
        public List<ListaBusesModel> horario { get; set; }
        public List<ListaParadasModel> listaParadas { get; set; }
        public string nombre_ruta { get; set; }
    }
}
