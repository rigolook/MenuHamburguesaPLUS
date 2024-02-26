﻿using MenuHamburguesa.Views;
using MenuHamburguesa.Views.Pantallas;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MenuHamburguesa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nav : ContentPage
    {
        public Nav()
        {
            InitializeComponent();

        }
        private async void GoInicio(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Inicio());
        }
        private async void GoMonitoreo(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Monitoreo());
        }
        private async void GoRegistro(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Registro());
        }

        private async void configuracion_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new configuracion());
        }

        private async void cerrarsesior_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new Login());
        }

        private async void ConfiguracionSensores_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new configuracionSensores());
        }
    }
}