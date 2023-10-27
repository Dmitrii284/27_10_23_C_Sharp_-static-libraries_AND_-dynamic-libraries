/*
 \\\\\\\\\\\\\\\\\\\\
Какие библиотеки бывают
\\\\\\\\\\\\\\\\\\\\\\\

 С++ поддерживает два основных типа библиотек: статические и динамические.

Статические библиотеки (static libraries) содержат предварительно скомпилированные определения функций и данных,
которые при компоновке присоединяются к исполняемому файлу. Это увеличивает размер исполняемого файла,
но уменьшает время загрузки программы и может улучшить производительность,
поскольку не требуется загружать внешние библиотеки во время исполнения.

Динамические библиотеки (dynamic libraries) или общие библиотеки (shared libraries) содержат указатели на функции и данные.
Во время компоновки они не присоединяются к исполняемому файлу, 
а загружаются при запуске программы или используются уже загруженными библиотеками.
Это позволяет уменьшить размер исполняемого файла и ускорить запуск программы, 
но может вызвать проблемы с совместимостью и потребовать наличие соответствующих библиотек в системе для работы программы.

С# поддерживает два основных типа библиотек - статические и динамические библиотеки, которые также называются файлами.
Статические библиотеки имеют расширение “.lib”, а динамические - “.dll”
\\\\\\\\\\\\\\\\\\\
Отличие
\\\\\\\\\\\\\\\\\
Отличие статических и динамических библиотек заключается в том, как они подключаются к исполняемому файлу и взаимодействуют с ним.

Статические библиотеки присоединяются к исполняемому файлу на этапе компиляции и становятся его частью. Это увеличивает размер исполняемого файла, но обеспечивает более быструю загрузку и лучшую производительность, так как не требуется загрузка внешних библиотек во время выполнения программы.
Статические библиотеки обычно имеют расширение .a или .lib.
Динамические библиотеки не присоединяются к исполняемому файлу во время компиляции, 
а загружаются во время выполнения программы. Это уменьшает размер исполняемого файла и ускоряет его загрузку,
но требует наличия соответствующих библиотек в операционной системе для работы программы и может вызвать проблемы с совместимостью.
Динамические библиотеки обычно имеют расширение .so, .dll или .bundle.

\\\\\\\\\\\\\\\\\\
Нагет Закидж - NuGet Packages ( Если код подчеркивается красным То нужно установить его через NuGet Packages ( смотри фото)
\\\\\\\\\\\\\\

NuGet Packages в C# - это библиотеки классов и другие ресурсы, которые могут быть добавлены в проект C# для расширения 
его функциональности. Они содержат классы, структуры, интерфейсы, делегаты, перечисления, атрибуты, события, операторы, 
методы и свойства, которые могут использоваться в коде проекта.

NuGet Packages работают, позволяя разработчикам легко управлять зависимостями между проектами и библиотеками,
а также быстро обновлять и удалять пакеты. NuGet.org - это официальный репозиторий пакетов NuGet, 
где можно найти множество пакетов для различных целей.

Для использования NuGet Packages в проекте C#, нужно выполнить следующие шаги:

Установить пакет NuGet Package Manager в Visual Studio.
Создать новый проект или открыть существующий проект в Visual Studio.
В Solution Explorer, щелкнуть правой кнопкой мыши на проект и выбрать “Manage NuGet Packages”.
В окне “Manage NuGet Packages”, ввести имя пакета в поле поиска и нажать кнопку “Install”.
После установки пакета, он будет автоматически добавлен в проект и доступен для использования в коде.
Примечание: перед установкой нового пакета убедитесь, что в проекте нет конфликтов с уже установленными пакетами.


\\\\\\\\\\\\\\
LINO    в С# ЧТО ТАКОЕ LINO? И для чего она нужна и как с этим работать?   
\\\\\\\\\\\\\

LInq (Language Integrated Query) - это интегрированная в язык технология,
которая позволяет использовать запросы LINQ to Objects, LINQ to SQL и другие виды запросов LINQ в коде C#.
Она позволяет работать с данными в более выразительной и удобной форме, используя различные операции, такие как фильтрация,
сортировка, группировка и т.д.

LINQ используется для работы с различными источниками данных, такими как массивы, списки, базы данных и другие.
Она позволяет писать код, который выглядит более похожим на то, что он делает, вместо того, 
чтобы писать сложный код для обработки данных.

Чтобы начать работать с LINQ, вам нужно добавить ссылку на сборку System.Linq,
а затем использовать LINQ-методы в вашем коде. Например, вы можете использовать метод Where для фильтрации элементов в массиве,
метод OrderBy для сортировки элементов и метод Select для выбора определенных свойств элементов.

Вот пример использования LINQ для выборки элементов из массива:

using System;
using System.Linq;

class Program
{
    static void Main()
    {

LInq (Language Integrated Query) – это интегрированная в язык C# технология,
позволяющая использовать запросы к данным в более выразительной форме, включая операции по фильтрации,
сортировке, группировке и другим действиям. Она упрощает работу с данными, делая код более понятным и удобным для чтения.
Для использования LInq нужно добавить ссылку на библиотеку System.Linq и использовать соответствующие методы в коде, 
например, Where для фильтрации, OrderBy для сортировки, Select для выбора нужных свойств.

\\\\\\\\\\\\\\\\
Если мы работаем с XML то подключаем LInq с XML (using System.Xml.Linq;)
\\\\\\\\\\\\\\\\\\\\

Если вы работаете с XML документами в C#, вам может потребоваться использовать LINQ to XML (LInq to XML).
Для этого вам нужно подключить пространство имен System.Xml.Linq:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq; // <-- добавьте эту строку

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xmlDocument =
                new XElement("Root",
                    new XElement("Element1", "Value1"),
                    new XElement("Element2", "Value2")
                );

            // используем LInq для работы с XML
            IEnumerable<XElement> elements =
                from element in xmlDocument.Elements()
                where (string)element == "Value1"
                select element;

            foreach (XElement element in elements)
            {
                Console.WriteLine((string)element);
            }

            Console.ReadLine();
        }
    }
}


\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
Задача
Решить задачу на С# с помощью LInq . Создайте структуру «Поезд» с полями: номер поезда, пункт отправления,
пункт назначения, время отправления и время прибытия. Добавьте свойство Info, выводящее информацию о поезде.
Добавьте метод, получающий в качестве параметра фактическое время прибытия поезда и сравнивающий его с временем,
указанным в экземпляре структуры. Из метода верните сообщение: 
«Поезд опоздал на (указать время) минут» или «Поезд пришел вовремя».
Создайте список (List) для хранения объектов структуры «Поезд». Заполните данный список пятью экземплярами.
Реализуйте добавление нового экземпляра структуры (введенного с клавиатуры) в список. 
Отсортируйте список по пункту отправления (в порядке возрастания). 
Реализуйте поиск и удаление экземпляра структуры из списка по введённому номеру поезда.
 */

using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace _27_10_23_C_Sharp__static_libraries_AND__dynamic_libraries
{

    internal class Program
    {
       public static void Main(string[] args)
        {
        //    Console.WriteLine("Hello, World!");
        //    List<Student> students = new List<Student>()
        //    {
        //        new Student{Name = "John", Age = 20, GPA = 4.8},
        //        new Student{ Name = "Alic", Age = 22, GPA = 4.3},
        //        new Student{ Name = "Mihael", Age = 24, GPA = 4.9},
        //        new Student{ Name = "Emili", Age = 21, GPA = 4.7},
        //        new Student{ Name = "David", Age = 26, GPA = 4.1},
        //        new Student{ Name = "Rustik", Age = 18, GPA = 4.2},
        //    };

            //    var selectedStudents = students.Where(s => s.GPA > 4.5 && s.Age > 25).Select(s => s.Name);
            //    foreach(var studentName in selectedStudents)
            //    {
            //        Console.WriteLine(studentName);
            //    }
            //public class Student
            //{
            //public string Name { get; set; }// Так как это авто свойство то пиишем с большой буквы Name
            //public int Age { get; set; }
            //public double GPA { get; set; }
            //}

            //Task - Trein
            //List<Train> trains = new List<Train>()
            //{
            //    new Train{TreinNumber = 1, DeparturePoint = "Москва", Destination ="Санкт-Петербург",
            //                TimeDeparture = DateTime.Parse("10:00"), TimeArrival = DateTime.Parse("20:00")},
            //    new Train{TreinNumber = 2, DeparturePoint = "Владивосток", Destination = "Москва",
            //                TimeDeparture = DateTime.Parse("11:40"), TimeArrival = DateTime.Parse("10:20")},
            //    new Train{TreinNumber = 3, DeparturePoint = "Оренбург", Destination = "Екатеринбург",
            //                TimeDeparture = DateTime.Parse("20:15"), TimeArrival = DateTime.Parse("12:00")},
            //    new Train{TreinNumber = 4, DeparturePoint = "Астрахань", Destination = "Уренгой",
            //                TimeDeparture = DateTime.Parse("15:00"), TimeArrival = DateTime.Parse("05:00")},
            //    new Train{TreinNumber = 5, DeparturePoint = "Сочи", Destination = "Екатеринбург",
            //                TimeDeparture = DateTime.Parse("15:30"), TimeArrival = DateTime.Parse("22:20")}
            //};

            //    Console.WriteLine("Список поездов:");
            //    foreach(var train in trains)
            //    {
            //        train.PrintInfo();
            //    }
            //    Train newTrain = new Train();
            //    Console.Write("Номер поезда: ");
            //    newTrain.TreinNumber = int.Parse(Console.ReadLine());
            //    Console.Write("Пункт отправления: ");
            //    newTrain.DeparturePoint = Console.ReadLine();
            //    Console.Write("Пункт назначения: ");
            //    newTrain.Destination = Console.ReadLine();
            //    Console.Write("Время отправления: ");
            //    newTrain.TimeDeparture = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Время прибытия: ");
            //    newTrain.TimeArrival = DateTime.Parse(Console.ReadLine());
            //    trains.Add(newTrain);

            //    Console.WriteLine("Список поездов после добавления нового поезда:");
            //    foreach (var train in trains)
            //    {
            //        train.PrintInfo();
            //    }


            //    Console.WriteLine("Введите номер поезда, который хотите найти и удалить:");
            //    int trainNumber = int.Parse(Console.ReadLine());

            //    Train trainToDelete = trains.FirstOrDefault(train => train.TreinNumber == trainNumber);

            //        trainToDelete.PrintInfo();


            //    if (trainToDelete.Equals(default(Train)))
            //    {
            //        Console.WriteLine("Поезд с таким номером не найден");
            //    }
            //    else
            //    {
            //        trains.Remove(trainToDelete);
            //        Console.WriteLine($"Поезд номер {trainNumber} удален");
            //    }


            //    Console.WriteLine("Список поездов после удаления выбранного поезда:");
            //    foreach (var train in trains)
            //    {
            //        train.PrintInfo();
            //    }

            //    trains = trains.OrderBy(train => train.DeparturePoint).ToList();

            //    Console.WriteLine("Список поездов после сортировки по пункту отправления:");
            //    foreach (var train in trains)
            //    {
            //        train.PrintInfo();
            //    }
            //    Console.ReadLine();

            //Task_ "books"
        string filePath = (@"C:\Users\Ж - 17\Documents\Feofanov\27_10_23_C_Sharp_ static libraries_AND_ dynamic libraries\27_10_23_C_Sharp_ static libraries_AND_ dynamic libraries\books.xml");
        XDocument doc = XDocument.Load(filePath);
        var books = doc.Descendants("book");

            // Вывести все названия книг, отсортированные по названию в алфавитном порядке
            var sortedBooks = books.OrderBy(book => book.Element("title").Value);
            Console.WriteLine("Сортированные по названию книги:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book.Element("title").Value);
            }

            Console.WriteLine();

            // Посчитать количество книг каждого жанра
            var genreCounts = books.GroupBy(book => book.Element("genre").Value)
                                   .Select(group => new { Genre = group.Key, Count = group.Count() });
            Console.WriteLine("Количество книг по жанрам:");
            foreach (var genreCount in genreCounts)
            {
                Console.WriteLine($"Жанр: {genreCount.Genre}, Количество: {genreCount.Count}");
            }

            Console.WriteLine();

            // Получить список авторов, у которых есть книги с годом издания до 1900
            var authorsBefore1900 = books.Where(book => int.Parse(book.Element("year").Value) < 1900)
                                         .Select(book => book);
       }
    }
}