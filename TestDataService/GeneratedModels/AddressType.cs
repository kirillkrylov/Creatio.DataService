using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AddressType")]
	public class AddressType : BaseEntity
	{
		#region Values
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private bool _ForAccount;
		[CProperty(ColumnPath ="ForAccount")]
		public bool ForAccount
		{
			get{return _ForAccount;}
			set
			{
				_ForAccount = value;
				OnPropertyChanged();
			}
		}
		private bool _ForContact;
		[CProperty(ColumnPath ="ForContact")]
		public bool ForContact
		{
			get{return _ForContact;}
			set
			{
				_ForContact = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
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
