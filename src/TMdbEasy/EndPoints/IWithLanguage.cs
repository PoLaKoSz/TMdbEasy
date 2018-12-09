using System;

namespace TMdbEasy.EndPoints
{
    public interface IWithLanguage
    {
        IWithLanguage WithLanguage(string language);
    }
}
