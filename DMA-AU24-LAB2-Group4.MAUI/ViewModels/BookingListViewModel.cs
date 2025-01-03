using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DMA_AU24_LAB2_Group4.MAUI.Models;
using DMA_AU24_LAB2_Group4.MAUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.MAUI.ViewModels
{
    [ObservableObject]
    public partial class BookingListViewModel
    {
        private IBookingService _bookingService;
        [ObservableProperty]
        private ObservableCollection<Booking> bookingItems = new();
        [ObservableProperty]
        private Booking? selectedBooking;

        public BookingListViewModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [RelayCommand]
        public async Task Appearing()
        {
            BookingItems = new(await _bookingService.GetBookingAsync() ?? []);
        }

        //[RelayCommand]
        //public async Task AddBooking()
        //{
        //    var navigationParameter = new Dictionary<string, object>
        //    {
        //        { nameof(BookingItems), new Booking() { Id = Guid.NewGuid().ToString() } }
        //    };
        //    await Shell.Current.GoToAsync("BookingItemPage", navigationParameter);
        //}

        [RelayCommand]
        public async Task SelectionChanged()
        {
            if (SelectedBooking == null) return;
            var navigationParameter = new Dictionary<string, object>
            {
                { nameof(Booking), SelectedBooking }
            };
            await Shell.Current.GoToAsync("BookingItemPage", navigationParameter);
        }
    }
}
