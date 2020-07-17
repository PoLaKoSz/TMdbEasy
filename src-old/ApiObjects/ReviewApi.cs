﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMdbEasy.ApiInterfaces;
using TMdbEasy.TmdbObjects;
using static TMdbEasy.REngine;
using TMdbEasy.TmdbObjects.Other;

namespace TMdbEasy.ApiObjects
{
    internal class ReviewApi : IReviewApi
    {
        public async Task<Reviews> GetDetailsAsync(int id)
        {
            var content = await CallApiAsync($"{Url}review/{id}?api_key={ApiKey}").ConfigureAwait(false);
            return DeserializeJson<Reviews>(content);
        }
    }
}
