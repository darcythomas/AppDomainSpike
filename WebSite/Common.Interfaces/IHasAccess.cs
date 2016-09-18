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
}
