using System;

namespace Common.Interfaces
{
    public interface IAppDomainProxy:IDisposable
    {
        String AssemblyName { get; }
        String TypeName { get; }
    }
}