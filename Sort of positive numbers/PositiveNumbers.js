function sortPositiveNumbers() {
    let clientNumbers = prompt("aralara virgül koyarak pozitif ve negatif sayılar giriniz");

    let arrayNumbers = clientNumbers.split(",");

    let intArrayNumbers = arrayNumbers.map(Number);

    let positives = intArrayNumbers.filter(x => x > 0);

    let sorted = positives.sort((a, b) => a - b);

    document.getElementById("Show").innerText = "Sıralı pozitif sayılar= " + sorted.join(", ");
}