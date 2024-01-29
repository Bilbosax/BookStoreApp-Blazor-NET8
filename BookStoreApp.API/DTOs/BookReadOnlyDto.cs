﻿using BookStoreApp.API.Data;

namespace BookStoreApp.API.DTOs
{
    public class BookReadOnlyDto : BaseDto
    {
        public string? Title { get; set; }

        public string? Image { get; set; }

        public decimal? Price { get; set; }

        public int? AuthorId { get; set; }

        public string? AuthorName { get; set; }
    }
}
