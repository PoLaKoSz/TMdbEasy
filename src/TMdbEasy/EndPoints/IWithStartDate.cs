using System;

namespace TMdbEasy.EndPoints
{
    public interface IWithStartDate
    {
        IWithStartDate WithStartDate(DateTime time);
    }
}
