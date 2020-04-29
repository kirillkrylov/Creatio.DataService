using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceInServicePact")]
	public class ServiceInServicePact : BaseEntity
	{
		#region Values
		private Guid _CalendarId;
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId
		{
			get{return _CalendarId;}
			set
			{
				_CalendarId = value;
				OnPropertyChanged();
			}
		}
		private string _ConcatName;
		[CProperty(ColumnPath ="ConcatName")]
		public string ConcatName
		{
			get{return _ConcatName;}
			set
			{
				_ConcatName = value;
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
		private Guid _PriorityId;
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId
		{
			get{return _PriorityId;}
			set
			{
				_PriorityId = value;
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
		private string _ReactionTime;
		[CProperty(ColumnPath ="ReactionTime")]
		public string ReactionTime
		{
			get{return _ReactionTime;}
			set
			{
				_ReactionTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReactionTimeUnitId;
		[CProperty(ColumnPath ="ReactionTimeUnitId")]
		public Guid ReactionTimeUnitId
		{
			get{return _ReactionTimeUnitId;}
			set
			{
				_ReactionTimeUnitId = value;
				OnPropertyChanged();
			}
		}
		private int _ReactionTimeValue;
		[CProperty(ColumnPath ="ReactionTimeValue")]
		public int ReactionTimeValue
		{
			get{return _ReactionTimeValue;}
			set
			{
				_ReactionTimeValue = value;
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
		private Guid _ServicePactId;
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId
		{
			get{return _ServicePactId;}
			set
			{
				_ServicePactId = value;
				OnPropertyChanged();
			}
		}
		private string _SolutionTime;
		[CProperty(ColumnPath ="SolutionTime")]
		public string SolutionTime
		{
			get{return _SolutionTime;}
			set
			{
				_SolutionTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _SolutionTimeUnitId;
		[CProperty(ColumnPath ="SolutionTimeUnitId")]
		public Guid SolutionTimeUnitId
		{
			get{return _SolutionTimeUnitId;}
			set
			{
				_SolutionTimeUnitId = value;
				OnPropertyChanged();
			}
		}
		private int _SolutionTimeValue;
		[CProperty(ColumnPath ="SolutionTimeValue")]
		public int SolutionTimeValue
		{
			get{return _SolutionTimeValue;}
			set
			{
				_SolutionTimeValue = value;
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
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation ="CasePriority:PriorityId")]
		public CasePriority Priority { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="ServicePact:ServicePactId")]
		public ServicePact ServicePact { get; set; }
		[CProperty(Navigation ="ServiceStatus:StatusId")]
		public ServiceStatus Status { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TimeToPrioritize:ServiceInServicePactId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeByServiceInServicePact { get; set; }
		#endregion
	}
}
