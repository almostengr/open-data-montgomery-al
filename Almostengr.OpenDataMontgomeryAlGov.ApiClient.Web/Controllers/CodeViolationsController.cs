using Microsoft.AspNetCore.Mvc;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Web.Controllers;

public class CodeViolationsController : TestController
{
    private readonly ICodeViolationClient _codeViolationClient;

    public CodeViolationsController(
        ICodeViolationClient codeViolationClient
    )
    {
        _codeViolationClient = codeViolationClient;
    }

    // public async Task<IActionResult> Count()
    // {
    //     var resource=  await _codeViolationClient.GetCountAsync();
    //     return View(resource);
    // }
}