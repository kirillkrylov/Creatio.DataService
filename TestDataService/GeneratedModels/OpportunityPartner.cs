using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityPartner")]
	public class OpportunityPartner : BaseEntity
	{
		#region Values
		private decimal _ActualMargin;
		[CProperty(ColumnPath ="ActualMargin")]
		public decimal ActualMargin
		{
			get{return _ActualMargin;}
			set
			{
				_ActualMargin = value;
				OnPropertyChanged();
			}
		}
		private decimal _ActualMarginPct;
		[CProperty(ColumnPath ="ActualMarginPct")]
		public decimal ActualMarginPct
		{
			get{return _ActualMarginPct;}
			set
			{
				_ActualMarginPct = value;
				OnPropertyChanged();
			}
		}
		private Guid _BonusSchemeId;
		[CProperty(ColumnPath ="BonusSchemeId")]
		public Guid BonusSchemeId
		{
			get{return _BonusSchemeId;}
			set
			{
				_BonusSchemeId = value;
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
		private decimal _FixedSum;
		[CProperty(ColumnPath ="FixedSum")]
		public decimal FixedSum
		{
			get{return _FixedSum;}
			set
			{
				_FixedSum = value;
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
		private bool _IsExpenseConsidered;
		[CProperty(ColumnPath ="IsExpenseConsidered")]
		public bool IsExpenseConsidered
		{
			get{return _IsExpenseConsidered;}
			set
			{
				_IsExpenseConsidered = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
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
		private string _Note;
		[CProperty(ColumnPath ="Note")]
		public string Note
		{
			get{return _Note;}
			set
			{
				_Note = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerOwnerId;
		[CProperty(ColumnPath ="PartnerOwnerId")]
		public Guid PartnerOwnerId
		{
			get{return _PartnerOwnerId;}
			set
			{
				_PartnerOwnerId = value;
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
		private Guid _PartnerWorkConditionId;
		[CProperty(ColumnPath ="PartnerWorkConditionId")]
		public Guid PartnerWorkConditionId
		{
			get{return _PartnerWorkConditionId;}
			set
			{
				_PartnerWorkConditionId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanMarginPct;
		[CProperty(ColumnPath ="PlanMarginPct")]
		public decimal PlanMarginPct
		{
			get{return _PlanMarginPct;}
			set
			{
				_PlanMarginPct = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlannedMargin;
		[CProperty(ColumnPath ="PlannedMargin")]
		public decimal PlannedMargin
		{
			get{return _PlannedMargin;}
			set
			{
				_PlannedMargin = value;
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
		private bool _Winner;
		[CProperty(ColumnPath ="Winner")]
		public bool Winner
		{
			get{return _Winner;}
			set
			{
				_Winner = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="BonusScheme:BonusSchemeId")]
		public BonusScheme BonusScheme { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:PartnerOwnerId")]
		public Contact PartnerOwner { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:PartnerProjectRoleId")]
		public PartnerProjectRole PartnerProjectRole { get; set; }
		[CProperty(Navigation ="PartnerWorkCondition:PartnerWorkConditionId")]
		public PartnerWorkCondition PartnerWorkCondition { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OppForecastWizPartners:OpportunityPartnerId")]
		public virtual ICollection<OppForecastWizPartners> OppForecastWizPartnersByOpportunityPartner { get; set; }
		#endregion
	}
}
