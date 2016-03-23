module Checksum

  let generateChecksum list =
    list |> List.fold (fun a b -> (((a + b) * 113) % 10000007)) 0