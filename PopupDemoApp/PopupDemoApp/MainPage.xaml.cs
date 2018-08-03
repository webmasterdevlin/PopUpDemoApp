using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

namespace PopupDemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPopupTask(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new PopupNewTaskView());
        }
    }
}