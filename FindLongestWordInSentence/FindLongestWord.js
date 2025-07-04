function EnUzunKelimeyiBul()
{
    let Cumle = document.getElementById("Sentence").value;

    let DiziCumle = Cumle.split(" ");

    let longest = "";

    for (let i = 0; i < DiziCumle.length; i++) {
        
        

        if (DiziCumle[i].length > longest.length) {
            
            longest = DiziCumle[i];
        }
    }

    document.getElementById("LongestWord").innerText = "EN UZUN KELİME: " + longest;

    console.log("EN UZUN KELİME: " + longest);
}

