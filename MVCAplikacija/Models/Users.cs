using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAplikacija.Models
{
    public class Users
    {

        public int Id { get; set; }
        [DisplayName("Ime")]
        public string Name { get; set; }
        [DisplayName ("Elektronska pošta")]
        public string Email { get; set; }
        // from the group model (Entity framework will connect the Primarykey and forign key)
        public Groups Group { get; set; }
        [DisplayName("Grupa")]
        public int GroupId { get; set; } = 1;

    }
}
