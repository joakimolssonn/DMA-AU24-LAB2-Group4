using DMA_AU24_LAB2_Group4.MAUI.ViewModels;

namespace DMA_AU24_LAB2_Group4.MAUI.Views;

public partial class BookingItemPage : ContentPage
{
	public BookingItemPage(BookingItemViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}