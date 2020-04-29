using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadCompetitor")]
	public class LeadCompetitor : BaseEntity
	{
		#region Values
		private decimal _CompetitorAmount;
		[CProperty(ColumnPath ="CompetitorAmount")]
		public decimal CompetitorAmount
		{
			get{return _CompetitorAmount;}
			set
			{
				_CompetitorAmount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CompetitorId;
		[CProperty(ColumnPath ="CompetitorId")]
		public Guid CompetitorId
		{
			get{return _CompetitorId;}
			set
			{
				_CompetitorId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CompetitorProductId;
		[CProperty(ColumnPath ="CompetitorProductId")]
		public Guid CompetitorProductId
		{
			get{return _CompetitorProductId;}
			set
			{
				_CompetitorProductId = value;
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
		private DateTime _DateFrom;
		[CProperty(ColumnPath ="DateFrom")]
		public DateTime DateFrom
		{
			get{return _DateFrom;}
			set
			{
				_DateFrom = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateTo;
		[CProperty(ColumnPath ="DateTo")]
		public DateTime DateTo
		{
			get{return _DateTo;}
			set
			{
				_DateTo = value;
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
		private bool _IsWinner;
		[CProperty(ColumnPath ="IsWinner")]
		public bool IsWinner
		{
			get{return _IsWinner;}
			set
			{
				_IsWinner = value;
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
		private string _Strengths;
		[CProperty(ColumnPath ="Strengths")]
		public string Strengths
		{
			get{return _Strengths;}
			set
			{
				_Strengths = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierId;
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId
		{
			get{return _SupplierId;}
			set
			{
				_SupplierId = value;
				OnPropertyChanged();
			}
		}
		private string _Weakness;
		[CProperty(ColumnPath ="Weakness")]
		public string Weakness
		{
			get{return _Weakness;}
			set
			{
				_Weakness = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:CompetitorId")]
		public Account Competitor { get; set; }
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation ="CompetitorProduct:CompetitorProductId")]
		public CompetitorProduct CompetitorProduct { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
