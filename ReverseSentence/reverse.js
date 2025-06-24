function ReverseSentence() {
    let sentenceClient = document.getElementById("sentence").value;

    let sentenceArray = sentenceClient.split("");
    let reverseSentence = sentenceArray.reverse().join("");

    document.getElementById("result").innerText = "Ters cümle: " + reverseSentence;

    console.log("Ters cümle: " + reverseSentence);
}

