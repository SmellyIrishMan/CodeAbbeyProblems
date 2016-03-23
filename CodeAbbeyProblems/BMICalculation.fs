module BMICalculation

  type BMI = Under | Normal | Over | Obese
  
  //Is there a cleaner way? Maybe add the range to the record and add an isWithinRange function?
  let private convertBMIscoreToLiteral bmi =
    if bmi < 18.5 then
      BMI.Under
    else if bmi < 25.0 then
      BMI.Normal
    else if bmi < 30.0 then
      BMI.Over
    else
      BMI.Obese

  let calculateBMI weight height =
    let bmi = weight / (height * height)
    convertBMIscoreToLiteral bmi