using System;
using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;

namespace SignalR.DAL.EntityFramework;

public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
{
    public EfSocialMediaDal(SignalRContext context) : base(context)
    {
    }
}
