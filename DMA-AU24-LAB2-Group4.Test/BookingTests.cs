using DMA_AU24_LAB2_Group4.Data;
using DMA_AU24_LAB2_Group4.Data.DTO;
using DMA_AU24_LAB2_Group4.Data.Entity;
using DMA_AU24_LAB2_Group4.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DMA_AU24_LAB2_Group4.Test
{
    public class BookingTests
    {
        public class BookingContext : DbContext
        { 
            public BookingContext(DbContextOptions<BookingContext> options) : base(options)
            {
            }

            public DbSet<BookingCreateDto> Bookings { get; set; }
        }

        [Fact]
        public async Task AddBooking_ShouldAddBookingToDatabase()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "BookingDatabase")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {
                var unitOfWork = new UnitOfWork(context);
                var booking = new Booking
                {
                    Id = 5,
                    CustomerId = 1,
                    PerformanceId = 1
                };

                // Act
                context.Bookings.Add(booking);
                var saveResult = await unitOfWork.SaveChangesAsync();

                // Assert
                Assert.Equal(1, saveResult); // Ensure one record was saved

                var savedBooking = await unitOfWork.Bookings.GetAllBookingDetailsByIdAsync(booking.CustomerId);
                Assert.NotNull(savedBooking);
                Assert.Contains(savedBooking, b => b.CustomerId == booking.CustomerId && b.PerformanceId == booking.PerformanceId);
            }
        }
    }
}
