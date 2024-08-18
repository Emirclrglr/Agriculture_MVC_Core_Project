using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extension
    {
        public static void ContainerDependencies(this IServiceCollection Services)
        {
            // Service Config
            Services.AddScoped<IServiceService, ServiceManager>();
            Services.AddScoped<IServiceDal, EfServiceDal>();

            // Team Config
            Services.AddScoped<ITeamService, TeamManager>();
            Services.AddScoped<ITeamDal, EfTeamDal>();

            // Announcement Config
            Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            // Gallery Config
            Services.AddScoped<IGalleryService, GalleryManager>();
            Services.AddScoped<IGalleryDal, EfGalleryDal>();

            // Address Config
            Services.AddScoped<IAddressService, AddressManager>();
            Services.AddScoped<IAddressDal, EfAddressDal>();

            // Contact Config
            Services.AddScoped<IContactService, ContactManager>();
            Services.AddScoped<IContactDal, EfContactDal>();

            // Social Media Config
            Services.AddScoped<ISocialMediaService, SocialMediaManager>();
            Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

            // About Config
            Services.AddScoped<IAboutService, AboutManager>();
            Services.AddScoped<IAboutDal, EfAboutDal>();

            // About Config
            Services.AddScoped<IAddressService, AddressManager>();
            Services.AddScoped<IAddressDal, EfAddressDal>();

            // About Config
            Services.AddScoped<IAdminService, AdminManager>();
            Services.AddScoped<IAdminDal, EfAdminDal>();
        }
    }
}
