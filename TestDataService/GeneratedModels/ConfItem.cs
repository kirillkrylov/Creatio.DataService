using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ConfItem")]
	public class ConfItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="CancelDate")]
		public DateTime CancelDate { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InventoryNumber")]
		public string InventoryNumber { get; set; }
		[CProperty(ColumnPath ="ModelId")]
		public Guid ModelId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentConfItemId")]
		public Guid ParentConfItemId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PurchaseDate")]
		public DateTime PurchaseDate { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="SerialNumber")]
		public string SerialNumber { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Street")]
		public string Street { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="WarrantyUntil")]
		public DateTime WarrantyUntil { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation ="ConfigItemCategory:CategoryId")]
		public ConfigItemCategory Category { get; set; }
		[CProperty(Navigation ="ConfigItemModel:ModelId")]
		public ConfigItemModel Model { get; set; }
		[CProperty(Navigation ="ConfigItemStatus:StatusId")]
		public ConfigItemStatus Status { get; set; }
		[CProperty(Navigation ="ConfigItemType:TypeId")]
		public ConfigItemType Type { get; set; }
		[CProperty(Navigation ="ConfItem:ParentConfItemId")]
		public ConfItem ParentConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ConfItemId")]
		public virtual ICollection<Activity> ActivityByConfItem { get; set; }
		[CProperty(Association ="Case:ConfItemId")]
		public virtual ICollection<Case> CaseByConfItem { get; set; }
		[CProperty(Association ="ChangeConfItem:ConfItemId")]
		public virtual ICollection<ChangeConfItem> ChangeConfItemByConfItem { get; set; }
		[CProperty(Association ="ConfItem:ParentConfItemId")]
		public virtual ICollection<ConfItem> ConfItemByParentConfItem { get; set; }
		[CProperty(Association ="ConfItemAddress:ConfItemId")]
		public virtual ICollection<ConfItemAddress> ConfItemAddressByConfItem { get; set; }
		[CProperty(Association ="ConfItemFile:ConfItemId")]
		public virtual ICollection<ConfItemFile> ConfItemFileByConfItem { get; set; }
		[CProperty(Association ="ConfItemInCase:ConfItemId")]
		public virtual ICollection<ConfItemInCase> ConfItemInCaseByConfItem { get; set; }
		[CProperty(Association ="ConfItemInFolder:ConfItemId")]
		public virtual ICollection<ConfItemInFolder> ConfItemInFolderByConfItem { get; set; }
		[CProperty(Association ="ConfItemInTag:EntityId")]
		public virtual ICollection<ConfItemInTag> ConfItemInTagByEntity { get; set; }
		[CProperty(Association ="ConfItemRelationship:ConfItemAId")]
		public virtual ICollection<ConfItemRelationship> ConfItemRelationshipByConfItemA { get; set; }
		[CProperty(Association ="ConfItemRelationship:ConfItemBId")]
		public virtual ICollection<ConfItemRelationship> ConfItemRelationshipByConfItemB { get; set; }
		[CProperty(Association ="ConfItemUser:ConfItemId")]
		public virtual ICollection<ConfItemUser> ConfItemUserByConfItem { get; set; }
		[CProperty(Association ="Problem:ConfItemId")]
		public virtual ICollection<Problem> ProblemByConfItem { get; set; }
		[CProperty(Association ="ReleaseConfItem:ConfItemId")]
		public virtual ICollection<ReleaseConfItem> ReleaseConfItemByConfItem { get; set; }
		[CProperty(Association ="ServiceInConfItem:ConfItemId")]
		public virtual ICollection<ServiceInConfItem> ServiceInConfItemByConfItem { get; set; }
		[CProperty(Association ="VwConfItemRelationship:ConfItemAId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByConfItemA { get; set; }
		[CProperty(Association ="VwConfItemRelationship:ConfItemBId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByConfItemB { get; set; }
		[CProperty(Association ="VwServiceInConfItem:ConfItemId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByConfItem { get; set; }
		#endregion
	}
}
