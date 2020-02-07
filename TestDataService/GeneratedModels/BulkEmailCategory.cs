using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailCategory")]
	public class BulkEmailCategory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmail:CategoryId")]
		public virtual ICollection<BulkEmail> BulkEmailByCategory { get; set; }
		[CProperty(Association ="BulkEmailCountLimit:EmailCategoryId")]
		public virtual ICollection<BulkEmailCountLimit> BulkEmailCountLimitByEmailCategory { get; set; }
		[CProperty(Association ="BulkEmailLaunchOption:CategoryId")]
		public virtual ICollection<BulkEmailLaunchOption> BulkEmailLaunchOptionByCategory { get; set; }
		[CProperty(Association ="VwBulkEmailSendWaiting:CategoryId")]
		public virtual ICollection<VwBulkEmailSendWaiting> VwBulkEmailSendWaitingByCategory { get; set; }
		#endregion
	}
}
