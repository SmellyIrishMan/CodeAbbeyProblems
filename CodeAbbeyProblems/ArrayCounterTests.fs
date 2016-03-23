module ArrayCounterTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``The occurances of different integers in [3; 2; 1; 2; 3; 1; 1; 1; 1; 3] is [5; 2; 3]``() =
  Assert.AreEqual( ArrayCounter.countOccurances [3; 2; 1; 2; 3; 1; 1; 1; 1; 3], [5; 2; 3])