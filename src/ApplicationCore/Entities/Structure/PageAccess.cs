﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace PVAO.ApplicationCore.Entities.Structure
{
    public class PageAccess
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PageId { get; set; }

        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public bool CanCreate { get; set; }

        [DataMember]
        public bool CanRead { get; set; }

        [DataMember]
        public bool CanUpdate { get; set; }

        [DataMember]
        public bool CanDelete { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public int? UpdatedBy { get; set; }

        [DataMember]
        public DateTime? DateUpdated { get; set; }
    }
}
