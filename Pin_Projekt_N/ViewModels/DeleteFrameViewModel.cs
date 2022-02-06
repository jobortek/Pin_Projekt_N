﻿using System.ComponentModel.DataAnnotations;

namespace Pin_Projekt_N.ViewModels
{
    public class DeleteFrameViewModel
    {
        [Key]
        public int FrameId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }
    }
}
