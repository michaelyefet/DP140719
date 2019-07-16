using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateBase
{
    class MongoSelectQuery : MongoTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Select * from DB im MongoDB .....");
        }
    }
}
