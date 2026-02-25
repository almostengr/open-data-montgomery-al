using Microsoft.AspNetCore.Mvc;
using Almostengr.OpenDataMontgomeryAlGov.ApiClient.CodeViolations;

namespace Almostengr.OpenDataMontgomeryAlGov.Web.Controllers;

public class CodeViolationsController : Controller
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