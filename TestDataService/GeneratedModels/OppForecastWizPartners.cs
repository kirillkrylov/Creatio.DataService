using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppForecastWizPartners")]
	public class OppForecastWizPartners : BaseEntity
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
		private Guid _OpportunityPartnerId;
		[CProperty(ColumnPath ="OpportunityPartnerId")]
		public Guid OpportunityPartnerId
		{
			get{return _OpportunityPartnerId;}
			set
			{
				_OpportunityPartnerId = value;
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
		private decimal _PartnerMargin;
		[CProperty(ColumnPath ="PartnerMargin")]
		public decimal PartnerMargin
		{
			get{return _PartnerMargin;}
			set
			{
				_PartnerMargin = value;
				OnPropertyChanged();
			}
		}
		private decimal _PartnerMarginPercent;
		[CProperty(ColumnPath ="PartnerMarginPercent")]
		public decimal PartnerMarginPercent
		{
			get{return _PartnerMarginPercent;}
			set
			{
				_PartnerMarginPercent = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerRoleId;
		[CProperty(ColumnPath ="PartnerRoleId")]
		public Guid PartnerRoleId
		{
			get{return _PartnerRoleId;}
			set
			{
				_PartnerRoleId = value;
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
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityPartner:OpportunityPartnerId")]
		public OpportunityPartner OpportunityPartner { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:PartnerRoleId")]
		public PartnerProjectRole PartnerRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
