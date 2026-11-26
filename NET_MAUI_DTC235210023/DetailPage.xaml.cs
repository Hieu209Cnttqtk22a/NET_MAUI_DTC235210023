using NET_MAUI_DTC235210023.ViewModel;

namespace NET_MAUI_DTC235210023;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}