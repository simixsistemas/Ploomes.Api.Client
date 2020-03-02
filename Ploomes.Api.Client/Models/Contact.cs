using System;

namespace Ploomes.Api.Client.Models {
    public sealed class Contact {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Register { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public int StatusId { get; set; }
        public int? CompanyId { get; set; }
        public object RelationshipId { get; set; }
        public int? LineOfBusinessId { get; set; }
        public int? OriginId { get; set; }
        public int? NumberOfEmployeesId { get; set; }
        public int? ClassId { get; set; }
        public object OwnerId { get; set; }
        public object Birthday { get; set; }
        public object NextAnniversary { get; set; }
        public object PreviousAnniversary { get; set; }
        public object Note { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public object RoleId { get; set; }
        public object DepartmentId { get; set; }
        public object Skype { get; set; }
        public object Facebook { get; set; }
        public string StreetAddress { get; set; }
        public object StreetAddressNumber { get; set; }
        public object StreetAddressLine2 { get; set; }
        public object Neighborhood { get; set; }
        public int? ZipCode { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public object CurrencyId { get; set; }
        public object EmailMarketing { get; set; }
        public object CNAECode { get; set; }
        public object CNAEName { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public int? ImportId { get; set; }
        public int? CreateImportationId { get; set; }
        public object UpdateImportationId { get; set; }
        public object FirstTaskId { get; set; }
        public object FirstTaskDate { get; set; }
        public object LastInteractionRecordId { get; set; }
        public object LastDealId { get; set; }
        public object LastOrderId { get; set; }
        public int? TasksOrdination { get; set; }
        public object LeadId { get; set; }
        public bool Editable { get; set; }
        public bool Deletable { get; set; }
        public int? CreatorId { get; set; }
        public object UpdaterId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public object Key { get; set; }
        public object LastDocumentId { get; set; }
    }
}
