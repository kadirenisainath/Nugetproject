using System;

struct People
{
    public string Name;
    public int Age;
    public string description;
    public string marriagestatus;
    public int childrens;

};




public class MembersBio
    {
        public static void Main(string[] args)
        {
            People Person1;
            People Person2;
            People Person3;
            People Person4;

            Person1.Name= "Murali";
            Person1.Age= 37;
            Person1.description = "currently he is stying in Hyd";
            Person1.marriagestatus = "married";
            Person1.childrens = 2;

            Person2.Name = "Sunitha";
            Person2.Age = 31;
            Person2.description = "she is stying in julur";
            Person2.marriagestatus = "married";
            Person2.childrens = 3;

            Person3.Name = "sumalatha";
            Person3.Age = 30;
            Person3.description = "she is stying in pochampally";
            Person3.marriagestatus = "married";
            Person3.childrens = 1;

            Person4.Name = "Sainath";
            Person4.Age = 26;
            Person4.description = "he is stying in RedlaRepaka";
            Person4.marriagestatus = "null";
            Person4.childrens = 0;

            Console.WriteLine("person1name: {0}",Person1.Name);
            Console.WriteLine("person1age: {0}",Person1.Age);
            Console.WriteLine("person1description: {0}",Person1.description);
            Console.WriteLine("person1marriagestatus: {0}",Person1.marriagestatus);
            Console.WriteLine("person1childrens: {0}",Person1.childrens);

            Console.WriteLine("person2name: {0}",Person2.Name);
            Console.WriteLine("person2age: {0}", Person2.Age);
            Console.WriteLine("person2description: {0}", Person2.description);
            Console.WriteLine("person2marriagestatus: {0}",Person2.marriagestatus);
            Console.WriteLine("person2childrens: {0}",Person2.childrens);

            Console.WriteLine("person3name: {0}",Person3.Name);
            Console.WriteLine("person3age: {0}", Person3.Age);
            Console.WriteLine("person3decription: {0}", Person3.description);
            Console.WriteLine("person3marriagestatus: {0}", Person3.marriagestatus);
            Console.WriteLine("person3childrens: {0}", Person3.childrens);

        Console.WriteLine("person4name: {0}", Person4.Name);
        Console.WriteLine("person4age: {0}", Person4.Age);
        Console.WriteLine("person4decription: {0}", Person4.description);
        Console.WriteLine("person4marriagestatus: {0}", Person4.marriagestatus);
        Console.WriteLine("person4childrens: {0}", Person4.childrens);

        Console.ReadKey();
        }
    }
