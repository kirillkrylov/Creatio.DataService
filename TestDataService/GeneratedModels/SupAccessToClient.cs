using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupAccessToClient")]
	public class SupAccessToClient : BaseEntity
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupAccess")]
		public string SupAccess { get; set; }
		[CProperty(ColumnPath ="SupAccessTypeId")]
		public Guid SupAccessTypeId { get; set; }
		[CProperty(ColumnPath ="SupCaseId")]
		public Guid SupCaseId { get; set; }
		[CProperty(ColumnPath ="SupConfItemId")]
		public Guid SupConfItemId { get; set; }
		[CProperty(ColumnPath ="SupIsActual")]
		public bool SupIsActual { get; set; }
		[CProperty(ColumnPath ="SupNote")]
		public string SupNote { get; set; }
		[CProperty(ColumnPath ="SupSiteAddress")]
		public string SupSiteAddress { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:SupCaseId")]
		public Case SupCase { get; set; }
		[CProperty(Navigation ="ConfItem:SupConfItemId")]
		public ConfItem SupConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupAccessType:SupAccessTypeId")]
		public SupAccessType SupAccessType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupAccessToClientFile:SupAccessToClientId")]
		public virtual ICollection<SupAccessToClientFile> SupAccessToClientFileBySupAccessToClient { get; set; }
		#endregion
	}
}
