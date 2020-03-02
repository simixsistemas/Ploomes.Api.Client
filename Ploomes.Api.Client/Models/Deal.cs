using Ploomes.Api.Client.Enums;
using System;

namespace Ploomes.Api.Client.Models {
    public sealed class Deal {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public int? PipelineId { get; set; }
        public int? StageId { get; set; }
        public DealStatus StatusId { get; set; }
        public object FirstTaskId { get; set; }
        public object FirstTaskDate { get; set; }
        public bool HasScheduledTasks { get; set; }
        public int TasksOrdination { get; set; }
        public int? LastQuoteId { get; set; }
        public bool IsLastQuoteApproved { get; set; }
        public int? LastStageId { get; set; }
        public object LossReasonId { get; set; }
        public int? OriginId { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? CurrencyId { get; set; }
        public float? Amount { get; set; }
        public int? StartCurrencyId { get; set; }
        public float? StartAmount { get; set; }
        public bool? Read { get; set; }
        public int? LastInteractionRecordId { get; set; }
        public int? LastOrderId { get; set; }
        public int? DaysInStage { get; set; }
        public int? Length { get; set; }
        public object CreateImportId { get; set; }
        public object UpdateImportId { get; set; }
        public int? LeadId { get; set; }
        public object OriginDealId { get; set; }
        public object ReevId { get; set; }
        public bool Editable { get; set; }
        public bool Deletable { get; set; }
        public int? CreatorId { get; set; }
        public int? UpdaterId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public object LastDocumentId { get; set; }
        public object DealNumber { get; set; }
    }
}
