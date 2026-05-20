namespace _01_Tasks_and_class_Task;

class Program
{
    delegate void Message(); // 1. Объявляем делегат
    static void Hello() => Console.WriteLine("Hello METANIT.COM");
    
    static void Main(string[] args)
    {
        Message mes;            // 2. Создаем переменную делегата
        mes = Hello;            // 3. Присваиваем этой переменной адрес метода
        mes();                  // 4. Вызываем метод
        
    }
}