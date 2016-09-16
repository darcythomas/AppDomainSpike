using System;

namespace SecurityModule
{
    public class SecurityModule
    {
        public bool HasAccess(String userName, String action)
        {
            return true;//We pretend to call the DB here and check if the user has permission to perform an action
        }
    }
}
