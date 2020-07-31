﻿using System.Threading.Tasks;
using TmdbEasy.DTO.Companies;
using TmdbEasy.Extensions;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Apis
{
    internal class CompaniesApi : ICompaniesApi
    {
        private readonly RequestHandler _requestHandler;

        internal CompaniesApi(RequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public async Task<CompanyDetails> GetDetailsAsync(int companyId, string apiKey = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"company/{companyId}")
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<CompanyDetails>(restRequest);
        }

        public async Task<MoviesByCompany> GetMoviesAsync(int companyId, string apiKey = null, string language = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"company/{companyId}")
                .AddLanguage(language)
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<MoviesByCompany>(restRequest);
        }

        public async Task<CompanyList> SearchAsync(string customQuery, string apiKey = null, int page = 1)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"search/company")
                .AddApiKey(apiKey)
                .AddCustomQuery(customQuery)
                .AddPage(page);

            return await _requestHandler.ExecuteAsync<CompanyList>(restRequest);
        }
    }
}
