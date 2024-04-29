using PlaywrightCSharp_SpecFlow.Pages;

namespace PlaywrightCSharp_SpecFlow.StepDefinitions;

[Binding]
public sealed class NintendoSteps
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IHome_Page _home_Page;
    private readonly IProduct_Page _product_Page;
    private readonly IAddToCart_Page _addToCart_Page;
    private readonly ICheckout_Page _checkout_Page;

    public NintendoSteps(ScenarioContext scenarioContext, IHome_Page home_Page, IProduct_Page product_Page, IAddToCart_Page addToCart_Page, ICheckout_Page checkout_Page)
    {
        _scenarioContext = scenarioContext;
        _home_Page = home_Page;
        _product_Page = product_Page;
        _addToCart_Page = addToCart_Page;
        _checkout_Page = checkout_Page;
    }

    [Given(@"I search for Product")]
    public async Task GivenISearchForProduct()
    {
        await _home_Page.SearchForThisProduct("Games", "The Legend of Zelda™: Tears of the Kingdom");
    }

    [When(@"I select a Physical copy")]
    public async Task WhenIAddAPhysicalCopyToCart()
    {
        await _product_Page.AddToCart_PhysicalCopy("The Legend of Zelda™: Tears of the Kingdom");
    }

    [When(@"I add a Physical copy to my cart")]
    public async void WhenIAddAPhysicalCopyToMyCart()
    {
        await _addToCart_Page.ViewCart("The Legend of Zelda™: Tears of the Kingdom", "$69.99");
    }

    [Then(@"I validate my cart has a Physical copy")]
    public async void ThenIValidateMyCartHasAPhysicalCopy()
    {
        await _checkout_Page.ValidateCartInformation("The Legend of Zelda™: Tears of the Kingdom", "$69.99");
    }
}
