using Builder.Builders;
using Builder.Main;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Baker baker = new Baker();  // создаем объект пекаря
            BreadBuilder builder = new RyeBreadBuilder(); // создаем билдер для ржаного хлеба
            Bread ryeBread = baker.Bake(builder); // выпекаем

            Console.WriteLine(ryeBread.ToString());
            
            
            builder = new WheatBreadBuilder(); // cоздаем билдер для пшеничного хлеба
            Bread wheatBread = baker.Bake(builder);
            Console.WriteLine(wheatBread.ToString());

            Console.ReadKey();
        }
    }
}
