
using System;
using System.Linq;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre Poo", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "c#"));
            articles.Add(new Article("Artigo sobre Dotnet", "dotnet"));
            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var coursePoo = new Course("Fundamentos POO", "fundamentos-poo");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-c#");
            var courseDotNet = new Course("Fundamentos Dotnet", "fundamentos-dotnet");

            courses.Add(coursePoo);
            courses.Add(courseCsharp);
            courses.Add(courseDotNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista Dotnet", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

        }
    }
}