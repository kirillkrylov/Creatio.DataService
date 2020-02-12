using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AddressType")]
	public class AddressType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ForAccount")]
		public bool ForAccount { get; set; }
		[CProperty(ColumnPath ="ForContact")]
		public bool ForContact { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
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
		[CProperty(Association ="Account:AddressTypeId")]
		public virtual ICollection<Account> AccountByAddressType { get; set; }
		[CProperty(Association ="AccountAddress:AddressTypeId")]
		public virtual ICollection<AccountAddress> AccountAddressByAddressType { get; set; }
		[CProperty(Association ="Contact:AddressTypeId")]
		public virtual ICollection<Contact> ContactByAddressType { get; set; }
		[CProperty(Association ="ContactAddress:AddressTypeId")]
		public virtual ICollection<ContactAddress> ContactAddressByAddressType { get; set; }
		[CProperty(Association ="Lead:AddressTypeId")]
		public virtual ICollection<Lead> LeadByAddressType { get; set; }
		[CProperty(Association ="LeadAddress:AddressTypeId")]
		public virtual ICollection<LeadAddress> LeadAddressByAddressType { get; set; }
		[CProperty(Association ="LeadQualification:LeadContactAddressTypeId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadContactAddressType { get; set; }
		[CProperty(Association ="LeadQualification:LeadAccountAddressTypeId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadAccountAddressType { get; set; }
		[CProperty(Association ="RestrictedParties:AddressTypeId")]
		public virtual ICollection<RestrictedParties> RestrictedPartiesByAddressType { get; set; }
		[CProperty(Association ="VwClientAddress:AddressTypeId")]
		public virtual ICollection<VwClientAddress> VwClientAddressByAddressType { get; set; }
		[CProperty(Association ="VwEventInContact:AddressTypeId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByAddressType { get; set; }
		[CProperty(Association ="VwLead:AddressTypeId")]
		public virtual ICollection<VwLead> VwLeadByAddressType { get; set; }
		#endregion
	}
}
