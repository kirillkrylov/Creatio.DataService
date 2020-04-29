using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCaseDashboard")]
	public class VwCaseDashboard : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
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
		private int _OpenCaseDelay;
		[CProperty(ColumnPath ="OpenCaseDelay")]
		public int OpenCaseDelay
		{
			get{return _OpenCaseDelay;}
			set
			{
				_OpenCaseDelay = value;
				OnPropertyChanged();
			}
		}
		private Guid _OriginId;
		[CProperty(ColumnPath ="OriginId")]
		public Guid OriginId
		{
			get{return _OriginId;}
			set
			{
				_OriginId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private int _ReactionDelay;
		[CProperty(ColumnPath ="ReactionDelay")]
		public int ReactionDelay
		{
			get{return _ReactionDelay;}
			set
			{
				_ReactionDelay = value;
				OnPropertyChanged();
			}
		}
		private int _ReactionTerm;
		[CProperty(ColumnPath ="ReactionTerm")]
		public int ReactionTerm
		{
			get{return _ReactionTerm;}
			set
			{
				_ReactionTerm = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RespondedOn;
		[CProperty(ColumnPath ="RespondedOn")]
		public DateTime RespondedOn
		{
			get{return _RespondedOn;}
			set
			{
				_RespondedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ResponseDate;
		[CProperty(ColumnPath ="ResponseDate")]
		public DateTime ResponseDate
		{
			get{return _ResponseDate;}
			set
			{
				_ResponseDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceItemId;
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId
		{
			get{return _ServiceItemId;}
			set
			{
				_ServiceItemId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionDate;
		[CProperty(ColumnPath ="SolutionDate")]
		public DateTime SolutionDate
		{
			get{return _SolutionDate;}
			set
			{
				_SolutionDate = value;
				OnPropertyChanged();
			}
		}
		private int _SolutionDelay;
		[CProperty(ColumnPath ="SolutionDelay")]
		public int SolutionDelay
		{
			get{return _SolutionDelay;}
			set
			{
				_SolutionDelay = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionProvidedOn;
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn
		{
			get{return _SolutionProvidedOn;}
			set
			{
				_SolutionProvidedOn = value;
				OnPropertyChanged();
			}
		}
		private int _SolutionTerm;
		[CProperty(ColumnPath ="SolutionTerm")]
		public int SolutionTerm
		{
			get{return _SolutionTerm;}
			set
			{
				_SolutionTerm = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="CaseCategory:CategoryId")]
		public CaseCategory Category { get; set; }
		[CProperty(Navigation ="CaseOrigin:OriginId")]
		public CaseOrigin Origin { get; set; }
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation ="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
