using System;
using System.ComponentModel.DataAnnotations;

namespace Pin_Projekt_N.ViewModels
{
    public class EditOrderViewModel
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public int FrameId { get; set; }
    }
}
