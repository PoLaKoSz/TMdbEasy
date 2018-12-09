using System;
using TMdbEasy.DataAccessLayer;
using TMdbEasy.EndPoints;

namespace TMdbEasy
{
    public class BaseSecureEndPoint : SecureEndPoint, IWithID, IWithCountry, IWithLanguage, IWithEndDate, IWithStartDate
    {
        public BaseSecureEndPoint(string path)
            : base(path) { }



        public IWithID WithID(int id)
        {
            Query["id"] = id.ToString();

            return this;
        }

        public IWithLanguage WithLanguage(string language)
        {
            Query["language"] = language;

            return this;
        }

        public IWithStartDate WithStartDate(DateTime time)
        {
            Query["start_date"] = "";

            return this;
        }

        public IWithEndDate WithEndDate(DateTime time)
        {
            Query["end_date"] = "";

            return this;
        }

        public IWithCountry WithCountry(string country)
        {
            Query["country"] = country;

            return this;
        }
    }
}
