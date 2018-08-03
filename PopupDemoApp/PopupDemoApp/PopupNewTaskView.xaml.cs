using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupDemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupNewTaskView
    {
        public PopupNewTaskView()
        {
            InitializeComponent();
        }

        private void TaskEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TaskEntry.Text))
                TaskButton.IsEnabled = true;
            else if (string.IsNullOrEmpty(TaskEntry.Text))
                TaskButton.IsEnabled = false;
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }
    }
}