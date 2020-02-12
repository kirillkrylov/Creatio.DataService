using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MessageNotifier")]
	public class MessageNotifier : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AliasNotifierId")]
		public Guid AliasNotifierId { get; set; }
		[CProperty(ColumnPath ="ClassName")]
		public string ClassName { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="HistoryV2ClassName")]
		public string HistoryV2ClassName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SchemaUId")]
		public Guid SchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MessageNotifier:AliasNotifierId")]
		public MessageNotifier AliasNotifier { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CaseMessageHistory:MessageNotifierId")]
		public virtual ICollection<CaseMessageHistory> CaseMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="LeadMessageHistory:MessageNotifierId")]
		public virtual ICollection<LeadMessageHistory> LeadMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="ListenerByNotifier:MessageNotifierId")]
		public virtual ICollection<ListenerByNotifier> ListenerByNotifierByMessageNotifier { get; set; }
		[CProperty(Association ="MessageNotifier:AliasNotifierId")]
		public virtual ICollection<MessageNotifier> MessageNotifierByAliasNotifier { get; set; }
		[CProperty(Association ="MessageNotifierBySection:MessageNotifierId")]
		public virtual ICollection<MessageNotifierBySection> MessageNotifierBySectionByMessageNotifier { get; set; }
		[CProperty(Association ="MktgActivityMessageHistory:MessageNotifierId")]
		public virtual ICollection<MktgActivityMessageHistory> MktgActivityMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="OpportunityMessageHistory:MessageNotifierId")]
		public virtual ICollection<OpportunityMessageHistory> OpportunityMessageHistoryByMessageNotifier { get; set; }
		[CProperty(Association ="VwMobileCaseMessageHistory:MessageNotifierId")]
		public virtual ICollection<VwMobileCaseMessageHistory> VwMobileCaseMessageHistoryByMessageNotifier { get; set; }
		#endregion
	}
}
