using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Placeholder() {return "Madlibs ahoy!";}
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlibs")]
    public ActionResult MadLibs(string firstNoun, string firstVerb, string firstAdjective)
    {
      MadLibVariable myMadLibs = new MadLibVariable();
      myMadLibs.FirstNoun = firstNoun;
      myMadLibs.FirstVerb = firstVerb;
      myMadLibs.FirstAdjective = firstAdjective;
      return View(myMadLibs);
    }
  }
}