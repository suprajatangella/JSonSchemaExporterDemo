using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NJsonSchema;
using System.IO;
//using Newtonsoft.Json.Schema;

namespace JSonSchemaExporterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var schema = JsonSchema.FromType<Product>();

            var prodSchema = schema.ToJson();

            File.WriteAllText("ProductSchema.json", prodSchema);

            Console.WriteLine(prodSchema);
            Console.ReadLine();
        }
    }
}
