module SummingTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``When 2 is added to 2 expect 4``() =
  Assert.AreEqual(2+2, 4)
  
[<Test>]
let ``SumAB of 3 and 5 equals 8``() =
  Assert.AreEqual(Summing.sumAB 3 5 , 8)  
  
[<Test>]
let ``SumList of [10; 20; 30; 40; 5; 6; 7; 8 ] equals 126``() =
  Assert.AreEqual(Summing.sumList [10; 20; 30; 40; 5; 6; 7; 8 ], 126)

[<Test>]
let ``The sum of lists [1 .. 9] and [for i in 1 .. 9 -> i * 10] equals [11; 22; 33; 44; 55; 66; 77; 88; 99]``() =
  let list1to9 = [1 .. 9]
  let list10s = [for i in 1 .. 9 -> i * 10]
  Assert.AreEqual(Summing.sumLists list1to9 list10s, [11; 22; 33; 44; 55; 66; 77; 88; 99])

[<Test>]
let ``sumLists [100; 15; 1945] [8; 245; 54] = [108; 260; 1999]``() =
  Assert.AreEqual(Summing.sumLists [100; 15; 1945] [8; 245; 54], [108; 260; 1999])

[<Test>]
let ``The sum of two empty lists is an empty list``() =
  Assert.AreEqual(Summing.sumLists [] [], [])

[<Test>]
let ``If lists are not the same size then we add only as far as we can``() =
  let shortList = [1 .. 5]
  let longList = 10 :: 10 :: 10 :: 10 :: 10 :: 10 :: 10 :: []
  Assert.AreEqual(Summing.sumLists shortList longList, [11; 12; 13; 14; 15])
  Assert.AreEqual(Summing.sumLists longList shortList, [11; 12; 13; 14; 15])

[<Test>]
let ``The sum of the digits in 0 equals 0``() =
  Assert.AreEqual(Summing.sumDigits 0, 0)

[<Test>]
let ``The sum of the digits in 12345 equals 15``() =
  Assert.AreEqual(Summing.sumDigits 12345, 15)

[<Test>]
let ``The sum of the digits in 11*9+1 equals 1``() =
  Assert.AreEqual(Summing.sumDigits (11*9+1), 1)

[<Test>]
let ``The sum of the digits in 14*90+232 equals 1``() =
  Assert.AreEqual(Summing.sumDigits (14*90+232), 16)

[<Test>]
let ``The sum of the digits in 111*15+111 equals 1``() =
  Assert.AreEqual(Summing.sumDigits (111*15+111), 21)

[<Test>]
let ``The weighted sum of [9; 15; 1776] equals [9; 11; 60]``() =
  Assert.AreEqual(Summing.sumDigitsWeighted 9, 9)
  Assert.AreEqual(Summing.sumDigitsWeighted 15, 11)
  Assert.AreEqual(Summing.sumDigitsWeighted 1776, 60)

[<Test>]
let ``The average of [2; 3; 7;] equals 4``() =
  Assert.AreEqual(Summing.avgList [2; 3; 7;], 4)

[<Test>]
let ``The average of [20; 10;] equals 15``() =
  Assert.AreEqual(Summing.avgList [20; 10;], 15)

[<Test>]
let ``The average of [1;] equals 1``() =
  Assert.AreEqual(Summing.avgList [1;], 1)

[<Test>]
let ``The arithmetic progression starting at 5 in steps of 2 after 3 rounds equals 21``() =
  Assert.AreEqual(Summing.arithmeticProgression 5 2 3, 21)

[<Test>]
let ``The arithmetic progression starting at 3 in steps of 0 after 10 rounds equals 30``() =
  Assert.AreEqual(Summing.arithmeticProgression 3 0 10, 30)
