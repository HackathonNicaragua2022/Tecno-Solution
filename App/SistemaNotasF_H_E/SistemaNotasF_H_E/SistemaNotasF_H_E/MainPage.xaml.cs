using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SistemaNotasF_H_E
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TxtIp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public IList<string> ListaModalidades
        {
            get
            {
                return new List<string> { "Primaria Regular","Primaria Multigrado",
                    "Secundaria Regular"};
            }
        }
        public IList<string> ListaGrado
        {
            get
            {
                return new List<string> { "Primario","Segundo","Tercero","Cuarto","Quinto","Sexto",
                "SEPTIMO","OCTAVO","NOVENO","DÉCIMO","UNDÉCIMO"};
            }
        }
        public IList<string> ListaCorte
        {
            get
            {
                return new List<string> { "Primario","Segundo","Tercero","Cuarto","Quinto","Sexto",
                "SEPTIMO","OCTAVO","NOVENO","DÉCIMO","UNDÉCIMO"};
            }
        }
        public IList<string> ListaAño
        {
            get
            {
                return new List<string> { "2021","2022","2023","2024","2025", "2026", "2027", 
                    "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"};
            }
        }



    }
}
