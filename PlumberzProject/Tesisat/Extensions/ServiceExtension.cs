using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace Tesisat.Extensions
{
    public static class ServiceExtension
    {
      public static void MyconfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITopbarManager, TopbarManager>();
            services.AddScoped<ITopbarDal, TopbarDal>();

            services.AddScoped<IAboutManager, AboutManager>();
            services.AddScoped<IAboutDal, AboutDal>();

            services.AddScoped<ITeamManager, TeamManager>();
            services.AddScoped<ITeamDal, TeamDal>();

            services.AddScoped<ICarouselManager, CarouselManager>();
            services.AddScoped<ICarouselDal, CarouselDal>();

            services.AddScoped<IFactManager, FactManager>();
            services.AddScoped<IFactDal, FactDal>();

            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IServiceDal, ServiceDal>();

            services.AddScoped<IBookingManager, BookingManager>();
            services.AddScoped<IBookingDal, BookingDal>();

            services.AddScoped<ITestimonialManager, TestimonialManager>();
            services.AddScoped<ITestimonialDal, TestimonialDal>();

            services.AddScoped<IRegisterManager, RegisterManager>();
            services.AddScoped<IRegisterDal, RegisterDal>();

            services.AddScoped<IContactManager, ContactManager>();
            services.AddScoped<IContactDal, ContactDal>();

        }
    }
}
