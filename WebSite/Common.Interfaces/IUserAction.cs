using System;

namespace Common.Interfaces
{
    public interface IUserAction
    {
        String UserName { get; set; }
        String Action { get; set; }
    }
}