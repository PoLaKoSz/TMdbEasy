using System;

namespace TMdbEasy.ApiInterfaces
{
    public interface ICreator
    {
        Lazy<T> GetApi<T>() where T : IBase;
    }
}
