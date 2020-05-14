using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords.Models;

namespace NumberToWords.Tests
{
  [TestClass]
  public class NumsToWordsTest
  {
    [TestMethod]
    public void NumberToWords_NumToWs_OneDigit()
    {
      string result = NTW.NumsToWs("4");
      Assert.AreEqual("four", result);
    }
    [TestMethod]
    public void NumberToWords_NumToWs_TwoDigit()
    {
      string result = NTW.NumsToWs("42");
      Assert.AreEqual("forty two", result);
    }
  }
}