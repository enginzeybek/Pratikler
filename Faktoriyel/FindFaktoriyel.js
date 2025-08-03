function TakeFaktoriyel() {
    let clientNumber = Number(document.getElementById("Number").value);

    let result = 1;

    for (let i = 1; i <= clientNumber; i++) {
        
        result *= i;
    }

    document.getElementById("Show").innerText = clientNumber + " " + "numarasının faktoriyeli" + " " + result;

    console.log(clientNumber + " " + "numarasının faktoriyeli" + " " + result);
}