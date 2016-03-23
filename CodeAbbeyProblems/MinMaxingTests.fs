module MinMaxingTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``Min of 2 and 4 equals 2``() =
  Assert.AreEqual(MinMaxing.min 2 4, 2)

[<Test>]
let ``Min of [5; 2; 100] and [3; 8; 15] equal [3; 2; 15]``() =
  Assert.AreEqual(MinMaxing.minLists [5; 2; 100] [3; 8; 15], [3; 2; 15])

[<Test>]
let ``minLists and minListsMap are equivalent``() =
  let list1 = [12; 4; 17; 24; 63; 99; 543; 2; 5; 542; 64]
  let list2 = [4; 52; 5; 5423; 4; 5423; 76; 98; 423; 6; 16]
  Assert.AreEqual(MinMaxing.minLists list1 list2, MinMaxing.minListsMap list1 list2)

[<Test>]
let ``minList of [7; 3; 5;] equals 3``() =
  Assert.AreEqual(MinMaxing.minList [7; 3; 5], 3)

[<Test>]
let ``Maximum of [ 4; 53; 36; 7; 543; 6; 764; 43; 976; 534; 32; 2; 54; 5; 6; 7; 8; 9; 432; 436;] equals 976``() =
  let testList = [ 4; 53; 36; 7; 543; 6; 764; 43; 976; 534; 32; 2; 54; 5; 6; 7; 8; 9; 432; 436;]
  Assert.AreEqual(MinMaxing.maxList testList, 976)

[<Test>]
let ``Medians of (7, 3, 5), (15, 20, 40) and (300, 550, 137) are 5, 20 and 300``() =
  Assert.AreEqual(MinMaxing.medianOfThree (7, 3, 5), 5)
  Assert.AreEqual(MinMaxing.medianOfThree (15, 20, 40), 20)
  Assert.AreEqual(MinMaxing.medianOfThree (300, 550, 137), 300)

[<Test>]
let ``Median for all variations of (5, 15, 60) is 15``() =
  //TODO could look into List.permute to get the various permutations of the parameters.
  Assert.AreEqual(MinMaxing.medianOfThree (5, 15, 60), 15)
  Assert.AreEqual(MinMaxing.medianOfThree (5, 60, 15), 15)
  Assert.AreEqual(MinMaxing.medianOfThree (15, 5, 60), 15)
  Assert.AreEqual(MinMaxing.medianOfThree (15, 60, 5), 15)
  Assert.AreEqual(MinMaxing.medianOfThree (60, 5, 15), 15)
  Assert.AreEqual(MinMaxing.medianOfThree (60, 15, 5), 15)
