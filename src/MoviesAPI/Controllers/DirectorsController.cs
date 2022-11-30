﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesShared.DTO;
using MoviesShared;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly DirectorsRepository directorsRepository;
        public DirectorsController(DirectorsRepository directorsRepository)
        {
            this.directorsRepository = directorsRepository;
        }

        /// <summary>
        /// Returns async list of directors from repository
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<DirectorsDto>> GetListAsync()
        {
            return await directorsRepository.GetDirectorsAsync();
        }
    }
}
