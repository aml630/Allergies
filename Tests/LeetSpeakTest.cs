using Xunit;
using LeetSpeakNS.Objects;

namespace LeetSpeakNS
{
  public class LeetSpeakTest
  {
    // English Spec List:
      // The letter e should be replaced with 3
      [Fact]
      public void Translate_ForLetterE_ReplaceWith3()
      {
        Assert.Equal("3", LeetSpeak.Translate("e"));
      }
      // The letter o should be replaced with 0
      // The capital letter I should be replaced with 1
      // The letter t should be replaced with 7
      // words in quotes should be ignored
      // the letter s should be replaced with z, keeping case, unless at the front of the word
      // the letter g should be replaced by 9
    /**/

    /*
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFourHundred_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
    /**/
  }
}
