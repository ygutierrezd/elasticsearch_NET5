using Elasticsearch_NET;
using System;

namespace Ejecutar
{
    class Program
    {
        static void Main(string[] args)
        {
            ESLowLevelClient es = new ESLowLevelClient();
            es.con();
            Console.WriteLine("Hello World!");
        }
    }
}
