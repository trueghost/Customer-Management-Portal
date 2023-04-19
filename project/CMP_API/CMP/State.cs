using System.ComponentModel.DataAnnotations;
using MessagePack;

namespace CMP
{
    public class State
    {
        public int Id { get; set; }

        public string StateName { get; set; } = string.Empty;
    }
}
