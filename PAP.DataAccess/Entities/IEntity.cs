using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.DataAccess.Entities
{
    public interface IEntity
    {
        string UniqueIdentifier { set; get; }
    }
}
