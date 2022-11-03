// работа с текстом
// Дан текст, в этом тексте надо все пробелы заменить на черточки 
// маленькие буквы "к" заменить большими буквами "К"
// а большие буквы "С" заменить на маленькие буквы "с"

string text = "Я думаю,- сказал князь, улыбаясь,-что ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне час?";

string ChangeText(string text, char oldVal, char newVal)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldVal) result = result + $"{newVal}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NEWtext = ChangeText(text, ' ', '|');
Console.WriteLine(NEWtext);
Console.WriteLine();
 NEWtext = ChangeText(NEWtext, 'к', 'К');
Console.WriteLine(NEWtext);
Console.WriteLine();
 NEWtext = ChangeText(NEWtext, 'С', 'с');
Console.WriteLine(NEWtext);
Console.WriteLine();