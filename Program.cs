string [] questionsArray = {"Сколько зубов у взрослого человека (без зубов мудрости)?" + "\r\n"+
"1) 28 2) 32  3) 26 4) 20",
                    "Какого Интернет-браузера не существует?" + "\r\n"+
"1) Opera 2) Google Chrome 3) Internet Explorer 4) MS PowerPoint",
                    "Какую скорость передачи данных может обеспечить широкополосная связь по ЛЭП? " + "\r\n"+
"200 МБит/с, 1 МБит/с, 100 МБит/с, 10 МБит/с",
                    "Какая поисковая система была самой популярной в 2011 году?" + "\r\n"+
" Yahoo!, Google, Bing, Yandex"
};
var clear = Console.Clear;

var questions = new Dictionary<string, int>()
{
    { questionsArray[0],1 },//"28"},

    {  questionsArray[1],4},//"MS PowerPoint"},

    {  questionsArray[2],3},//"100 МБит/с"},

    {questionsArray[3],2} //"Google"}

};

int countCorrect = 0; int countIncorrect = 0;

for (int i = 0; i < questionsArray.Length; i++)
{
    AsKQuest(questionsArray[i]);
}

if (countCorrect==questionsArray.Length)   System.Console.WriteLine($"Поздравляем вы ответили правильно на вопросы ");
else if (countCorrect>countIncorrect)     {System.Console.WriteLine($"Поздравляем вы ответили правильно на большее кол-во вопросов "); CountCorrectAnswer();}
else if  (countCorrect>countIncorrect)    {System.Console.WriteLine($"К сожалению вы ответили правильно на меньшее кол-во вопросов "); CountCorrectAnswer();}
else if ((countIncorrect==questionsArray.Length))System.Console.WriteLine($"Поздравляем вы бездарь ");

void AsKQuest(string AskNow)
{   
    int ansver = 0;
    while (true)
    {

        AskQuestion(AskNow,ref ansver);
        switch (ansver)
        {    
            case 1:CheckCorrect(AskNow,ansver);clear();return;
            case 2:CheckCorrect(AskNow,ansver);clear();return;
            case 3:CheckCorrect(AskNow,ansver);clear();return;
            case 4:CheckCorrect(AskNow,ansver);clear();return;
            case 000: return;
            default: Console.WriteLine("Неверное значение"); break;
        }
    }
}

void AskQuestion(string Ask , ref int ansver )
 {
     System.Console.WriteLine(Ask);
     ansver = int.Parse(Console.ReadLine());

}
void CheckCorrect(string Ask , int ansver)
{
    if (questions[Ask]==ansver)countCorrect++;
     else countIncorrect++;
}

void CountCorrectAnswer()
{
    System.Console.Write($" правильных ответов {countCorrect}"); 
    System.Console.Write($" неправильных ответов {countIncorrect}");
}
