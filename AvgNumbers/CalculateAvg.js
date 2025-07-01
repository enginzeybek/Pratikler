function AvarageCalc() {
    
    let Numbers = prompt("GİRDİĞİNİZ RAKAMLARI VİRGÜL İLE AYIRINIZ");

    let Arrays = Numbers.split(",");

    let ArrayNumbers = Arrays.map(Number);

    let toplam = 0;

    for (let index = 0; index < ArrayNumbers.length; index++) {
        toplam += ArrayNumbers[index];
    }

    let avg = toplam / ArrayNumbers.length;

    return avg;
}

let result = AvarageCalc();

document.getElementById("OrtalamaAl").innerText = "Ortalama: " + result;

console.log("GİRİLEN SAYILARIN ORTALAMASI: " + result);