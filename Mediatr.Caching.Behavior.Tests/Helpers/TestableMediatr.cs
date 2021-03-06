﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Mediatr.Caching.Behavior.Tests.Helpers
{
    public class TestableMediatr
    {
        public class Request : IRequest<Response>
        {
            public string Id { get; set; }
        }

        public class Response
        {
            public string Id { get; set; }
        }

        public class CacheableProfile: ICachingProfile<Request,Response>
        {
            public string GetCacheKey(Request request)
            {
                return request.Id;
            }

            public DateTime GetExpirationDate(Request request)
            {
                return DateTime.Now;
            }
        }
        public class Handler:IRequestHandler<Request,Response>
        {
            public Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
