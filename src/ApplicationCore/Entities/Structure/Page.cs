using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class Page : BaseEntity<int>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string PageName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string UrlPath { get; set; }

        [DataMember]
        public int? ParentMenu { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public int Order { get; set; }

        [DataMember]
        public bool IsParent { get; set; }

        [DataMember]
        public bool Visible { get; set; }

        [DataMember]
        public bool AccessibleByAll { get; set; }

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }
    }
}
