// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".

string text = "Молчат гробницы, мумии и кости, —"
            + "Лишь слову жизнь дана:"
            + "Из древней тьмы, на мировом погосте,"
            + "Звучат лишь Письмена."
            + ""
            + "И нет у нас иного достоянья!"
            + "Умейте же беречь"
            + "Хоть в меру сил, в дни злобы и страданья,"
            + "Наш дар бессмертный — речь. ккккк CCCCCCC";

// string s = "qwerty";
//             012
// s[3] это r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
        
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);