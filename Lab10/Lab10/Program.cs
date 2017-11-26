using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab10
{
    class Program
    {
        private static void Exam_CollectionChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: Console.WriteLine($"A new object added to collection");
                    break;
                case NotifyCollectionChangedAction.Remove: Console.WriteLine($"An object was removed from collection");
                    break;
                case NotifyCollectionChangedAction.Replace: Console.WriteLine($"Objects were replaced");
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Создать необобщённую коллекцию
            ArrayList arrayList = new ArrayList();
            
            //a) Заполнить 5-ю случайными числами
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(10));
            }
            
            //b) Добавить строку
            arrayList.Add("Efremov Dmitry");
            
            //c) Удалить заданный элемент
            Console.WriteLine("Collection ITEMS before deleting:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }
            arrayList.RemoveAt(3);
            Console.WriteLine();
            
            //d) Вывести количество элементов и коллекцию
            Console.WriteLine("Collection ITEMS after deleting: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine($"Num of ITEMS: {arrayList.Count}");

            //e) Поиск в коллекции значения
            object toFind = "Efremov Dmitry";
            if (arrayList.Contains(toFind))
            {
                Console.WriteLine($"Item /{toFind}/ exists in arrayList");
            }
            else Console.WriteLine($"Item /{toFind}/ doesn't exist in arrayList");

            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"--------------------------------------");

            //Создать обобщённую коллекцию
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string> {
                { "first", "A" },
                { "second", "B" },
                { "third", "C" }
            };

            //a) Вывести коллекцию на консоль
            Console.WriteLine($"Pairs of Keys and Values: ");
            foreach (KeyValuePair<string, string> pairs in dictionary)
            {
                Console.WriteLine($"Key: {pairs.Key}, Value: {pairs.Value}");
            }

            Console.WriteLine();
            
            //b) Удалить из коллекции n элементов
            dictionary.Remove("second");
            
            Console.WriteLine($"Pairs of Keys and Values after deleting: ");
            foreach (KeyValuePair<string, string> pairs in dictionary)
            {
                Console.WriteLine($"Key: {pairs.Key}, Value: {pairs.Value}");
            }

            Console.WriteLine();

            //c) Создайте вторую коллекцию и заполните ее данными из первой коллекции
            List<string> list = new List<string>(dictionary.Values);

            //d) Вывести вторую коллекцию 
            Console.WriteLine($"Items in list");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Enter a value to find: ");
            var c = Console.ReadLine();
            if (list.Contains(c))
            {
                Console.WriteLine($"Set value /{c}/ exists in list");
            }
            else Console.WriteLine($"Set value /{c}/ doesn't exist");

            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"--------------------------------------");

            //a) Повторить с пользовательским типом данных
            Exam exam = new Exam("Mafs");
            List<Exam> examList = new List<Exam> {
                exam
            };

            Console.WriteLine($"Items of Exam in list:");
            foreach (Exam item in examList)
            {
                Console.WriteLine($"{item.NameOfExam}");
            }
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine($"--------------------------------------");

            //Создать ObservableCollection<T>, подписаться на событие
            ObservableCollection<Exam> observableCollection = new ObservableCollection<Exam> {
                new Exam("Russian"),
                new Exam("OOP"),
                new Exam("CS")
            };

            Console.WriteLine("Items in observable collection: ");
            foreach (var item in observableCollection)
            {
                Console.WriteLine($"{item.NameOfExam}");
            }

            observableCollection.CollectionChanged += Exam_CollectionChange;
            Console.WriteLine();
            observableCollection.Add(new Exam("Math"));

            Console.WriteLine("Items in observable collection: ");
            foreach (var item in observableCollection)
            {
                Console.WriteLine($"{item.NameOfExam}");
            }

            Console.WriteLine();
            observableCollection.Remove(observableCollection[0]);
            

            Console.WriteLine("Items in observable collection: ");
            foreach (var item in observableCollection)
            {
                Console.WriteLine($"{item.NameOfExam}");
            }

            Console.WriteLine();
            observableCollection[2] = new Exam("Physics");
            
            Console.WriteLine("Items in observable collection: ");
            foreach (var item in observableCollection)
            {
                Console.WriteLine($"{item.NameOfExam}");
            }


        }

        
    }
}
