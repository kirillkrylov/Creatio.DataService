using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwQueueItemDashboardC")]
	public class VwQueueItemDashboardC : BaseEntity
	{
		#region Values
		private int _AttemptsToCall;
		[CProperty(ColumnPath ="AttemptsToCall")]
		public int AttemptsToCall
		{
			get{return _AttemptsToCall;}
			set
			{
				_AttemptsToCall = value;
				OnPropertyChanged();
			}
		}
		private string _ContactName;
		[CProperty(ColumnPath ="ContactName")]
		public string ContactName
		{
			get{return _ContactName;}
			set
			{
				_ContactName = value;
				OnPropertyChanged();
			}
		}
		private Guid _CountryId;
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId
		{
			get{return _CountryId;}
			set
			{
				_CountryId = value;
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
		private DateTime _FirstActivityDate;
		[CProperty(ColumnPath ="FirstActivityDate")]
		public DateTime FirstActivityDate
		{
			get{return _FirstActivityDate;}
			set
			{
				_FirstActivityDate = value;
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
		private string _LastActivityContact;
		[CProperty(ColumnPath ="LastActivityContact")]
		public string LastActivityContact
		{
			get{return _LastActivityContact;}
			set
			{
				_LastActivityContact = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastActivityCreatedOn;
		[CProperty(ColumnPath ="LastActivityCreatedOn")]
		public DateTime LastActivityCreatedOn
		{
			get{return _LastActivityCreatedOn;}
			set
			{
				_LastActivityCreatedOn = value;
				OnPropertyChanged();
			}
		}
		private string _LastActivityDetailedResult;
		[CProperty(ColumnPath ="LastActivityDetailedResult")]
		public string LastActivityDetailedResult
		{
			get{return _LastActivityDetailedResult;}
			set
			{
				_LastActivityDetailedResult = value;
				OnPropertyChanged();
			}
		}
		private string _LastActivityResult;
		[CProperty(ColumnPath ="LastActivityResult")]
		public string LastActivityResult
		{
			get{return _LastActivityResult;}
			set
			{
				_LastActivityResult = value;
				OnPropertyChanged();
			}
		}
		private DateTime _NextProcessingDate;
		[CProperty(ColumnPath ="NextProcessingDate")]
		public DateTime NextProcessingDate
		{
			get{return _NextProcessingDate;}
			set
			{
				_NextProcessingDate = value;
				OnPropertyChanged();
			}
		}
		private string _OperatorName;
		[CProperty(ColumnPath ="OperatorName")]
		public string OperatorName
		{
			get{return _OperatorName;}
			set
			{
				_OperatorName = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueId;
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId
		{
			get{return _QueueId;}
			set
			{
				_QueueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueItemStatusId;
		[CProperty(ColumnPath ="QueueItemStatusId")]
		public Guid QueueItemStatusId
		{
			get{return _QueueItemStatusId;}
			set
			{
				_QueueItemStatusId = value;
				OnPropertyChanged();
			}
		}
		private int _ReactionWorkTime;
		[CProperty(ColumnPath ="ReactionWorkTime")]
		public int ReactionWorkTime
		{
			get{return _ReactionWorkTime;}
			set
			{
				_ReactionWorkTime = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Queue:QueueId")]
		public Queue Queue { get; set; }
		[CProperty(Navigation ="QueueItemStatus:QueueItemStatusId")]
		public QueueItemStatus QueueItemStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
