module BMICalculationTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``BMI for 80kg and 1.73m equals over``() =
  Assert.AreEqual(BMICalculation.calculateBMI 80.0 1.73, BMICalculation.BMI.Over)

[<Test>]
let ``BMI for 55kg and 1.58m equals normal``() =
  Assert.AreEqual(BMICalculation.calculateBMI 55.0 1.58, BMICalculation.BMI.Normal)

[<Test>]
let ``BMI for 49kg and 1.91m equals under``() =
  Assert.AreEqual(BMICalculation.calculateBMI 49.0 1.91, BMICalculation.BMI.Under)
