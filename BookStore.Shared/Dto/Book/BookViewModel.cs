﻿using System;
using System.ComponentModel.DataAnnotations;
using BookStore.DB.Domain;

namespace BookStore.Shared.Dto.Book
{
    public sealed class BookViewModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        [Display(Name = "Image")]
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Page numbers")]
        public int PageNumbers { get; set; }
        [Display(Name = "Publish date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }
        [Display(Name = "Authors")]
        public string[] Authors { get; set; }
    }
}
