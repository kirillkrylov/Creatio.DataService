using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDESuitableCustomerCaseInOpportunity")]
	public class PDESuitableCustomerCaseInOpportunity : BaseEntity
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
		private bool _PDECountryFilter;
		[CProperty(ColumnPath ="PDECountryFilter")]
		public bool PDECountryFilter
		{
			get{return _PDECountryFilter;}
			set
			{
				_PDECountryFilter = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDECustomerCaseId;
		[CProperty(ColumnPath ="PDECustomerCaseId")]
		public Guid PDECustomerCaseId
		{
			get{return _PDECustomerCaseId;}
			set
			{
				_PDECustomerCaseId = value;
				OnPropertyChanged();
			}
		}
		private bool _PDEIndustryFilter;
		[CProperty(ColumnPath ="PDEIndustryFilter")]
		public bool PDEIndustryFilter
		{
			get{return _PDEIndustryFilter;}
			set
			{
				_PDEIndustryFilter = value;
				OnPropertyChanged();
			}
		}
		private bool _PDENeedCombinationFilter;
		[CProperty(ColumnPath ="PDENeedCombinationFilter")]
		public bool PDENeedCombinationFilter
		{
			get{return _PDENeedCombinationFilter;}
			set
			{
				_PDENeedCombinationFilter = value;
				OnPropertyChanged();
			}
		}
		private bool _PDENeedFilter;
		[CProperty(ColumnPath ="PDENeedFilter")]
		public bool PDENeedFilter
		{
			get{return _PDENeedFilter;}
			set
			{
				_PDENeedFilter = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEOpportunityId;
		[CProperty(ColumnPath ="PDEOpportunityId")]
		public Guid PDEOpportunityId
		{
			get{return _PDEOpportunityId;}
			set
			{
				_PDEOpportunityId = value;
				OnPropertyChanged();
			}
		}
		private bool _PDETerritoryFilter;
		[CProperty(ColumnPath ="PDETerritoryFilter")]
		public bool PDETerritoryFilter
		{
			get{return _PDETerritoryFilter;}
			set
			{
				_PDETerritoryFilter = value;
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
		[CProperty(Navigation ="KnowledgeBase:PDECustomerCaseId")]
		public KnowledgeBase PDECustomerCase { get; set; }
		[CProperty(Navigation ="Opportunity:PDEOpportunityId")]
		public Opportunity PDEOpportunity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
