using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEIndustryInKnowledgeBase")]
	public class PDEIndustryInKnowledgeBase : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PDEIndustryId")]
		public Guid PDEIndustryId { get; set; }
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="PDESubindustryId")]
		public Guid PDESubindustryId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountIndustry:PDEIndustryId")]
		public AccountIndustry PDEIndustry { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEKnowledgeBaseId")]
		public KnowledgeBase PDEKnowledgeBase { get; set; }
		[CProperty(Navigation ="SubIndustry:PDESubindustryId")]
		public SubIndustry PDESubindustry { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
