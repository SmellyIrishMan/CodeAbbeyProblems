module ArrayCounter

  let countOccurances list =
    list  |> Seq.countBy id 
          |> Seq.toList
          |> List.sort
          |> List.map (fun result ->
            match result with
            | (id, count) -> count)