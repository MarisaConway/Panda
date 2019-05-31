using System;
using System.ComponentModel.DataAnnotations;
namespace Pandas.Models
{
    public class Panda
    {
        [Key]
        public int PandaId {get; set;}
        [Required]
        public string Type {get; set;}
        [Required]
        public string Location {get;set;}
        [Required]
        public int Cuteness {get;set;}
        [Required]
        public int Weight{get;set;}
        [Required]
        public string Description{get;set;}
        public DateTime Created_At {get;set;} = DateTime.Now;
        public DateTime Updated_At {get;set;} = DateTime.Now;



    }
}