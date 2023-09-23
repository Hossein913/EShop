using Eshop.Domain.core.AppService;
using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.IServices.FileService;
using Eshop.Domain.core.IServices.PictureService.Commands;
using Eshop.Domain.core.IServices.PictureService.Queries;
using Eshop.Domain.Services.PictureService.Queries;
using Eshop.Infra.Data.Repos.Ef;
using EShop.Domain.AppServices.CategoryAppServce;
using EShop.Domain.AppServices.ProductAppService;
using EShop.Domain.core.IServices.CategoryService.Command;
using EShop.Domain.core.IServices.CategoryService.Queries;
using EShop.Domain.core.IServices.CustomerService.Command;
using EShop.Domain.core.IServices.ProductService.Commands;
using EShop.Domain.IRepositories;
using EShop.Domain.Services.CategoryService.Command;
using EShop.Domain.Services.CategoryService.Queries;
using EShop.Domain.Services.CustomerService.Command;
using EShop.Domain.Services.File;
using EShop.Domain.Services.PictureService.Commands;
using EShop.Domain.Services.ProductService.Commands;

namespace UiEShop;
public static class DependencyInjection
{
    public static IServiceCollection AddInjections(this IServiceCollection services)
    {
        services.AddScoped<IAdminRepository, AdminRepository>();


        #region Addmin
        services.AddScoped<IAdminRepository, AdminRepository>();
        #endregion

        #region AppUser ----AppRole
        services.AddScoped<IUserManagerRepository, UserManagerRepository>();
        #endregion

        #region Cart
        services.AddScoped<ICartRepository, CartRepository>();
        #endregion

        #region Category
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryQueryService, CategoryQueryService>();
        services.AddScoped<ICategoryCommandService, CategoryCommandService>();
        services.AddScoped<ICategoryAppServices, CategoryAppServices>();
        #endregion

        #region Customer
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<ICustomerCommandService, CustomerCommandService>();
        #endregion

        #region File
        services.AddScoped<IFileServices, FileServices>();
        #endregion

        #region Order
        #endregion

        #region Picture
        services.AddScoped<IPictureRepository, PictureRepository>();
        services.AddScoped<IPictureQueryService, PictureQueryService>();
        services.AddScoped<IPictureCommandService, PictureCommandService>();
        #endregion

        #region Product

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductCommandService, ProductCommandService>();
        services.AddScoped<IProductAppservices, ProductAppServices>();
        #endregion

        return services;
    }
}