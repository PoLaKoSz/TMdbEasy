﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMdbEasy.TmdbObjects;
using TMdbEasy.TmdbObjects.Other;

namespace TMdbEasy.ApiInterfaces
{
    public interface INetworksApi : IBase
    {
        /// <summary>
        /// Get the details of a network.
        /// </summary>
        /// <param name="id">Network Id, typically taken from a previous api call</param>       
        /// <returns></returns>
        Task<Network> GetDetailsAsync(int id);
    }
}
