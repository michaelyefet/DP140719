using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBase
{
    class MongoDeleteQuery : MongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Delete from DB im MongoDB .....");
        }
    }
}
