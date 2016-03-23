module DiceRollingTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``Dice rolls in [0..1) range transform to 1..6 range``() =
  Assert.AreEqual( DiceRolling.rollD6(0.59558786964), 4)
  Assert.AreEqual( DiceRolling.rollD6(0.861037873663), 6)
  Assert.AreEqual( DiceRolling.rollD6(0.385597702116), 3)
  Assert.AreEqual( DiceRolling.rollD6(0.246237673331), 2)
  Assert.AreEqual( DiceRolling.rollD6(0.808033385314), 5)
  Assert.AreEqual( DiceRolling.rollD6(0.0544673665427), 1)
  Assert.AreEqual( DiceRolling.rollD6(0.0000000000001), 1)
  Assert.AreEqual( DiceRolling.rollD6(0.9999999999999), 6)

[<Test>]
let ``Dice rolls in outside the [0..1] range are clamped``() =
  Assert.AreEqual( DiceRolling.rollD6(1.0), 6 )
  Assert.AreEqual( DiceRolling.rollD6(10.0), 6 )
  Assert.AreEqual( DiceRolling.rollD6(100.0), 6 )
  Assert.AreEqual( DiceRolling.rollD6(-0.0000001), 1)
  Assert.AreEqual( DiceRolling.rollD6(-10.0), 1)
  Assert.AreEqual( DiceRolling.rollD6(-100.0), 1)

  //Couldn't get this to work with exceptions.
  //Perhaps for the best, not sure if an exception is the best thing for the function
  //Assert.Throws( typeof(System.ArgumentException), raise (System.ArgumentException("Problem")) )
  //Assert.Throws( typeof(System.Exception),  , "Roll out of range")
  //Assert.AreEqual( DiceRolling.rollD6(-0.0000001), 1)