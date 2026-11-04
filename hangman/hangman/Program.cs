class HangmanService
{
    string[] Word = { "footBall", "Pool", "Chairball", "Golf", "TableTennis" };
    string randomWord = "";
    string anwserField;
    char[] anwserChar;
    char[] keepAnwser;
    public int anwserCount;
    public int wrongCount ;
    public string test;
    public bool gameWin = false;


    Random random = new Random();

    public enum isCorrect{
        Correct = 0,
        incorrect = 1,
        Duplicate = 2
       }
    public void Restart()
    {
        int num = random.Next(0, Word.Length);
        randomWord = Word[num];
        anwserChar = new char[randomWord.Length];
        keepAnwser = new char[30];
        anwserCount = 0;
        wrongCount = 10;
        
        for (int i = 0; i < anwserChar.Length; i++) {
            anwserChar[i] = '_';
        }

    }
    public String GetDisPlay()
    {
        anwserField = "";
        int countWord = randomWord.Length;
        for (int i = 0; i < countWord; i++)
        {
            if (anwserChar[i] == randomWord[i])
            {
                anwserField += randomWord[i];
            }
            else {
                anwserField += "_ ";
            }
            
        }
        return anwserField;
    }
    public isCorrect Input(char guessWord)
    {
        bool CorrectStatus = false;
        bool DuplicateStatus = false;
        
        for (int j = 0; j < keepAnwser.Length; j++)
        {
            if (guessWord == keepAnwser[j])
            {
                DuplicateStatus = true;
            }
        }
        if (DuplicateStatus == true) {
            {
                System.Console.WriteLine("You have aleardy tried this Character");
                return isCorrect.Duplicate;
            }
        }
        else {
            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] == guessWord)
                {
                    anwserChar[i] = guessWord;
                    keepAnwser[anwserCount] = guessWord;
                    CorrectStatus = true;
                    test = string.Concat(anwserChar);
                    if(test == randomWord)
                    {
                        gameWin = true;
                    }
                    
                }
            }
            if (CorrectStatus == true)
            {
                anwserCount++;
                return isCorrect.Correct;
            }
            else
            {
                    keepAnwser[anwserCount] = guessWord;
                    System.Console.WriteLine("Sorry, you ’re wrong. Remaining " + (GetRemmainingTry()));
                    anwserCount++;
                    return isCorrect.incorrect;
            }
        }
    }
    public int GetRemmainingTry()
    {
        return wrongCount -=1;
        ;
    }
}
class Programs
{
    public static void Main(string[] args)
    {
        string guessWord;
        HangmanService hangman = new HangmanService();
        hangman.Restart();

        while (true) {
            if (hangman.wrongCount < 1)
            {
                System.Console.WriteLine("You Fail");
                break;
            }
            else if (hangman.gameWin == true) {
                System.Console.WriteLine("Congratulation, you’re win.");
                break;
            }
            
        System.Console.WriteLine(hangman.GetDisPlay());
        
        System.Console.Write("Please Inter Character : ");
        guessWord = System.Console.ReadLine();
        if(guessWord == null || guessWord == "")
            {
                hangman.Restart();
                continue;

            }
            hangman.Input(guessWord[0]);
        }

    }
}


