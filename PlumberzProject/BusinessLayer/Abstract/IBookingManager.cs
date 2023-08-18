using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBookingManager
    {
        IList<BookingListDto> GetBookingListManager();
        IList<Booking> GetList();

        void Add(Booking booking);

        void Update(Booking booking);

        void Remove(Booking booking);

        Booking GetById(int id);

    }
}
