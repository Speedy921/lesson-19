using lesson_19;

Console.WriteLine("****Fun with System.Object*****\n");
//эти обьекты идентичны
Person p1 = new Person("Homer", "Simpson", 50, "111-11-1111");
Person p2 = new Person("Homer", "Simpson", 50, "111-11-1111");

//получить строковые версии обьектов
Console.WriteLine("p1.ToString() = {0}", p1.ToString());
Console.WriteLine("p2.ToString() = {0}", p2.ToString());

//протестировать переопределенный метод Equals()
Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

//протестировать хэщ коды
//по прежнему используется хэш значение SSN
Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

Console.WriteLine();

//изменить хначение Age обьекта p2 и протестировать снова 
p2.Age = 45;
Console.WriteLine("p1.ToString() = {0}", p1.ToString());
Console.WriteLine("p2.ToString() = {0}", p2.ToString());
Console.WriteLine("p1 = p2?: {0}", p1.Equals(p2));

//по прежднему используется хэш значеение SSN
Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
Console.ReadLine();

    