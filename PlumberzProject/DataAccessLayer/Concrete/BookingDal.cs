using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class BookingDal : BaseRepository<Booking, ProjeContext>, IBookingDal
    {
        public IList<BookingListDto> GetBookingListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Bookings.Select(booking => new BookingListDto()
                {
                 Id=booking.Id,  
                 FullName=booking.FullName, 
                 Mail=booking.Mail,
                 Tarih=booking.Tarih,
                 Description=booking.Description, 
                 IsActive=booking.IsActive,
                 RowOrder=booking.RowOrder,
                 LastUpdateedAt=booking.LastUpdatedAt,
                 CreatedFullName=booking.User.Name,//ıd yerine name atadık
                });
                return a.ToList();
            }
        }
    }
}
