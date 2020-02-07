using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Call")]
	public class Call : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath ="BeforeConnectionTime")]
		public int BeforeConnectionTime { get; set; }
		[CProperty(ColumnPath ="CalledId")]
		public string CalledId { get; set; }
		[CProperty(ColumnPath ="CallerId")]
		public string CallerId { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DirectionId")]
		public Guid DirectionId { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="HoldTime")]
		public int HoldTime { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public string IntegrationId { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="ParentCallId")]
		public string ParentCallId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RedirectingId")]
		public string RedirectingId { get; set; }
		[CProperty(ColumnPath ="RedirectionId")]
		public string RedirectionId { get; set; }
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="TalkTime")]
		public int TalkTime { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation ="ActivityResult:ResultId")]
		public ActivityResult Result { get; set; }
		[CProperty(Navigation ="CallDirection:DirectionId")]
		public CallDirection Direction { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CallFile:CallId")]
		public virtual ICollection<CallFile> CallFileByCall { get; set; }
		[CProperty(Association ="CallInFolder:CallId")]
		public virtual ICollection<CallInFolder> CallInFolderByCall { get; set; }
		[CProperty(Association ="CallInTag:EntityId")]
		public virtual ICollection<CallInTag> CallInTagByEntity { get; set; }
		[CProperty(Association ="SysActiveCall:CallId")]
		public virtual ICollection<SysActiveCall> SysActiveCallByCall { get; set; }
		[CProperty(Association ="SysActiveCall:ParentCallId")]
		public virtual ICollection<SysActiveCall> SysActiveCallByParentCall { get; set; }
		[CProperty(Association ="VwRecentCall:CallId")]
		public virtual ICollection<VwRecentCall> VwRecentCallByCall { get; set; }
		#endregion
	}
}
