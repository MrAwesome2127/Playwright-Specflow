using Playwright_Automation_Framework.Config;
using Playwright_Automation_Framework.Driver;

namespace PlaywrightCSharp_SpecFlow.Hook;

[Binding]
public class Hook
{
    private readonly TestSettings _testSettings;
    private Task<IPage> _page;

    public Hook(IPlaywrightDriver playwrightDriver, TestSettings testSettings )
    {
        _testSettings = testSettings;
        _page = playwrightDriver.Page;
    }

    [BeforeScenario]
    public async Task BeforeScenario()
    {
        await (await _page).GotoAsync(_testSettings.ApplicationURL);
    }
}
