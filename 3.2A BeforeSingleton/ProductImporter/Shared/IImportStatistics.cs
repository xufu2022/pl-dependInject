using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductImporter.Shared
{
    public interface IImportStatistics
    {
        void IncrementImportCount();
        void IncrementOutputCount();

        string GetStatistics();
    }

}
