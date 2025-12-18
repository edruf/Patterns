using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    internal class JsonExportStrategy : IExportStrategy
    {
        public void Export(string data)
        {
            Console.WriteLine($"[JSON] Форматируем данные в компактный JSON: {{ \"data\": \"{data}\" }}");
        }
    }
}
