using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "математика", "інформатика", "фізика", "хімія", "література" };

        // Запит на пошук слова
        var result = words.FirstOrDefault(w => w == "інформатика");
        Console.WriteLine(result != null ? $"Знайдено слово: {result}" : "Слово не знайдено");
    }
}
