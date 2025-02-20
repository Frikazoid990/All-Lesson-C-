using ClassPerson;
using System.Runtime.CompilerServices;

Person Tom = new Person();
Person Tod = new Person();
//Получаем значение полей в переменные
string personName = Tom.name;
int personAge = Tom.age;
Console.WriteLine($"Имя: {personName} | Возраст: {personAge}\n");

//Устанавливаем новые значения
Tom.age = 18;
Tom.name = "Tom";

Tom.Print();
Tod.Print();


//class Person
//{
//    public string name = "Undefined"; // имя
//    public int age; //возраст
//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name} | Возраст: {age}");
//    }
//}

