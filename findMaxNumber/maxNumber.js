 function maximumNum()
{
    let dizi = prompt("SAYILAR GİRİNİZ (VİRGÜLLE AYIRIN)");

    let diziArray = dizi.split(",");

    let toIntArray = diziArray.map(Number);

    let max = toIntArray[0];

    for (let i = 1; i < toIntArray.length; i++) {
        if (max <= toIntArray[i]) {
            max = toIntArray[i];
        }
    }
    return max;
}

const maxSayi = maximumNum();

document.getElementById("max").innerText = maxSayi;
console.log("EN BÜYÜK SAYI: " + maxSayi);