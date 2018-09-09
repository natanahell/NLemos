﻿using NLemos.Domain.Entities;

namespace NLemos.Infrastructure.Data
{
    public class PostRepositoryCache : DataCache<Post>
    {
        public PostRepositoryCache() : base(24)
        {

        }
    }
}
