using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SK.Framework;
using System;
using System.Linq;

namespace Let3arafo.Core
{
    public static class DependencyInjection
    {
        public static void AddCore(this IMvcBuilder mvcBuilder, IHostingEnvironment hostingEnvironment)
        {
            //mvcBuilder
            //    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<TransportationMethodValidator>());

            //AddLogger();

            var services = mvcBuilder.Services;
            services
                .AddApplicationTypes();
        }

        //public static void UseControlPanelCore(this IApplicationBuilder builder)
        //{
        //    builder.UseAuthentication();
        //}

        //public static IServiceCollection AddAuthenticationAndAuthorization(this IServiceCollection services, IHostingEnvironment env)
        //{
        //    services
        //        .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        //        .AddCookie(o =>
        //        {
        //            o.Cookie.Expiration = new TimeSpan(8, 0, 0);
        //            o.Cookie.SecurePolicy = (env.IsProduction()) ? CookieSecurePolicy.Always : CookieSecurePolicy.SameAsRequest;
        //            o.Cookie.SameSite = SameSiteMode.Strict;
        //            o.Cookie.Name = "tayary_control_panel_auth";

        //            o.LoginPath = "/Identity/Login";
        //        });

        //    services.AddAuthorization(config =>
        //    {
        //        // Exact
        //        config.AddPolicy(Policies.Exact.SuperUser, p => p.RequireClaim(ClaimTypes.Role, AppClaims.SuperUser));
        //        config.AddPolicy(Policies.Exact.Operation, p => p.RequireClaim(ClaimTypes.Role, AppClaims.Operation));
        //        config.AddPolicy(Policies.Exact.OrderTaker, p => p.RequireClaim(ClaimTypes.Role, AppClaims.OrderTaker));
        //        config.AddPolicy(Policies.Exact.Tayar, p => p.RequireClaim(ClaimTypes.Role, AppClaims.Tayar));

        //        // Many
        //        config.AddPolicy(Policies.Many.OperationOrSuperUser, p => p.RequireClaim(ClaimTypes.Role, AppClaims.Operation, AppClaims.SuperUser));
        //        config.AddPolicy(Policies.Many.OrderTakerOrSuperUser, p => p.RequireClaim(ClaimTypes.Role, AppClaims.OrderTaker, AppClaims.SuperUser));
        //        config.AddPolicy(Policies.Many.TayarOrSuperUser, p => p.RequireClaim(ClaimTypes.Role, AppClaims.Tayar, AppClaims.SuperUser));
        //    });

        //    return services;
        //}

        public static IServiceCollection AddApplicationTypes(this IServiceCollection services)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .ToList();

            var inScopeType = typeof(IScoped);
            var singltonType = typeof(ISinglton);

            types
                .Where(x => inScopeType.IsAssignableFrom(x) && x != inScopeType)
                .ForEach(x => services.AddScoped(x));

            types
                .Where(x => singltonType.IsAssignableFrom(x) && x != singltonType)
                .ForEach(x => services.AddSingleton(x));

            return services;
        }

        //private static void AddLogger()
        //{
        //    Log.Logger = new LoggerConfiguration()
        //        .WriteTo.RollingFile($"{AppDomain.CurrentDomain.BaseDirectory}\\Logs\\tayary_fulfilment_controlpanel_log-{{Date}}.txt")
        //        .WriteTo.Console()
        //        .CreateLogger();

        //    Log.Information("Starting...");
        //}
    }
}