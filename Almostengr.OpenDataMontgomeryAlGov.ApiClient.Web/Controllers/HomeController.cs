using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.Web.Models;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public abstract class TestController : Controller 
{
    private const string TEST_RESULT_VIEW = "_TestResult";

    public async Task<TestResult> RunTest(string name, Func<T<object>> action){
        if (string.IsNullOrWhiteSpace(name)) { 
            name = nameof(action);
        }

        TestResult testResult = new() { 
            Name = name, 
        };

        try {
            object result = await action;
            testResult.Passed = true;
        }
        catch (Exception ex) { 
            testResult.Passed= false; 
            testResult.Message = ex.Message;
        }

        return testResult;
    }

    public abstract Task<IActionResult> Index();
}

public sealed class TestResult
{
    public string Name {get;set;}
    public string Message {get;set;}
    public bool Passed {get;set;}
}