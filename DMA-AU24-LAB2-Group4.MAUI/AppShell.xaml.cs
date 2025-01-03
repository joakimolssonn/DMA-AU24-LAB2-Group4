using DMA_AU24_LAB2_Group4.MAUI.Views;
namespace DMA_AU24_LAB2_Group4.MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BookingItemPage), typeof(BookingItemPage));
        }
    }
}
