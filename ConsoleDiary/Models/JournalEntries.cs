using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleDiary
{
    public class JournalEntries
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}