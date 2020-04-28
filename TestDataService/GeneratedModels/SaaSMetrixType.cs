using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SaaSMetrixType")]
	public class SaaSMetrixType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ARRBucketId")]
		public Guid ARRBucketId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountARRBucket:ARRBucketId")]
		public AccountARRBucket ARRBucket { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SaaSMetrix:MetrixTypeId")]
		public virtual ICollection<SaaSMetrix> SaaSMetrixByMetrixType { get; set; }
		#endregion
	}
}
