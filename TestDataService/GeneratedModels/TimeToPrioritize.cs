using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TimeToPrioritize")]
	public class TimeToPrioritize : BaseEntity
	{
		#region Values
		private Guid _CasePriorityId;
		[CProperty(ColumnPath ="CasePriorityId")]
		public Guid CasePriorityId
		{
			get{return _CasePriorityId;}
			set
			{
				_CasePriorityId = value;
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
		private Guid _ServiceInServicePactId;
		[CProperty(ColumnPath ="ServiceInServicePactId")]
		public Guid ServiceInServicePactId
		{
			get{return _ServiceInServicePactId;}
			set
			{
				_ServiceInServicePactId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="CasePriority:CasePriorityId")]
		public CasePriority CasePriority { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ServiceInServicePact:ServiceInServicePactId")]
		public ServiceInServicePact ServiceInServicePact { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
