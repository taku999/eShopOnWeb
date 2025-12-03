using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
// alias the Program type from the PublicApi assembly
using PublicApiProgram = Microsoft.eShopWeb.PublicApi.Program;

namespace PublicApiIntegrationTests;

[TestClass]
public class ProgramTest
{
    private static WebApplicationFactory<PublicApiProgram> _application = new();

    public static HttpClient NewClient => _application.CreateClient();

    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext _)
    {
        _application = new WebApplicationFactory<PublicApiProgram>();
    }
}
