using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RelationType")]
	public class RelationType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ForAccountAccount")]
		public bool ForAccountAccount { get; set; }
		[CProperty(ColumnPath ="ForAccountContact")]
		public bool ForAccountContact { get; set; }
		[CProperty(ColumnPath ="ForContactAccount")]
		public bool ForContactAccount { get; set; }
		[CProperty(ColumnPath ="ForContactContact")]
		public bool ForContactContact { get; set; }
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
		[CProperty(ColumnPath ="ReverseRelationTypeId")]
		public Guid ReverseRelationTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RelationType:ReverseRelationTypeId")]
		public RelationType ReverseRelationType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Relationship:RelationTypeId")]
		public virtual ICollection<Relationship> RelationshipByRelationType { get; set; }
		[CProperty(Association ="Relationship:ReverseRelationTypeId")]
		public virtual ICollection<Relationship> RelationshipByReverseRelationType { get; set; }
		[CProperty(Association ="RelationType:ReverseRelationTypeId")]
		public virtual ICollection<RelationType> RelationTypeByReverseRelationType { get; set; }
		[CProperty(Association ="VwAccountRelationship:RelationTypeId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByRelationType { get; set; }
		[CProperty(Association ="VwAccountRelationship:ReverseRelationTypeId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByReverseRelationType { get; set; }
		[CProperty(Association ="VwContactRelationship:RelationTypeId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByRelationType { get; set; }
		[CProperty(Association ="VwContactRelationship:ReverseRelationTypeId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByReverseRelationType { get; set; }
		#endregion
	}
}
