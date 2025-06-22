function toplamBul(number)
{
    let toplam = 0;
    for (let i = 1; i <= number; i++) {
        toplam += i;
    }
    return toplam;
}

var result = toplamBul(5);

console.log("Sonuç= " + result);

document.getElementById("result").innerHTML = result;