﻿using System.Collections.Generic;
using System.Linq;
using BookRanking.DTO;

namespace BookRanking.Logic
{
    public interface IPublisherService
    {
        void AddPublisher(PublisherDTO publisher);
        void RemovePublisher(PublisherDTO publisher);
        IEnumerable<PublisherDTO> GetAllPublishers();
    }
}