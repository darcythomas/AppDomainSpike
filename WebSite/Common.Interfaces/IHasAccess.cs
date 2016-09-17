using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{

    public interface IHasAccess
    {
        bool IsAbleTo(IUserAction userAction);
    }

    public interface IUserAction
    {
         String UserName { get; set; }
         String Action { get; set; }
    }
}
