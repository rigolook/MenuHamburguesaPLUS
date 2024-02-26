using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MenuHamburguesa.Trigger
{
    public class Login : TriggerAction<Button>
    {
        protected override async void Invoke(Button button)
        {
            await button.ScaleTo(0.95, 50, Easing.CubicOut);
            await button.ScaleTo(1, 50, Easing.CubicIn);
        }
    }
}
