using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }
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
    [Route("/animalsForm")]
    public ActionResult AnimalsForm() { return View(); }
    [Route("/animals")]
    public ActionResult Animals (string animalNoun, string animalNoun2, string animalVerb, string animalAdjective)
    {
      AnimalVariable myAnimalMadLibs = new AnimalVariable();
      myAnimalMadLibs.AnimalNoun = animalNoun;
      myAnimalMadLibs.AnimalNoun2 = animalNoun2;
      myAnimalMadLibs.AnimalVerb = animalVerb;
      myAnimalMadLibs.AnimalAdjective = animalAdjective;
      return View(myAnimalMadLibs);
    }
  }
}