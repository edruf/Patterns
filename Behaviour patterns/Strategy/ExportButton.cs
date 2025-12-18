using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class ExportButton
    {
        private IExportStrategy _exportStrategy;
        public string Data { get; set; }

        public ExportButton(IExportStrategy exportStrategy)
        {
            _exportStrategy = exportStrategy;
        }

        public void SetExportStrategy(IExportStrategy strategy) 
        { 
            _exportStrategy = strategy;
        }

        public void Click()
        {
            _exportStrategy.Export(Data);
        }
    }
}
