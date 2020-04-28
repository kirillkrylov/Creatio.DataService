using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LandingType")]
	public class LandingType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SchemaUidId")]
		public Guid SchemaUidId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:SchemaUidId")]
		public VwSysSchemaInfo SchemaUid { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GeneratedWebForm:TypeId")]
		public virtual ICollection<GeneratedWebForm> GeneratedWebFormByType { get; set; }
		[CProperty(Association ="VwLandingInCampaign:TypeId")]
		public virtual ICollection<VwLandingInCampaign> VwLandingInCampaignByType { get; set; }
		#endregion
	}
}
