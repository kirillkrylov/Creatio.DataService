using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupCloudCaseDefValue")]
	public class SupCloudCaseDefValue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupCloudTriggerId")]
		public Guid SupCloudTriggerId { get; set; }
		[CProperty(ColumnPath ="SupOriginId")]
		public Guid SupOriginId { get; set; }
		[CProperty(ColumnPath ="SupServiceItemId")]
		public Guid SupServiceItemId { get; set; }
		[CProperty(ColumnPath ="SupSubtypeId")]
		public Guid SupSubtypeId { get; set; }
		[CProperty(ColumnPath ="SupSupportLevelId")]
		public Guid SupSupportLevelId { get; set; }
		[CProperty(ColumnPath ="SupTypeId")]
		public Guid SupTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseOrigin:SupOriginId")]
		public CaseOrigin SupOrigin { get; set; }
		[CProperty(Navigation ="CaseSubtype:SupSubtypeId")]
		public CaseSubtype SupSubtype { get; set; }
		[CProperty(Navigation ="CaseType:SupTypeId")]
		public CaseType SupType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RoleInServiceTeam:SupSupportLevelId")]
		public RoleInServiceTeam SupSupportLevel { get; set; }
		[CProperty(Navigation ="ServiceItem:SupServiceItemId")]
		public ServiceItem SupServiceItem { get; set; }
		[CProperty(Navigation ="SupCloudTrigger:SupCloudTriggerId")]
		public SupCloudTrigger SupCloudTrigger { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
