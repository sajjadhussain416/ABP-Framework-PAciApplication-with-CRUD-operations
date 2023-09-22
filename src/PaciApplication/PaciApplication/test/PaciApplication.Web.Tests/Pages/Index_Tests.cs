using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace PaciApplication.Pages;

public class Index_Tests : PaciApplicationWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
