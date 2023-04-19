using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace CMP
{
    public class Country
    {
        public int Id { get; set; }

        public string CountryName { get; set; } = string.Empty;
    }
}
