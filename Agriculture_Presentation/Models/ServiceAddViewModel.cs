﻿using System.ComponentModel.DataAnnotations;

namespace Agriculture_Presentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage ="Başlık Boş Geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string Description { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel Boş Geçilemez")]
        public string ImageUrl { get; set; }
    }
}
