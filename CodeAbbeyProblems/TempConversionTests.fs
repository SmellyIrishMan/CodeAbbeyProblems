module TempConversionTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``Converting fahrenheit to celcius``() =
  let samples = [ 495.0; 353.0; 168.0; -39.0; 22.0]
  let conversions = List.map TempConversion.fahrenheitToCelcius samples
  Assert.AreEqual(conversions, [257; 178; 76; -39; -6])