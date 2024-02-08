using Microsoft.AspNetCore.Mvc;

namespace BreakfastApp.Controllers;

public class ErrorsController : ControllerBase
{
  [Route("/error")]
  public IActionResult Error()
  {
    return Problem();
  }
}
