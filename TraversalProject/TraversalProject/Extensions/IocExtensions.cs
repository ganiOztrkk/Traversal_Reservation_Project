using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using TraversalProject.Areas.Member.Models;


namespace TraversalProject.Extensions;

public static class IocExtensions
{
    public static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddScoped<AppUser>();
        services.AddScoped<ProfileEditVM>();
        services.AddTransient<IValidator<AnnouncementAddDTOs>, AnnouncementValidator>();
        
        services.AddScoped<IAbout2Service, About2Manager>();
        services.AddScoped<IAboutService, AboutManager>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IDestinationService, DestinationManager>();
        services.AddScoped<IFeature2Service, Feature2Manager>();
        services.AddScoped<IFeatureService, FeatureManager >();
        services.AddScoped<IGuideService, GuideManager>();
        services.AddScoped<INewsletterService, NewsletterManager>();
        services.AddScoped<ISubAboutService, SubAboutManager>();
        services.AddScoped<ITestimonialService, TestimonialManager>();
        services.AddScoped<ICommentService, CommentManager>();
        services.AddScoped<IReservationService, ReservationManager>();
        services.AddScoped<IAppUserService, AppUserManager>();
        services.AddScoped<IContactMessageService, ContactMessageManager>();
        services.AddScoped<IAnnouncementService, AnnouncementManager>();
        
        services.AddScoped<IAbout2Dal, EfAbout2Dal>();
        services.AddScoped<IAboutDal, EfAboutDal>();
        services.AddScoped<IContactDal, EfContactDal>();
        services.AddScoped<IDestinationDal, EfDestinationDal>();
        services.AddScoped<IFeature2Dal, EfFeature2Dal>();
        services.AddScoped<IFeatureDal, EfFeatureDal>();
        services.AddScoped<IGuideDal, EfGuideDal>();
        services.AddScoped<INewsletterDal, EfNewsletterDal>();
        services.AddScoped<ISubAboutDal, EfSubAboutDal>();
        services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        services.AddScoped<ICommentDal, EfCommentDal>();
        services.AddScoped<IReservationDal, EfReservatioDal>();
        services.AddScoped<IAppUserDal, EfAppUserDal>();
        services.AddScoped<IContactMessageDal, EfContactMessageDal>();
        services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        
        return services;
    }
}