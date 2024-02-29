
using MenuHamburguesa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuHamburguesa.ViewModel
{
    public class VMhistorial : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        List<MHistorial> Registros;

        //list provicional
        
        #endregion
        #region OBJETOS
        public List<MHistorial> Lista
        {
            get { return Registros; }
            set
            {
                SetValue(ref Registros, value);
                OnpropertyChanged();

            }
        }
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
        #region CONTRUCTOR
        public VMhistorial(INavigation navigation)
        {
            Navigation = navigation;

            Registros = new List<MHistorial>
            {
                new MHistorial { Ubicacion = "Cocina", FechaHora ="24/02/2024",Temperatura="25°",NombreGas="Oxigeno",GasDetectado="No",RPM="30"},
                new MHistorial { Ubicacion = "Cocina", FechaHora ="24/02/2024",Temperatura="25°",NombreGas="Oxigeno",GasDetectado="No",RPM="30"}
            };
        }
        #endregion
    }
}
