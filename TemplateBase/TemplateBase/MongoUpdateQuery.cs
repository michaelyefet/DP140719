using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBase
{
    class MongoUpdateQuery : MongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Update DB im Mongo .....");
        }
    }
}
