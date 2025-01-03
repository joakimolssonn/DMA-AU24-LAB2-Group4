using CommunityToolkit.Maui;
using DMA_AU24_LAB2_Group4.MAUI.Services;
using Microsoft.Extensions.Logging;
using DMA_AU24_LAB2_Group4.MAUI.ViewModels;
using DMA_AU24_LAB2_Group4.MAUI.Views;

namespace DMA_AU24_LAB2_Group4.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // Services
            builder.Services.AddSingleton<IHttpsClientHandlerService, HttpsClientHandlerService>();
            builder.Services.AddSingleton<IRestService, RestService>();
            builder.Services.AddSingleton<IBookingService, BookingService>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //builder.Services.AddAutoMapper(typeof(TodoItemProfile));
            
            // Pages
            builder.Services.AddSingleton<BookingListPage>();
            builder.Services.AddTransient<BookingItemPage>();
            // ViewModels
            builder.Services.AddSingleton<BookingListViewModel>();
            builder.Services.AddTransient<BookingItemViewModel>();
            return builder.Build();
        }
    }
}
