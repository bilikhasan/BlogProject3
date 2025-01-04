using BlogProject3.BusinessLayer.Abstract;
using BlogProject3.BusinessLayer.Concrete;
using BlogProject3.DataAccessLayer.Abstract;
using BlogProject3.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject3.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies (this IServiceCollection services)
        {
            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<IArticleService, ArticleManager>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();

            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<INewsletterDal, EfNewsletterDal>();
            services.AddScoped<INewsletterService, NewsletterManager>();

        }
    }
}
