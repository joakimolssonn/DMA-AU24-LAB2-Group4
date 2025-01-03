using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DMA_AU24_LAB2_Group4.MAUI.Models;
using DMA_AU24_LAB2_Group4.MAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.MAUI.ViewModels
{
    [ObservableObject]
    [QueryProperty("Booking", nameof(Booking))]
    public partial class BookingItemViewModel
    {
        private bool _isNewBooking;
        private IBookingService _bookingService;

        [ObservableProperty] private Booking booking = null!;
        partial void OnBookingChanging(Booking value)
        {
            _isNewBooking = IsNewBooking(value);
        }

        public BookingItemViewModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        private bool IsNewBooking(Booking booking)
        {
            if (booking.Id != 0)
                return true;
            return false;
        }

        [RelayCommand]
        public async Task Save()
        {
            await _bookingService.SaveBookingAsync(Booking, _isNewBooking);
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task Delete()
        {
            await _bookingService.DeleteBookingAsync(Booking);
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task Cancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
