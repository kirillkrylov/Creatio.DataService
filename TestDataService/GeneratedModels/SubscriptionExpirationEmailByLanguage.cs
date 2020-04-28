using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SubscriptionExpirationEmailByLanguage")]
	public class SubscriptionExpirationEmailByLanguage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ErrorMessage")]
		public string ErrorMessage { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SubscriptionExpirationEmailHistoryId")]
		public Guid SubscriptionExpirationEmailHistoryId { get; set; }
		[CProperty(ColumnPath ="SysLanguageId")]
		public Guid SysLanguageId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityStatus:StatusId")]
		public ActivityStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SubscriptionExpirationEmailHistory:SubscriptionExpirationEmailHistoryId")]
		public SubscriptionExpirationEmailHistory SubscriptionExpirationEmailHistory { get; set; }
		[CProperty(Navigation ="SysLanguage:SysLanguageId")]
		public SysLanguage SysLanguage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SubscriptionExpirationReceiver:SubscriptionExpirationEmailByLanguageId")]
		public virtual ICollection<SubscriptionExpirationReceiver> SubscriptionExpirationReceiverBySubscriptionExpirationEmailByLanguage { get; set; }
		#endregion
	}
}
