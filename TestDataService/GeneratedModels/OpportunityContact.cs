using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityContact")]
	public class OpportunityContact : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactLoyalityId;
		[CProperty(ColumnPath ="ContactLoyalityId")]
		public Guid ContactLoyalityId
		{
			get{return _ContactLoyalityId;}
			set
			{
				_ContactLoyalityId = value;
				OnPropertyChanged();
			}
		}
		private string _ContactMotivator;
		[CProperty(ColumnPath ="ContactMotivator")]
		public string ContactMotivator
		{
			get{return _ContactMotivator;}
			set
			{
				_ContactMotivator = value;
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
		private Guid _GlbAccountId;
		[CProperty(ColumnPath ="GlbAccountId")]
		public Guid GlbAccountId
		{
			get{return _GlbAccountId;}
			set
			{
				_GlbAccountId = value;
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
		private Guid _InfluenceId;
		[CProperty(ColumnPath ="InfluenceId")]
		public Guid InfluenceId
		{
			get{return _InfluenceId;}
			set
			{
				_InfluenceId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsMainContact;
		[CProperty(ColumnPath ="IsMainContact")]
		public bool IsMainContact
		{
			get{return _IsMainContact;}
			set
			{
				_IsMainContact = value;
				OnPropertyChanged();
			}
		}
		private Guid _JobId;
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId
		{
			get{return _JobId;}
			set
			{
				_JobId = value;
				OnPropertyChanged();
			}
		}
		private string _JobTitle;
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle
		{
			get{return _JobTitle;}
			set
			{
				_JobTitle = value;
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
		private string _Pain;
		[CProperty(ColumnPath ="Pain")]
		public string Pain
		{
			get{return _Pain;}
			set
			{
				_Pain = value;
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
		private Guid _RoleId;
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId
		{
			get{return _RoleId;}
			set
			{
				_RoleId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:GlbAccountId")]
		public Account GlbAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Job:JobId")]
		public Job Job { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="OppContactInfluence:InfluenceId")]
		public OppContactInfluence Influence { get; set; }
		[CProperty(Navigation ="OppContactLoyality:ContactLoyalityId")]
		public OppContactLoyality ContactLoyality { get; set; }
		[CProperty(Navigation ="OppContactRole:RoleId")]
		public OppContactRole Role { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OppContactMotivator:OpportunityContactId")]
		public virtual ICollection<OppContactMotivator> OppContactMotivatorByOpportunityContact { get; set; }
		#endregion
	}
}
