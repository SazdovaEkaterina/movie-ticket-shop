using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketShop.Domain.DomainModels
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public Genre Genre { get; set; }

        public Movie(string title, Genre genre)
        {
            Title = (title == null) ? string.Empty : title;
            Genre = genre;
        }
    }
}
