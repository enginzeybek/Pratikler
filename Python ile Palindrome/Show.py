class Palindrome:
    def Check(self):
        sentence = input("Girdiğiniz kelime palindrome mu?: ")
        reverseSentence = "".join(reversed(sentence))
        if sentence == reverseSentence:
            print("Bu kelime palindrome")
        elif sentence != reverseSentence:
            print("Bu kelime palindrome değil")
        else:
            print("Geçerli kelime girin")
# kullanım

use = Palindrome()
use.Check()