module MinMaxing

  let min a b =
    if a < b 
    then a
    else b

  let max a b =
    if a > b
    then a
    else b

  let rec minLists list1 list2 =
    match (list1, list2) with
    | ([], list) -> []
    | (list, []) -> []
    | (aList, bList)
      ->  min list1.Head list2.Head :: minLists aList.Tail bList.Tail

  let minListsMap list1 list2 =
    List.map2 min list1 list2

  let rec minList list =
    match list with
    | [] -> Core.int.MaxValue
    | head::tail ->
      min head (minList tail)

  let maxList list =
    List.reduce max list

  let private CheckSwapAB (a, b, c) =
    if a > b then (b, a, c) else (a, b, c)

  let private CheckSwapBC (a, b, c) =
    if b > c then (a, c, b) else (a, b, c)

  let private mid triple =
    match triple with | (_, y, _) -> y

  let medianOfThree (a, b, c) =
    let mutable sortedTriple = (a, b, c)
    sortedTriple <- CheckSwapAB sortedTriple
    sortedTriple <- CheckSwapBC sortedTriple
    sortedTriple <- CheckSwapAB sortedTriple

    mid sortedTriple