class ShowResult:
    def FindEvenSquare(self,numbers):
        arrayNumbers = [int(x.strip()) for x in numbers.split(",")]
        arrayResult = []
        for number in arrayNumbers:
            if number % 2 == 0:
                arrayResult.append(number ** 2)
        print(f"Çift sayıların kareleri: {arrayResult}")