using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmPreferences")]
	public class BpmPreferences : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BpmEntityID")]
		public string BpmEntityID { get; set; }
		[CProperty(ColumnPath ="BpmEntitySchemaUId")]
		public string BpmEntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="BpmGDPRId")]
		public Guid BpmGDPRId { get; set; }
		[CProperty(ColumnPath ="BpmLandingId")]
		public Guid BpmLandingId { get; set; }
		[CProperty(ColumnPath ="BpmLink")]
		public string BpmLink { get; set; }
		[CProperty(ColumnPath ="BpmObjectId")]
		public Guid BpmObjectId { get; set; }
		[CProperty(ColumnPath ="BpmOK")]
		public bool BpmOK { get; set; }
		[CProperty(ColumnPath ="BpmPermissionDueDate")]
		public DateTime BpmPermissionDueDate { get; set; }
		[CProperty(ColumnPath ="BpmPreferenceTypeId")]
		public Guid BpmPreferenceTypeId { get; set; }
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmGDPR:BpmGDPRId")]
		public BpmGDPR BpmGDPR { get; set; }
		[CProperty(Navigation ="BpmPreferenceType:BpmPreferenceTypeId")]
		public BpmPreferenceType BpmPreferenceType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GeneratedWebForm:BpmLandingId")]
		public GeneratedWebForm BpmLanding { get; set; }
		[CProperty(Navigation ="SysModuleFolder:BpmObjectId")]
		public SysModuleFolder BpmObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
