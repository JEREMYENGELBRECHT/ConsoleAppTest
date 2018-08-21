using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleAppTest.persistance.Models
{
    [Table("Tester")]
    public class TesterModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
}
