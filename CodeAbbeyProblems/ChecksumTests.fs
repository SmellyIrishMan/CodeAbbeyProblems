module ChecksumTests

#if INTERACTIVE
#r @"C:/Program Files (x86)/NUnit.org/framework/3.0.5813.39031/net-4.5/nunit.framework.dll"
#endif

open NUnit.Framework

[<Test>]
let ``Checksum for [3; 1; 4; 1; 5; 9]``() =
  Assert.AreEqual( Checksum.generateChecksum [3; 1; 4; 1; 5; 9], 8921379)