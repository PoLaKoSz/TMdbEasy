using System;

namespace TMdbEasy.EndPoints
{
    public interface IWithEndDate
    {
        IWithEndDate WithEndDate(DateTime Time);
    }
}
