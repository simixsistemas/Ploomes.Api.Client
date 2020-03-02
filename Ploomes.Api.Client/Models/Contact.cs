using System;

namespace Ploomes.Api.Client.Models {
    /// <remarks/>
    public sealed class Contact {
        /// <remarks/>
        public int Id { get; set; }
        /// <remarks/>
        public int? TypeId { get; set; }
        /// <remarks/>
        public string Name { get; set; }
        /// <remarks/>
        public string LegalName { get; set; }
        /// <remarks/>
        public string Register { get; set; }
        /// <remarks/>
        public string CNPJ { get; set; }
        /// <remarks/>
        public string CPF { get; set; }
        /// <remarks/>
        public int StatusId { get; set; }
        /// <remarks/>
        public int? CompanyId { get; set; }
        /// <remarks/>
        public object RelationshipId { get; set; }
        /// <remarks/>
        public int? LineOfBusinessId { get; set; }
        /// <remarks/>
        public int? OriginId { get; set; }
        /// <remarks/>
        public int? NumberOfEmployeesId { get; set; }
        /// <remarks/>
        public int? ClassId { get; set; }
        /// <remarks/>
        public object OwnerId { get; set; }
        /// <remarks/>
        public object Birthday { get; set; }
        /// <remarks/>
        public object NextAnniversary { get; set; }
        /// <remarks/>
        public object PreviousAnniversary { get; set; }
        /// <remarks/>
        public object Note { get; set; }
        /// <remarks/>
        public string Email { get; set; }
        /// <remarks/>
        public string Website { get; set; }
        /// <remarks/>
        public object RoleId { get; set; }
        /// <remarks/>
        public object DepartmentId { get; set; }
        /// <remarks/>
        public object Skype { get; set; }
        /// <remarks/>
        public object Facebook { get; set; }
        /// <remarks/>
        public string StreetAddress { get; set; }
        /// <remarks/>
        public object StreetAddressNumber { get; set; }
        /// <remarks/>
        public object StreetAddressLine2 { get; set; }
        /// <remarks/>
        public object Neighborhood { get; set; }
        /// <remarks/>
        public int? ZipCode { get; set; }
        /// <remarks/>
        public int? CityId { get; set; }
        /// <remarks/>
        public int? StateId { get; set; }
        /// <remarks/>
        public int? CountryId { get; set; }
        /// <remarks/>
        public object CurrencyId { get; set; }
        /// <remarks/>
        public object EmailMarketing { get; set; }
        /// <remarks/>
        public object CNAECode { get; set; }
        /// <remarks/>
        public object CNAEName { get; set; }
        /// <remarks/>
        public object Latitude { get; set; }
        /// <remarks/>
        public object Longitude { get; set; }
        /// <remarks/>
        public int? ImportId { get; set; }
        /// <remarks/>
        public int? CreateImportationId { get; set; }
        /// <remarks/>
        public object UpdateImportationId { get; set; }
        /// <remarks/>
        public object FirstTaskId { get; set; }
        /// <remarks/>
        public object FirstTaskDate { get; set; }
        /// <remarks/>
        public object LastInteractionRecordId { get; set; }
        /// <remarks/>
        public object LastDealId { get; set; }
        /// <remarks/>
        public object LastOrderId { get; set; }
        /// <remarks/>
        public int? TasksOrdination { get; set; }
        /// <remarks/>
        public object LeadId { get; set; }
        /// <remarks/>
        public bool Editable { get; set; }
        /// <remarks/>
        public bool Deletable { get; set; }
        /// <remarks/>
        public int? CreatorId { get; set; }
        /// <remarks/>
        public object UpdaterId { get; set; }
        /// <remarks/>
        public DateTime? CreateDate { get; set; }
        /// <remarks/>
        public DateTime? LastUpdateDate { get; set; }
        /// <remarks/>
        public object Key { get; set; }
        /// <remarks/>
        public object LastDocumentId { get; set; }
    }
}
