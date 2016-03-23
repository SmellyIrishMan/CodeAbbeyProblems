module TempConversion
//32F == 0C
//212F == 100C

  let fahrenheitToCelcius degrees =
    System.Math.Round((degrees - 32.0) / 1.8)