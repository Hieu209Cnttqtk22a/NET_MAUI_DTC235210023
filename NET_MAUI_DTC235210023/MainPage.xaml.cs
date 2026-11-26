using NET_MAUI_DTC235210023.ViewModel;

namespace NET_MAUI_DTC235210023
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

    }
}
