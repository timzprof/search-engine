using System;
using System.ComponentModel.DataAnnotations;

namespace SearchEngine.Models
{
    public class SearchResult
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
    }
}
