using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Application.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The ItemNumber is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Numero de Item")]
        public string ItemNumber { get;  set; }

        [Required(ErrorMessage = "The Location is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Locación")]
        public string Location { get;  set; }

        [Required(ErrorMessage = "The Location is Required")]
        [MinLength(2)]
        [DisplayName("Descripción")]
        public string Description { get; set; }

        [MinLength(2)]
        [DisplayName("Numero de parte")]
        public string PartNumber { get;  set; }

        public int VendorId { get;  set; }
        public string VendorName { get; set; }
        public int CategoryID { get;  set; }
        public string DescriptionCategory { get; set; }
        public string UM { get;  set; }
        public int Quantity { get;  set; }
        public int Max { get;  set; }
        public int Min { get;  set; }
        public DateTime DateCreated { get;  set; }
        public DateTime? DateModified { get;  set; }
        public string Username { get;  set; }
        //public StockStatus Status { get; set; }
        public string Company { get;  set; }
    }
}
