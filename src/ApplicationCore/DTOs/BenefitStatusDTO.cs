using System;

namespace PVAO.ApplicationCore.DTOs
{
    public class BenefitStatusDTO
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Prefix { get; set; }

        public string Claimant { get; set; }

        public int CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}