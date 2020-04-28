using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Gift")]
	public class Gift : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AvailableQuantity")]
		public int AvailableQuantity { get; set; }
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
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmployeeScore:GiftId")]
		public virtual ICollection<EmployeeScore> EmployeeScoreByGift { get; set; }
		[CProperty(Association ="GiftFile:GiftId")]
		public virtual ICollection<GiftFile> GiftFileByGift { get; set; }
		[CProperty(Association ="GiftInFolder:GiftId")]
		public virtual ICollection<GiftInFolder> GiftInFolderByGift { get; set; }
		[CProperty(Association ="GiftInTag:EntityId")]
		public virtual ICollection<GiftInTag> GiftInTagByEntity { get; set; }
		#endregion
	}
}
