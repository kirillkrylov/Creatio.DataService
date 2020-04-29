using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLanguage")]
	public class SysLanguage : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private bool _IsUsed;
		[CProperty(ColumnPath ="IsUsed")]
		public bool IsUsed
		{
			get{return _IsUsed;}
			set
			{
				_IsUsed = value;
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
		[CProperty(Association ="Contact:LanguageId")]
		public virtual ICollection<Contact> ContactByLanguage { get; set; }
		[CProperty(Association ="EmailTemplateLang:LanguageId")]
		public virtual ICollection<EmailTemplateLang> EmailTemplateLangByLanguage { get; set; }
		[CProperty(Association ="MailboxSyncSettings:MessageLanguageId")]
		public virtual ICollection<MailboxSyncSettings> MailboxSyncSettingsByMessageLanguage { get; set; }
		[CProperty(Association ="RegionalLanguagePartner:LanguageId")]
		public virtual ICollection<RegionalLanguagePartner> RegionalLanguagePartnerByLanguage { get; set; }
		[CProperty(Association ="SubscriptionExpirationEmailByLanguage:SysLanguageId")]
		public virtual ICollection<SubscriptionExpirationEmailByLanguage> SubscriptionExpirationEmailByLanguageBySysLanguage { get; set; }
		[CProperty(Association ="SysAdminUnit:DateTimeFormatId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByDateTimeFormat { get; set; }
		[CProperty(Association ="SysCulture:LanguageId")]
		public virtual ICollection<SysCulture> SysCultureByLanguage { get; set; }
		[CProperty(Association ="VwEventInContact:LanguageId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByLanguage { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:DateTimeFormatId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByDateTimeFormat { get; set; }
		[CProperty(Association ="VwSysAdminUnit:DateTimeFormatId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByDateTimeFormat { get; set; }
		#endregion
	}
}
