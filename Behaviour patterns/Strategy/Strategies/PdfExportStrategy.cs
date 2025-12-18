using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    internal class PdfExportStrategy : IExportStrategy
    {
        public void Export(string data)
        {
            Console.WriteLine($"[PDF] Создаем красивый PDF-документ: {data}");
        }
    }
}
