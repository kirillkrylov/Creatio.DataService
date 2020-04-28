using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysProcessData")]
	public class VwSysProcessData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		[CProperty(Association ="Opportunity:OpportunitySubProcessId")]
		public virtual ICollection<Opportunity> OpportunityByOpportunitySubProcess { get; set; }
		#endregion
	}
}
