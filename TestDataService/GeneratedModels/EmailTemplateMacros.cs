using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmailTemplateMacros")]
	public class EmailTemplateMacros : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountCommunicationTypeId")]
		public Guid AccountCommunicationTypeId { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="ColumnPath")]
		public string ColumnPath { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsInactive")]
		public bool IsInactive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Template")]
		public string Template { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:AccountCommunicationTypeId")]
		public CommunicationType AccountCommunicationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplateMacros:ParentId")]
		public EmailTemplateMacros Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmailTemplateMacros:ParentId")]
		public virtual ICollection<EmailTemplateMacros> EmailTemplateMacrosByParent { get; set; }
		#endregion
	}
}
