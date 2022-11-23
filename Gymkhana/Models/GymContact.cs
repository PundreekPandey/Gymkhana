using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gymkhana.Models
{
    public class GymContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}