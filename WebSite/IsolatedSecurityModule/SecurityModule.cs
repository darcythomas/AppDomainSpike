﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolatedSecurityModule
{
    public class SecurityModule
    {
        public bool HasAccess(String userName, String action)
        {
            return true;
        }
    }
}