using System.Collections.Generic;

namespace TMdbEasy.TmdbObjects.Companies
{
    public class CompanyDetails
    {
        public object Description { get; set; }
        public string Headquarters { get; set; }
        public string Homepage { get; set; }
        public int Id { get; set; }
        public object Logo_path { get; set; }
        public string Name { get; set; }
        public object Parent_company { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public string Logo_path { get; set; }
        public string Name { get; set; }
    }

    public class CompanyList
    {
        public int Page { get; set; }
        public List<Company> Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
