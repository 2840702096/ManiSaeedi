﻿using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.Entities
{
    public class CommendationLetters
    {
        public CommendationLetters()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}