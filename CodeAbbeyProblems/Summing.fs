module Summing

  let sumAB a b = 
    a + b

  let rec sumList list =
    match list with
    | []         -> 0
    | head::tail -> head + sumList(tail)

  let rec sumLists list1 list2 =
    match (list1, list2) with
    | ([], list) -> []
    | (list, []) -> []
    | (aList, bList)
      ->  sumAB list1.Head list2.Head :: sumLists aList.Tail bList.Tail
  
  let rec sumDigits num =
    if num < 10 then num
    else
      let remainder = num % 10
      remainder + sumDigits (num/10)
  
  let rec private sumDigitsWeightedRec num iteration =
    if num < 10 then num * iteration
    else
      let remainder = num % 10
      (remainder * iteration) + sumDigitsWeightedRec (num/10) (iteration-1)

  let rec countDigitsInNumber num =
    if num < 0 then
      countDigitsInNumber(System.Math.Abs(num))
    else if num < 10 then
      1
    else 
      1 + countDigitsInNumber (num/10)

  let sumDigitsWeighted num =
    sumDigitsWeightedRec num (countDigitsInNumber num)

  let avgList list =
    let total = sumList list
    System.Math.Round( (float total) / (float list.Length) )

  let arithmeticProgression start step iterations =
    let sequence = [ for i in 0 .. (iterations - 1) -> start + (step*i) ]
    sumList sequence