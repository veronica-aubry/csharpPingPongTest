using Xunit;
using System.Collections.Generic;
using System;

namespace  PingPong.Objects
{
  public class PingPongTest
  {
    [Fact]
    public void PingPongMethod_ForNumberDivisibleByThree_ping()
    {
      PingPongGenerator testPingPong = new PingPongGenerator("3");
      var expected = new List<string>();
        expected.Add("1");
        expected.Add("2");
        expected.Add("ping");
      var actual = testPingPong.PingPongMethod("3");
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PingPongMethod_ForNumberNotDivisibleByThree_ping()
    {
      PingPongGenerator testPingPong = new PingPongGenerator("2");
      var expected = new List<string>();
        expected.Add("1");
        expected.Add("2");
      var actual = testPingPong.PingPongMethod("2");
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void PingPongMethod_ForNumberDivisibleByFive_pong()
    {
      PingPongGenerator testPingPong = new PingPongGenerator("5");
      var expected = new List<string>();
        expected.Add("1");
        expected.Add("2");
        expected.Add("ping");
        expected.Add("4");
        expected.Add("pong");
        var actual = testPingPong.PingPongMethod("5");
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PingPongMethod_ForNumberDivisibleByBoth_pingpong()
    {
      PingPongGenerator testPingPong = new PingPongGenerator("15");
      var expected = new List<string>();
        expected.Add("1");
        expected.Add("2");
        expected.Add("ping");
        expected.Add("4");
        expected.Add("pong");
        expected.Add("ping");
        expected.Add("7");
        expected.Add("8");
        expected.Add("ping");
        expected.Add("pong");
        expected.Add("11");
        expected.Add("ping");
        expected.Add("13");
        expected.Add("14");
        expected.Add("ping pong");
        var actual = testPingPong.PingPongMethod("15");
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PingPongMethod_PropperListContentsReturned_PingPongMethod()
    {
        PingPongGenerator testPingPong = new PingPongGenerator("16");
        var expected = new List<string>();
          expected.Add("1");
          expected.Add("2");
          expected.Add("ping");
          expected.Add("4");
          expected.Add("pong");
          expected.Add("ping");
          expected.Add("7");
          expected.Add("8");
          expected.Add("ping");
          expected.Add("pong");
          expected.Add("11");
          expected.Add("ping");
          expected.Add("13");
          expected.Add("14");
          expected.Add("ping pong");
          expected.Add("16");
          var actual = testPingPong.PingPongMethod("16");
          Assert.Equal(expected, actual);
    }
  }
}
