//1. enum
//или перечисление. перечисления представляют набор логически связанных констант.
//DayTime now = 0;

////PrintMessage(now);
////PrintMessage(DayTime.Afternoon);
////PrintMessage(DayTime.Night);
//Console.WriteLine(now); 

//void PrintMessage(DayTime dayTime)
//{
//    switch (dayTime)
//    {
//        case DayTime.Morning:
//            Console.WriteLine("Good morning");
//            break;
//        case DayTime.Afternoon:
//            Console.WriteLine("Good afternoon");
//            break;
//        case DayTime.Evening:
//            Console.WriteLine("Good evening");
//            break;
//        case DayTime.Night:
//            Console.WriteLine("Good night");
//            break;
//    }

//    Console.WriteLine((int)now);  // 5
//    Console.WriteLine((int)DayTime.Night);  // 6
//}
//enum DayTime
//{
//    Morning,  //0
//    Afternoon, //1
//    Evening = 5,
//    Night     //6
//}


//2. params
//используя ключевое слово params, мы можем передавать неопределенное количество параметров

//public class XXXX
//{
//   public static void Sum(params int[] numbers)
//    {
//        int result = 0;
//        foreach (var n in numbers)
//        {
//            result += n;
//        }
//        Console.WriteLine(result);
//    }

//   public static void Sum(int x)
//    {
//        Console.WriteLine("hello");
//    }
//}
//XXXX.Sum(1);

//int[] nums = { 1, 2, 3, 4, 5 };
//Sum(nums);
//Sum(1, 2, 3, 4, 5, 6);
//Sum(1, 2, 3);
//Sum();

//3.Null и ссылочные типы
//значение null выступает как значение по умолчанию для ссылочных типов
//Чтобы определить переменную которым можно присваивать значение null, указывается знак вопроса ?

//string? name = Console.ReadLine();

//PrintUpper(name!);

//void PrintUpper(string text)
//{
//    if (text == null) Console.WriteLine("null");
//    else Console.WriteLine(text.ToUpper());
//}

//4. Null и значимые типы

int x = 5;
char v = 'a';
string f = "sdss";
//int val = null;  // ! ошибка, переменная val НЕ представляет тип nullable

//int? val = null;
//IsNull(val);    // null
//val = 22;
//IsNull(val);    // 22

//void IsNull(int? obj)
//{
//    if (obj == null) Console.WriteLine("null");
//    else Console.WriteLine(obj);
//}
////=======================================================================
//PrintNullable(5);       // 5
//PrintNullable(null);    // параметр равен null

//void PrintNullable(int? number)
//{
//    if (number.HasValue)
//    {
//        Console.WriteLine(number.Value);
//        // аналогично
//        Console.WriteLine(number);
//    }
//    else
//    {
//        Console.WriteLine("параметр равен null");
//    }
//}
//====================================================================================
//int? number = null; // если значения нет, метод возвращает значение по умолчанию
//Console.WriteLine(number.GetValueOrDefault());      // 0  - значение по умолчанию для числовых типов
//Console.WriteLine(number.GetValueOrDefault(10));    // 10

//number = 15;    // если значение задано, оно возвращается методом
//Console.WriteLine(number.GetValueOrDefault());    // 15
//Console.WriteLine(number.GetValueOrDefault(10));  // 15

//5.Методы расширения

//string s = "Hello world";
//char c = 'i';
//int i = s.CharCount(c);
//Console.WriteLine(i);
//s.Substring(0, 2);

//public static class StringExtension
//{
//    public static int CharCount(this string str, char c)
//    {
//        int counter = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (str[i] == c)
//                counter++;
//        }
//        return counter;
//    }
//}

//6.String
//string s1 = "hello";
//string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
//string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
//string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl
//Console.WriteLine(s1);  // hello
//Console.WriteLine(s2);  // aaaaaaa
//Console.WriteLine(s3);  // world
//Console.WriteLine(s4);  // orl

//string message = "hello";
//// получаем символ
//char firstChar = message[1]; // символ 'e'
//Console.WriteLine(firstChar);   //e
//Console.WriteLine(message.Length);  // длина строки  

//string message4 = "hello";
//for (var i = 0; i < message.Length; i++)
//{
//    Console.WriteLine(message[i]);
//}
//foreach (var ch in message)
//{
//    Console.WriteLine(ch);
//}

//string message1 = "hello";
//string message2 = "hello";
//Console.WriteLine(message1 == message2);    // true

//7.StringBuilder

//using System.Text;
//var sb = new StringBuilder("Hello World");
//Console.WriteLine(sb);    //  Hello World
//Console.WriteLine($"Длина: {sb.Length}");       // Длина: 10
//Console.WriteLine($"Емкость: {sb.Capacity}");   // Емкость: 16

//8. Регулярные выражения
//using System.Text.RegularExpressions;

//string s = "Autumn Lalasummer spring lala winter";
//Regex regex = new Regex(@"lala(\w*)", RegexOptions.IgnoreCase);
//MatchCollection matches = regex.Matches(s);
//if (matches.Count > 0)
//{
//    foreach (Match match in matches)
//        Console.WriteLine(match.Value);
//}
//else
//{
//    Console.WriteLine("No matches");
//}
//==================================================================
//string s = "456-435-2318";
//Regex regex2 = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");

//Проверка на соответствие строки формату===========================
//string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
//                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
//var data = new string[]
//{
//    "tom@gmail.com",
//    "+12345678999",
//    "bob@yahoo.com",
//    "+13435465566",
//    "sam@yandex.ru",
//    "+43743989393"
//};

//Console.WriteLine("Email List");
//for (int i = 0; i < data.Length; i++)
//{
//    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
//    {
//        Console.WriteLine(data[i]);
//    }
//}

//9. DateTime
//
//DateTime date1 = new DateTime(2015, 7, 20); // год - месяц - день
//Console.WriteLine(date1); // 20.07.2015 0:00:00

//DateTime date2 = new DateTime(2015, 7, 20, 18, 30, 25); // год - месяц - день - час - минута - секунда
//Console.WriteLine(date1); // 20.07.2015 18:30:25

//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);

//DateTime someDate = new DateTime(1582, 10, 5);
//Console.WriteLine(someDate.DayOfWeek);

//DateTime date3 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
//Console.WriteLine(date1.AddHours(3)); // 20.07.2015 21:30:25

//DateTime date4 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
//DateTime date5 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
//Console.WriteLine(date1.Subtract(date2)); // 03:00:00

//DateTime date6 = new DateTime(2015, 7, 20, 18, 30, 25);
//Console.WriteLine(date1.ToLocalTime()); // 20.07.2015 21:30:25
//Console.WriteLine(date1.ToUniversalTime()); // 20.07.2015 15:30:25
//Console.WriteLine(date1.ToLongDateString()); // 20 июля 2015 г.
//Console.WriteLine(date1.ToShortDateString()); // 20.07.2015
//Console.WriteLine(date1.ToLongTimeString()); // 18:30:25
//Console.WriteLine(date1.ToShortTimeString()); // 18:30

DateTime date1 = new DateTime(2015, 7, 20);
Console.WriteLine(date1.AddMonths(-3));
Console.WriteLine(A(date1,120));
int A (DateTime date, int i)
{
    DateTime dateInter = date.AddDays(i);
    int result = dateInter.Month;
    return result;
}