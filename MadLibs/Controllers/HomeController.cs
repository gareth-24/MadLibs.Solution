using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View();}

    [Route("/poemform")]
    public ActionResult PoemForm() { return View();}

    [Route("/poem")]
    public ActionResult Poem(string poemnoun1, string poemnoun2, string poemnoun3, string poemnoun4, string poemnoun5, string poemnoun6, string poemadjective1, string poemdirection1, string poemnoun7, string poemdirection2, string bodypart)
    {
      PoemVariable myPoemVariable = new PoemVariable();
      myPoemVariable.PoemNoun1 = poemnoun1;
      myPoemVariable.PoemNoun2 = poemnoun2;
      myPoemVariable.PoemNoun3 = poemnoun3;
      myPoemVariable.PoemNoun4 = poemnoun4;
      myPoemVariable.PoemNoun5 = poemnoun5;
      myPoemVariable.PoemNoun6 = poemnoun6;
      myPoemVariable.PoemNoun7 = poemnoun7;
      myPoemVariable.PoemAdjective1 = poemadjective1;
      myPoemVariable.PoemDirection1 = poemdirection1;
      myPoemVariable.PoemDirection2 = poemdirection2;
      myPoemVariable.BodyPart = bodypart;
      return View(myPoemVariable);
    }

    [Route("/form")] //can change to "/form" later
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