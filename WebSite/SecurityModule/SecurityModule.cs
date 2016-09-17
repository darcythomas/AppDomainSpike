using System;
using Common.Interfaces;

namespace SecurityModule
{
    public class SecurityAccessModule : IHasAccess
    {
        public bool IsAbleTo(IUserAction userAction)
        {
            //We pretend to call the DB here and check if the user has permission to perform an action
            return !userAction.Action.Equals("Launch Nukes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
