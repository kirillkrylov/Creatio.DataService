using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailCountLimit")]
	public class BulkEmailCountLimit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmailCategoryId")]
		public Guid EmailCategoryId { get; set; }
		[CProperty(ColumnPath ="EmailTypeId")]
		public Guid EmailTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MailingLimitCount")]
		public int MailingLimitCount { get; set; }
		[CProperty(ColumnPath ="MailingLimitPeriod")]
		public int MailingLimitPeriod { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OverlimitResponseId")]
		public Guid OverlimitResponseId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailCategory:EmailCategoryId")]
		public BulkEmailCategory EmailCategory { get; set; }
		[CProperty(Navigation ="BulkEmailResponse:OverlimitResponseId")]
		public BulkEmailResponse OverlimitResponse { get; set; }
		[CProperty(Navigation ="BulkEmailType:EmailTypeId")]
		public BulkEmailType EmailType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
