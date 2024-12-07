using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
    public EfTestimonialDal(SignalRContext context) : base(context)
    {
    }
}
