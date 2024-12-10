using System;
using SignalR.Business.Abstract;
using SignalR.DAL.Abstract;
using SignalR.Entity.Entities;

namespace SignalR.Business.Concrete;

public class ITestimonialManager : ITestimonialService
{
    private readonly ITestimonialDal _testimonialDal;

    public ITestimonialManager(ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }

    public void TAdd(Testimonial entity)
    {
        _testimonialDal.Add(entity);
    }

    public void TDelete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public Testimonial TGetById(int id)
    {
        return _testimonialDal.GetById(id);
    }

    public List<Testimonial> TGetListAll()
    {
        return _testimonialDal.GetListAll();
    }

    public void TUpdate(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }
}