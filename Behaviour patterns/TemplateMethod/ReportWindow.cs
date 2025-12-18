using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    internal class ReportWindow : UIWindow
    {
        protected override void OnFetchData()
        {
            Console.WriteLine("SQL: Считаем тяжелый финансовый отчет за год...");
        }

        protected override void OnRender()
        {
            Console.WriteLine("Render: Рисуем графики и таблицы.");
        }
    }
}
