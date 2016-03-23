module StringManipulationTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``Count the number of vowels in various strings``() =
  Assert.AreEqual(StringManipulation.countVowels "abracadabra", 5)
  Assert.AreEqual(StringManipulation.countVowels "pear tree", 4)
  Assert.AreEqual(StringManipulation.countVowels "o a kak ushakov lil vo kashu kakao", 13)
  Assert.AreEqual(StringManipulation.countVowels "my pyx", 2)