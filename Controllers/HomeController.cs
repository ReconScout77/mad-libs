using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Funny()
    {
      MadLibsVariables myMadLibsVariables = new MadLibsVariables();
      myMadLibsVariables.SetNoun1("Eric");
      myMadLibsVariables.SetNoun2("John");
      myMadLibsVariables.SetNoun3("Eric");
      myMadLibsVariables.SetNoun4("John");
      myMadLibsVariables.SetAdjective1("Eric");
      myMadLibsVariables.SetAdjective2("John");
      myMadLibsVariables.SetVerb1("Eric");
      myMadLibsVariables.SetVerb2("John");
      myMadLibsVariables.SetVerb3("Eric");
      myMadLibsVariables.SetVerb4("John");
      return View(myMadLibsVariables);
    }
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/mad_libs")]
    public ActionResult MadLibs()
    {
      MadLibsVariables myMadLibsVariables = new MadLibsVariables();
      myMadLibsVariables.SetNoun1(Request.Query["noun1"]);
      myMadLibsVariables.SetNoun2(Request.Query["noun2"]);
      myMadLibsVariables.SetNoun3(Request.Query["noun3"]);
      myMadLibsVariables.SetNoun4(Request.Query["noun4"]);
      myMadLibsVariables.SetAdjective1(Request.Query["adjective1"]);
      myMadLibsVariables.SetAdjective2(Request.Query["adjective2"]);

      myMadLibsVariables.SetVerb1(Request.Query["verb1"]);
      myMadLibsVariables.SetVerb2(Request.Query["verb2"]);
      myMadLibsVariables.SetVerb3(Request.Query["verb3"]);
      myMadLibsVariables.SetVerb4(Request.Query["verb4"]);

      return View("Funny", myMadLibsVariables);
    }
  }
}
