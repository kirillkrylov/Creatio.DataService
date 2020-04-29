using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmGDPR")]
	public class BpmGDPR : BaseEntity
	{
		#region Values
		private string _BpmName;
		[CProperty(ColumnPath ="BpmName")]
		public string BpmName
		{
			get{return _BpmName;}
			set
			{
				_BpmName = value;
				OnPropertyChanged();
			}
		}
		private string _BpmNotes;
		[CProperty(ColumnPath ="BpmNotes")]
		public string BpmNotes
		{
			get{return _BpmNotes;}
			set
			{
				_BpmNotes = value;
				OnPropertyChanged();
			}
		}
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
		[CProperty(Association ="BpmGDPRFile:BpmGDPRId")]
		public virtual ICollection<BpmGDPRFile> BpmGDPRFileByBpmGDPR { get; set; }
		[CProperty(Association ="BpmGDPRInFolder:BpmGDPRId")]
		public virtual ICollection<BpmGDPRInFolder> BpmGDPRInFolderByBpmGDPR { get; set; }
		[CProperty(Association ="BpmGDPRInTag:EntityId")]
		public virtual ICollection<BpmGDPRInTag> BpmGDPRInTagByEntity { get; set; }
		[CProperty(Association ="BpmPreferences:BpmGDPRId")]
		public virtual ICollection<BpmPreferences> BpmPreferencesByBpmGDPR { get; set; }
		[CProperty(Association ="Contact:BpmManageDataPrivacyId")]
		public virtual ICollection<Contact> ContactByBpmManageDataPrivacy { get; set; }
		[CProperty(Association ="Employee:BpmManageDataPrivacyId")]
		public virtual ICollection<Employee> EmployeeByBpmManageDataPrivacy { get; set; }
		[CProperty(Association ="Lead:BpmGDPRId")]
		public virtual ICollection<Lead> LeadByBpmGDPR { get; set; }
		[CProperty(Association ="VwEventInContact:BpmManageDataPrivacyId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByBpmManageDataPrivacy { get; set; }
		[CProperty(Association ="VwLead:BpmGDPRId")]
		public virtual ICollection<VwLead> VwLeadByBpmGDPR { get; set; }
		#endregion
	}
}
