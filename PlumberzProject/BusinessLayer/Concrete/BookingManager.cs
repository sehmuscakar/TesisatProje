using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class BookingManager : IBookingManager
    {

        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            this._bookingDal = bookingDal;
        }

        public void Add(Booking booking)
        {
            booking.CreatedBy = 1;
            booking.IsActive = true;
            var roworder = _bookingDal.GetActiveList().Count();
            booking.RowOrder = roworder + 1;
            _bookingDal.Add(booking);
        }

        public IList<BookingListDto> GetBookingListManager()
        {

            var dtoliste = _bookingDal.GetBookingListDal();
            return dtoliste;    
        }

        public Booking GetById(int id)
        {
            Expression<Func<Booking, bool>> filter = x => x.Id == id;
            return _bookingDal.Get(filter);
        }

        public IList<Booking> GetList()
        {
            var listele = _bookingDal.GetActiveList();
            return listele; 
        }

        public void Remove(Booking booking)
        {
           _bookingDal.Delete(booking); 
        }

        public void Update(Booking booking)
        {
           booking.CreatedBy = 1;
           booking.IsActive = true;
            var roworder = _bookingDal.GetActiveList().Count();
            booking.RowOrder = roworder;
            booking.LastUpdatedAt = DateTime.Now;
            _bookingDal.Update(booking);
        }
    }
}
