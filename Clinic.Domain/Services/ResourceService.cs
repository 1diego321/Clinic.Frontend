﻿using Clinic.CrossCutting.Abstractions;
using Clinic.CrossCutting.Routes;
using Clinic.Data.Abstractions;
using Clinic.Domain.Abstractions;
using System.Threading.Tasks;

namespace Clinic.Domain.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IRepository _repository;
        private readonly ResourceRoutes _routes;
        private readonly IUriGenerator _uriGenerator;

        public ResourceService(IRepository repository,
                               ResourceRoutes routes,
                               IUriGenerator uriGenerator)
        {
            _repository = repository;
            _routes = routes;
            _uriGenerator = uriGenerator;
        }

        public async Task<(byte[], string)> GetProfileImage(int id, string authToken)
        {
            string url = _uriGenerator.AddQueryStringParams(_routes.Resource, new { id }).ToString();

            var image = await _repository.GetFile(url, authToken);

            return image;
        }
    }
}