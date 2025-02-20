//Person tom = new Person();          // вызов 1-ого конструктора без параметров
//Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
//Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами

//tom.Print();          // Имя: Неизвестно  Возраст: 18
//bob.Print();          // Имя: Bob  Возраст: 18
//sam.Print();          // Имя: Sam  Возраст: 25

//class Person
//{
//    public string name;
//    public int age;
//    public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор
//    public Person(string n) { name = n; age = 18; }         // 2 конструктор
//    public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {name}  Возраст: {age}");
//    }
//}


using System.Threading.Channels;
/* Ключевое слово this
 * Предоставляет ссылку на текущий экземпляр/ объект класса
 * Например когда у нас в классе поля называются name и age
 * Допустим в методе или конструкторе мы зададим параметры с такими же имена
 * То к полям класса нам следует обращаться this.name... и.тд 
 * То есть конкретно указывая, что будет использоваться этот объект класса
 */
//class Person
//{
//    public string name;
//    public int age;
//    public Person() { name = "Неизвестно"; age = 18; }
//    public Person(string name) { this.name = name; age = 18; }
//    public Person(string name, int age) { this.name = name; this.age = age; }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*
 * 
 * Цепочка вызова конструктора
 * P.S. Честно говоря не понял как это конкретно работает надо будет потом ещё раз всё прочитать
 * 
*/

//Person tom = new Person();
//tom.Print();
//class Person
//{
//    public string name;
//    public int age;
//    public Person() : this("Неизвестно")    // первый конструктор
//    { }
//    public Person(string name) : this(name, 18) // второй конструктор
//    { }
//    public Person(string name, int age)     // третий конструктор
//    {
//        this.name = name;
//        this.age = age;
//    }
//    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
//}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*
 * 
 * 
 * Первичные конструкторы
 * 
 * 
*/

//var tom = new Person("Tom", 38);
//tom.Print();

//public class Person(string name, int age)
//{
//    public Person(string name) : this(name, 18) { }
//    public void Print() => Console.WriteLine($"name: {name}, age: {age}");
//}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*
 * 
 * 
 * Инициализатор объектов
 * 
 * 
*/

Person tom = new Person() { name = "Tom", company = { title = "Microsoft" } };
tom.Print();          // Имя: Tom  Компания: Microsoft

class Person
{
    public string name;
    public Company company;
    public Person()
    {
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
}

class Company
{
    public string title = "Unknown";
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*
 * 
 * 
 * Деконструкторы
 * 
 * 
*/

//Person person = new Person("Tom", 33);

//(_, int age) = person;

//Console.WriteLine(age);    // 33
//class Person
//{
//    string name;
//    int age;
//    public Person(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public void Deconstruct(out string personName, out int personAge)
//    {
//        personName = name;
//        personAge = age;
//    }
//}