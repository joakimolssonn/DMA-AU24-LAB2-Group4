﻿using DMA_AU24_LAB2_Group4.MAUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.MAUI.Services
{
    public interface IRestService
    {
        Task<ObservableCollection<Booking>?> RefreshDataAsync();
        Task SaveBookingAsync(Booking booking, bool isNewBooking);
        Task DeleteBookingAsync(int id);
    }
}
