using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class Detailpage : ContentPage
{
	public Detailpage(DetailViewModule vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}