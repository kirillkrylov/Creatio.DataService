using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysActiveCall")]
	public class SysActiveCall : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BeforeConnectionTime")]
		public int BeforeConnectionTime { get; set; }
		[CProperty(ColumnPath ="CallContext")]
		public string CallContext { get; set; }
		[CProperty(ColumnPath ="CallContextType")]
		public string CallContextType { get; set; }
		[CProperty(ColumnPath ="CalledId")]
		public string CalledId { get; set; }
		[CProperty(ColumnPath ="CallerId")]
		public string CallerId { get; set; }
		[CProperty(ColumnPath ="CallId")]
		public Guid CallId { get; set; }
		[CProperty(ColumnPath ="ConnectionStartTime")]
		public DateTime ConnectionStartTime { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrentHoldStartTime")]
		public DateTime CurrentHoldStartTime { get; set; }
		[CProperty(ColumnPath ="CurrentTalkStartTime")]
		public DateTime CurrentTalkStartTime { get; set; }
		[CProperty(ColumnPath ="DirectionId")]
		public Guid DirectionId { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="HoldTime")]
		public int HoldTime { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public string IntegrationId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentCallId")]
		public Guid ParentCallId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RedirectingId")]
		public string RedirectingId { get; set; }
		[CProperty(ColumnPath ="RedirectionId")]
		public string RedirectionId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="State")]
		public string State { get; set; }
		[CProperty(ColumnPath ="TalkTime")]
		public int TalkTime { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Call:CallId")]
		public Call Call { get; set; }
		[CProperty(Navigation ="Call:ParentCallId")]
		public Call ParentCall { get; set; }
		[CProperty(Navigation ="CallDirection:DirectionId")]
		public CallDirection Direction { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
