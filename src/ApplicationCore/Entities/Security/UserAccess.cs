using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace PVAO.ApplicationCore.Entities.Security
{
    public class UserAccess
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string userRole { get; set; }

        [DataMember]
        public bool? adminV { get; set; }

        [DataMember]
        public bool? adminC { get; set; }

        [DataMember]
        public bool? adminU { get; set; }

        [DataMember]
        public bool? adminD { get; set; }

        [DataMember]
        public bool? veteraninfoC { get; set; }

        [DataMember]
        public bool? veteraninfoU { get; set; }

        [DataMember]
        public bool? oldageC { get; set; }

        [DataMember]
        public bool? oldageU { get; set; }

        [DataMember]
        public bool? deathC { get; set; }

        [DataMember]
        public bool? deathU { get; set; }

        [DataMember]
        public bool? burialC { get; set; }

        [DataMember]
        public bool? burialU { get; set; }

        [DataMember]
        public bool? disabilityC { get; set; }

        [DataMember]
        public bool? disabilityU { get; set; }

        [DataMember]
        public bool? educationalC { get; set; }

        [DataMember]
        public bool? educationalU { get; set; }

        [DataMember]
        public bool? accruedC { get; set; }

        [DataMember]
        public bool? accruedU { get; set; }

        [DataMember]
        public bool? BenefitU { get; set; }

        [DataMember]
        public bool? BenefitV { get; set; }

        [DataMember]
        public bool? Reassign { get; set; }

        [DataMember]
        public bool? Cancel { get; set; }

        [DataMember]
        public bool? UpdateBenefitStatus { get; set; }

        [DataMember]
        public bool? ValidationUpdates { get; set; }

        [DataMember]
        public bool? PMonitoring { get; set; }

        [DataMember]
        public bool? NMonitoring { get; set; }
    }
}
