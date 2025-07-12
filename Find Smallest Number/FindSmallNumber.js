function SmallestNumber() {
  let clientNumber = document.getElementById("SmallNumber").value;
  
  let arrayNumbers = clientNumber.split(",");

  let intNumbers = arrayNumbers.map(Number);

  let theSmallestNumber = Math.min(...intNumbers);

  document.getElementById("kucukSayi").innerText = "En Küçük Sayı: " +  theSmallestNumber;

  console.log("En Küçük Sayı: " +  theSmallestNumber);
}