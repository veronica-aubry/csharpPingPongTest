using System.Collections.Generic;
using System;

namespace PingPong.Objects

{

  //variables//

    public class PingPongGenerator
    {
      private string _input;
      private int _inputIntConverted;
      public List<string> _results = new List<string> {};


    public PingPongGenerator(string userInput) {
      _input = userInput;
      _results.Clear();
    }

    public void LoadNumber() {
      PingPongMethod(this._input);
    }

    // public int GetInt()
    //  {
    // _inputIntConverted = int.Parse(_input);
    //  return _inputIntConverted;
    //  }

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
      return _results;
    }
  }
}
