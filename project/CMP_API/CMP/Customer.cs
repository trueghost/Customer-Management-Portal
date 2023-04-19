using System.ComponentModel.DataAnnotations;

namespace CMP
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string PhNo { get; set; } = string.Empty;

        [StringLength(200)]

        public string Email { get; set; } = string.Empty;

        public int CountryId { get; set; }

        public Country? Country { get; set; }

        public int StateId { get; set; }

        public State? State { get; set; }

        [StringLength(200)]

        public string Remarks { get; set; } = string.Empty;

        public string GSTEnable { get; set; } = string.Empty;

        public string CreatedDate { get; set; } = string.Empty;

        public int Status { get; set; }

    }
}
