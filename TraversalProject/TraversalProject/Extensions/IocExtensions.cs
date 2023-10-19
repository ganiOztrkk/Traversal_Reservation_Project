using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;


namespace TraversalProject.Extensions;

public static class IocExtensions
{
    public static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddScoped<AppUser>();
        
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
        
        return services;
    }
}