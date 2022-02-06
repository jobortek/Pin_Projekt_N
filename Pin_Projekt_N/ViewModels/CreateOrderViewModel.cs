using Pin_Projekt_N.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace Pin_Projekt_N.ViewModels
{
    public class CreateOrderViewModel
    {
        public CreateOrderViewModel(int FrameId)
        {
            this.FrameId = FrameId;
            OrderDate = DateTime.Now;
            Status = "Pending";
        }
        public CreateOrderViewModel() { }
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public int FrameId { get; set; }
    }
}
