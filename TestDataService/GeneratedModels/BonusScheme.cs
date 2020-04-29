using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusScheme")]
	public class BonusScheme : BaseEntity
	{
		#region Values
		private bool _ArbitraryAmount;
		[CProperty(ColumnPath ="ArbitraryAmount")]
		public bool ArbitraryAmount
		{
			get{return _ArbitraryAmount;}
			set
			{
				_ArbitraryAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _Condition;
		[CProperty(ColumnPath ="Condition")]
		public decimal Condition
		{
			get{return _Condition;}
			set
			{
				_Condition = value;
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
		private Guid _PartnerProjectRoleId;
		[CProperty(ColumnPath ="PartnerProjectRoleId")]
		public Guid PartnerProjectRoleId
		{
			get{return _PartnerProjectRoleId;}
			set
			{
				_PartnerProjectRoleId = value;
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
		[CProperty(Navigation ="PartnerProjectRole:PartnerProjectRoleId")]
		public PartnerProjectRole PartnerProjectRole { get; set; }
		[CProperty(Navigation ="SysLookup:SysLookupId")]
		public SysLookup SysLookup { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:BonusSchemeId")]
		public virtual ICollection<Lead> LeadByBonusScheme { get; set; }
		[CProperty(Association ="Opportunity:BonusSchemeId")]
		public virtual ICollection<Opportunity> OpportunityByBonusScheme { get; set; }
		[CProperty(Association ="OpportunityPartner:BonusSchemeId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByBonusScheme { get; set; }
		[CProperty(Association ="VwLead:BonusSchemeId")]
		public virtual ICollection<VwLead> VwLeadByBonusScheme { get; set; }
		#endregion
	}
}
