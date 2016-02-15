using Nancy;
using PingPong.Objects;
using System.Collections.Generic;

namespace Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      //loads index view at root//

      Post["/results"] = _ => {
      var newPingPong = new PingPongGenerator(Request.Form["userNumber"]);
      newPingPong.LoadNumber();
      return View["results.cshtml", newPingPong];
      };
    }
  }
}
