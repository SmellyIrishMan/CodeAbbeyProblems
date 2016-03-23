module StringManipulation

  let private isVowel letter =
    List.contains letter ['a'; 'o'; 'u'; 'i'; 'e'; 'y'; ]

  let countVowels sentence =
    sentence  |> List.ofSeq
              |> List.filter isVowel
              |> List.length