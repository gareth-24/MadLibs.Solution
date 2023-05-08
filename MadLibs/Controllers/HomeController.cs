using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")] //can change to "/form" later
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string adjective1, string noun1, string name1, string adverb1, string verb1, string exclamation1, string adjective2, string number1, string interjection, string place)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Adjective1 = adjective1;
      myMadLibsVariable.Noun1 = noun1;
      myMadLibsVariable.Name1 = name1;
      myMadLibsVariable.Adverb1 = adverb1;
      myMadLibsVariable.Verb1 = verb1;
      myMadLibsVariable.Exclamation1 = exclamation1;
      myMadLibsVariable.Adjective2 = adjective2;
      myMadLibsVariable.Number1 = number1;
      myMadLibsVariable.Interjection = interjection;
      myMadLibsVariable.Place = place;
      return View(myMadLibsVariable);
    }
  }
}