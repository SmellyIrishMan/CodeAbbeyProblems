module DiceRolling

  let private clamp value min max =
    if value < min then min
    else if value > max then max
    else value

  let rollD6 probability =
    let clampedValue = clamp probability 0.0 0.99999999
    System.Math.Floor(1.0 + (clampedValue * 6.0))