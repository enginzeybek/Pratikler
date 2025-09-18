class Vowel {
    VowelCount() {
        
        let sentence = document.getElementById("Sentence").value;

        if (!sentence) {
                document.getElementById("Vowel").innerText = "Lütfen boş bırakmayın";
                return;
            }

        sentence = sentence.toLowerCase();

        let vowelArray = ["a","e","ı","i","o","ö","u","ü"];

        let count = 0;

        for (let i = 0; i < sentence.length; i++) {
            
            if (vowelArray.includes(sentence[i]))
            {
                count++;
            }
        }
        document.getElementById("Vowel").innerText = `Girdiğiniz kelimedeki sesli harf sayısı ${count} tanedir.`
    }
}