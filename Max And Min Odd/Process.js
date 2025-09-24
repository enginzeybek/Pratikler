class Process {
    FindOdd(){
        let numbers = document.getElementById("Numbers").value;
        if (!numbers) {
            alert("Lütfen rakamları girin!");
            return;
        }
        let strNumbersArray = numbers.split(", ").map(x => x.trim());
        let intNumbersArray = strNumbersArray.map(Number);

        if (intNumbersArray.some(isNaN)) {
            alert("GEÇERLİ FORMATTA GİRİNİZ");
            return;
        }
        
            let Max = intNumbersArray[0];
            let Min = intNumbersArray[0];

        for (let i = 1; i < intNumbersArray.length; i++) {
            
            if (intNumbersArray[i] > Max) {
                
                Max = intNumbersArray[i];
            }
            else if (intNumbersArray[i] < Min){
                
                Min = intNumbersArray[i];
            }
        }

        let Result = Max - Min;
        
        document.getElementById("result").innerText = `En küçük sayı ${Min} ile En büyük sayının ${Max} farkı ${Result}.`;
    }
}