function NegativeAndPositiveSum()
{
    let positiveResult = 0;

    let negativeResult = 0;

    let numbers = prompt("Negatif ve pozitif sayılar girin ve bunları virgülle ayırın");

    let numbersArray = numbers.split(",");

    let intNumbers = numbersArray.map(Number);

    for (let i = 0; i < intNumbers.length; i++) {
        
        if (intNumbers[i] < 0) {
            negativeResult += intNumbers[i];
        }
        else{
            positiveResult += intNumbers[i];
        }
    }

    console.log("Pozitif Sayıların Toplamı= " + positiveResult);
    console.log("Negatif Sayıların Toplamı= " + negativeResult);

    document.getElementById("Sum").innerText =
  "Pozitif Sayıların Toplamı: " + positiveResult + "\n" +
  "Negatif Sayıların Toplamı: " + negativeResult;

}