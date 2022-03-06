using System;
using System.ComponentModel.DataAnnotations;

namespace MyOfficeSpace.Domain
{
    public class BaseEntity
    {
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateAdded { get; set; }        
        public DateTime DateModified { get; set; }
    }
}
