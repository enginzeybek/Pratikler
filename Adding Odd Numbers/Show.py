print("Tek sayıların toplamı uygulaması")

class AddingResult:

    def sumOfOdds(self):
        oddSum = 0
        numbersList = [1,2,3,4,5]
        for x in numbersList:
            if (x % 2 == 1):
                oddSum += x
        print(f"Tek sayıların toplamı: {oddSum}") 

    def sumOfOdds2(self, numbersList):
        oddSum = sum(x for x in numbersList if x % 2 == 1)
        print(f"Tek sayıların toplamı: {oddSum}")


y = AddingResult()
y.sumOfOdds()
y.sumOfOdds2([1,2,3,4,5])