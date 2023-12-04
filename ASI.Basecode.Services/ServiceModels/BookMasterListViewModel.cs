﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.ServiceModels
{
    public class BookMasterListViewModel
    {
        public List<ReviewViewModel> Reviews { get; set; }
        public List<BookMasterViewModel> TopList { get; set; }
        public List<BookMasterViewModel> AddedList { get; set; }
        public List<BookMasterViewModel> BookList { get; set; }
        public BookListFilterModel Filters { get; set; }
        
        public class BookListFilterModel
        {
            public int BookId { get; set; }

            [DisplayName("Book Title")]
            public string BookTitle { get; set; }

            [DisplayName("Book Author")]
            public string BookAuthor { get; set; }
            public string SearchTerm { get; set; }
            public string GenreName { get; set; }
            public int GenreId { get; set; }

        }
    }
}
