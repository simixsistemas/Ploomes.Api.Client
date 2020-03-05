using Ploomes.Api.Client.Enums;
using System;
using System.Collections.Generic;

namespace Ploomes.Api.Client.Models {
    /// <remarks/>
    public sealed class Deal {
        /// <remarks/>
        public int Id { get; set; }
        /// <remarks/>
        public string Title { get; set; }
        /// <remarks/>
        public int ContactId { get; set; }
        /// <remarks/>
        public string ContactName { get; set; }
        /// <remarks/>
        public int? PersonId { get; set; }
        /// <remarks/>
        public string PersonName { get; set; }
        /// <remarks/>
        public int? PipelineId { get; set; }
        /// <remarks/>
        public int? StageId { get; set; }
        /// <remarks/>
        public DealStatus StatusId { get; set; }
        /// <remarks/>
        public object FirstTaskId { get; set; }
        /// <remarks/>
        public object FirstTaskDate { get; set; }
        /// <remarks/>
        public bool HasScheduledTasks { get; set; }
        /// <remarks/>
        public int TasksOrdination { get; set; }
        /// <remarks/>
        public int? LastQuoteId { get; set; }
        /// <remarks/>
        public bool IsLastQuoteApproved { get; set; }
        /// <remarks/>
        public int? LastStageId { get; set; }
        /// <remarks/>
        public object LossReasonId { get; set; }
        /// <remarks/>
        public int? OriginId { get; set; }
        /// <remarks/>
        public int? OwnerId { get; set; }
        /// <remarks/>
        public DateTime? StartDate { get; set; }
        /// <remarks/>
        public DateTime? FinishDate { get; set; }
        /// <remarks/>
        public int? CurrencyId { get; set; }
        /// <remarks/>
        public float? Amount { get; set; }
        /// <remarks/>
        public int? StartCurrencyId { get; set; }
        /// <remarks/>
        public float? StartAmount { get; set; }
        /// <remarks/>
        public bool? Read { get; set; }
        /// <remarks/>
        public int? LastInteractionRecordId { get; set; }
        /// <remarks/>
        public int? LastOrderId { get; set; }
        /// <remarks/>
        public int? DaysInStage { get; set; }
        /// <remarks/>
        public int? Length { get; set; }
        /// <remarks/>
        public object CreateImportId { get; set; }
        /// <remarks/>
        public object UpdateImportId { get; set; }
        /// <remarks/>
        public int? LeadId { get; set; }
        /// <remarks/>
        public object OriginDealId { get; set; }
        /// <remarks/>
        public object ReevId { get; set; }
        /// <remarks/>
        public bool Editable { get; set; }
        /// <remarks/>
        public bool Deletable { get; set; }
        /// <remarks/>
        public int? CreatorId { get; set; }
        /// <remarks/>
        public int? UpdaterId { get; set; }
        /// <remarks/>
        public DateTime? CreateDate { get; set; }
        /// <remarks/>
        public DateTime? LastUpdateDate { get; set; }
        /// <remarks/>
        public object LastDocumentId { get; set; }
        /// <remarks/>
        public object DealNumber { get; set; }
        /// <summary>
        /// Tags property needs to use $expand to be inflated <see href="https://serverurl/Deals?$expand=Tags($select=Tag;$expand=Tag)"/>
        /// </summary>
        public IEnumerable<Tag> Tags { get; set; }
    }
}
