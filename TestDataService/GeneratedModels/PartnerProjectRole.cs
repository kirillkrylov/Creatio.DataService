using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PartnerProjectRole")]
	public class PartnerProjectRole : BaseEntity
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysEntitySchemaUId;
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId
		{
			get{return _SysEntitySchemaUId;}
			set
			{
				_SysEntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysLookupId;
		[CProperty(ColumnPath ="SysLookupId")]
		public Guid SysLookupId
		{
			get{return _SysLookupId;}
			set
			{
				_SysLookupId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysPageSchemaUId;
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId
		{
			get{return _SysPageSchemaUId;}
			set
			{
				_SysPageSchemaUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysLookup:SysLookupId")]
		public SysLookup SysLookup { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:PartnerRoleId")]
		public virtual ICollection<Account> AccountByPartnerRole { get; set; }
		[CProperty(Association ="BonusScheme:PartnerProjectRoleId")]
		public virtual ICollection<BonusScheme> BonusSchemeByPartnerProjectRole { get; set; }
		[CProperty(Association ="InternalRequest:OpportunityPartnerRoleId")]
		public virtual ICollection<InternalRequest> InternalRequestByOpportunityPartnerRole { get; set; }
		[CProperty(Association ="OppForecastWizPartners:PartnerRoleId")]
		public virtual ICollection<OppForecastWizPartners> OppForecastWizPartnersByPartnerRole { get; set; }
		[CProperty(Association ="Opportunity:PartnerProjectRoleId")]
		public virtual ICollection<Opportunity> OpportunityByPartnerProjectRole { get; set; }
		[CProperty(Association ="OpportunityPartner:PartnerProjectRoleId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByPartnerProjectRole { get; set; }
		[CProperty(Association ="OpportunityPartnerHistory:PartnerProjectRoleId")]
		public virtual ICollection<OpportunityPartnerHistory> OpportunityPartnerHistoryByPartnerProjectRole { get; set; }
		#endregion
	}
}
