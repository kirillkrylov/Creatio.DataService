using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InvestorComment")]
	public class InvestorComment : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath ="BlindCopyRecipient")]
		public string BlindCopyRecipient { get; set; }
		[CProperty(ColumnPath ="Body")]
		public string Body { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CopyRecipient")]
		public string CopyRecipient { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvestorId")]
		public Guid InvestorId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Recipient")]
		public string Recipient { get; set; }
		[CProperty(ColumnPath ="Sender")]
		public string Sender { get; set; }
		[CProperty(ColumnPath ="Subject")]
		public string Subject { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Investor:InvestorId")]
		public Investor Investor { get; set; }
		[CProperty(Navigation ="InvestorCommentType:TypeId")]
		public InvestorCommentType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvestorCommentFile:InvestorCommentId")]
		public virtual ICollection<InvestorCommentFile> InvestorCommentFileByInvestorComment { get; set; }
		#endregion
	}
}
