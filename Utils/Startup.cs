using Microsoft.Extensions.DependencyInjection;
using Playwright_Automation_Framework.Config;
using Playwright_Automation_Framework.Driver;
using PlaywrightCSharp_SpecFlow.Pages;
using SolidToken.SpecFlow.DependencyInjection;

namespace PlaywrightCSharp_SpecFlow.Utils;

public class Startup
{
    [ScenarioDependencies]
    public static IServiceCollection CreateServices()
    {
        var services = new ServiceCollection();

        services
            .AddSingleton(ConfigReader.ReadConfig())
            .AddScoped<IPlaywrightDriver, PlaywrightDriver>()
            .AddScoped<IPlaywrightDriverInitializer, PlaywrightDriverInitializer>()

            //Below here you need to add you Interface from POM
            .AddScoped<IHome_Page, Home_Page>()
            .AddScoped<IProduct_Page, Product_Page>()
            .AddScoped<IAddToCart_Page, AddToCart_Page>()
            .AddScoped<ICheckout_Page, Checkout_Page>()
            ;

        return services;
    }
}