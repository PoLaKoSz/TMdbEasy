﻿using System.Threading.Tasks;
using TMdbEasy.TmdbObjects.Other;

namespace TMdbEasy.ApiInterfaces
{
    public interface ICreditApi : IBase
    {
        /// <summary>
        /// Get a movie or TV credit details by id.
        /// </summary>
        /// <param name="id">Typically taken from a previous api call</param>       
        /// <returns></returns>
        Task<Credits> GetDetailsAsync(int id);
    }
}
