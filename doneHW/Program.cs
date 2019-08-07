using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doneHW
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //LinqBegin6. Дана строковая последовательность.
        //Найти сумму длин всех строк, входящих в данную последовательность.
        List<string> str = new List<string> { "1qwerty", "cqwertyc", "cqwe", "c" };
        int sum = str.Sum(x => x.Length);
        Console.WriteLine("LinqBegin6. Length: " + sum);
                Console.ReadLine();


        //LinqBegin11. Дана последовательность непустых строк. 
        //Получить строку, состоящую из начальных символов всех строк исходной последовательности.
        List<string> str1 = new List<string> { "1qwerty", "cqwertyc", "rqwe", "f2" };
        str[0] = str[0].Substring(0, 1);
        string newCol = str1.Aggregate((x, y) => $"{x}{y.Substring(0, 1)}");
        Console.Write("LinqBegin11. Length: " + newCol);
                Console.ReadLine();

            
        //LinqBegin6. Дана строковая последовательность.
        //Найти сумму длин всех строк, входящих в данную последовательность.
        List<string> str4 = new List<string> { "1qwerty", "cqwertyc", "cqwe", "c" };
        int sum1 = str4.Sum(x => x.Length);
        Console.WriteLine("LinqBegin6. Length: " + sum1);
                Console.ReadLine();

        //LinqBegin22. Дано целое число K (> 0) и строковая последовательность A.
        //Строки последовательности содержат только цифры и заглавные буквы латинского алфавита.
        //Извлечь из A все строки длины K, оканчивающиеся цифрой, отсортировав их по возрастанию.
        int k = 5;
        List<string> str2 = new List<string> { "1qwerty", "cqwertyc", "rqwe5", "rqwef", "rqwe3", "f2" };
        IEnumerable<string> res = str2.Where(x => x.Length == k && Char.IsDigit(x.ToCharArray()[x.Length - 1])).OrderBy(x => x.ToCharArray()[x.Length - 1]);
        Console.WriteLine("LinqBegin22. Strings: ");
                Console.WriteLine(String.Join(", ", res.ToArray()));
                Console.ReadKey();

        //LinqBegin36. Дана последовательность непустых строк. 
        //Получить последовательность символов, которая определяется следующим образом: 
        //если соответствующая строка исходной последовательности имеет нечетную длину, то в качестве
        //символа берется первый символ этой строки; в противном случае берется последний символ строки.
        //Отсортировать полученные символы по убыванию их кодов.
        List<string> str3 = new List<string> { "1qwerty", "cqwertyc", "rqwe5", "rqwef", "rqwe3", "f2" };
        IOrderedEnumerable<string> res2 = str3.Select(x => x.Length % 2 != 0 ? x.Substring(0, 1) : x.Substring(x.Length - 1)).OrderBy(x => x);
        Console.WriteLine("LinqBegin36. Res: ");
                Console.WriteLine(String.Join(", ", res2.ToArray()));
                Console.ReadKey();

            
        //LinqBegin6. Дана строковая последовательность.
        //Найти сумму длин всех строк, входящих в данную последовательность.
        List<string> str5 = new List<string> { "1qwerty", "cqwertyc", "cqwe", "c" };
        int sum2 = str5.Sum(x => x.Length);
        Console.WriteLine("LinqBegin6. Length: " + sum2);
                Console.ReadLine();


        //LinqBegin22. Дано целое число K (> 0) и строковая последовательность A.
        //Строки последовательности содержат только цифры и заглавные буквы латинского алфавита.
        //Извлечь из A все строки длины K, оканчивающиеся цифрой, отсортировав их по возрастанию.
        int k1 = 5;
        List<string> str6 = new List<string> { "1qwerty", "cqwertyc", "rqwe5", "rqwef", "rqwe3", "f2" };
        IEnumerable<string> res3 = str6.Where(x => x.Length == k1 && Char.IsDigit(x.ToCharArray()[x.Length - 1])).OrderBy(x => x.ToCharArray()[x.Length - 1]);
        Console.WriteLine("LinqBegin22. Strings: ");
                Console.WriteLine(String.Join(", ", res3.ToArray()));
                Console.ReadKey();


        //LinqBegin48.Даны строковые последовательности A и B; все строки в каждой последовательности различны, 
        //имеют ненулевую длину и содержат только цифры и заглавные буквы латинского алфавита. 
        //Найти внутреннее объединение A и B, каждая пара которого должна содержать строки одинаковой длины.
        //Представить найденное объединение в виде последовательности строк, содержащих первый и второй элементы пары, 
        //разделенные двоеточием, например, «AB: CD». Порядок следования пар должен определяться порядком 
        //первых элементов пар(по возрастанию), а для равных первых элементов — порядком вторых элементов пар(по убыванию).
        List<string> a = new List<string> { "1qwerty", "cqwertyc", "rqwe5", "rqwef", "rqwe3", "f2" };
        List<string> b = new List<string> { "rdsf", "fgd", "ddd", "fgde", "bw", "qgreht" };
        var res7 = a.Join(b, x => x.Length, y => y.Length, (x, y) => x.Substring(0, 2) + " : " + y.Substring(0, 2));
        Console.WriteLine("LinqBegin48. Res: ");
                foreach (String value in res7)
                {
                    Console.WriteLine(value);
                }
    Console.ReadKey();
        }
    }
}
