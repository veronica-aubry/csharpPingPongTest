using System.Collections.Generic;
using System;

namespace PingPong.Objects

{

  //variables//

    public class PingPongGenerator
    {
      private string _input;
      private int _inputIntConverted;
      private List<string> _results;


    public PingPongGenerator(string userInput) {
      _input = userInput;
       _results = new List<string>{};
      _results.Clear();
    }

    public List<string> GetNumbers () {
      return _results;
    }

    public void LoadNumber() {
      PingPongMethod(this._input);
    }

    public List<string> PingPongMethod(string input) {
      int newInput  = int.Parse(input);
      for (int i = 1; i <= newInput; i++)
      {
        if (i % 3 == 0 && i % 5 == 0 ) {
          _results.Add("ping pong");
        }
        else if (i % 3 == 0) {
          _results.Add("ping");
        }
        else if (i % 5 == 0) {
          _results.Add("pong");
        }
        else{
          _results.Add(i.ToString());
        }
      }
      return this.GetNumbers();
    }
  }
}
