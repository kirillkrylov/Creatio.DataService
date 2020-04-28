using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactCorrespondence")]
	public class ContactCorrespondence : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDeleted")]
		public bool IsDeleted { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SocialAccountName")]
		public string SocialAccountName { get; set; }
		[CProperty(ColumnPath ="SourceAccountId")]
		public Guid SourceAccountId { get; set; }
		[CProperty(ColumnPath ="SourceContactId")]
		public string SourceContactId { get; set; }
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:SourceId")]
		public CommunicationType Source { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SocialAccount:SourceAccountId")]
		public SocialAccount SourceAccount { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
