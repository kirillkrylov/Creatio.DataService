using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CasePriority")]
	public class CasePriority : BaseEntity
	{
		#region Values
		private string _Color;
		[CProperty(ColumnPath ="Color")]
		public string Color
		{
			get{return _Color;}
			set
			{
				_Color = value;
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _Priority;
		[CProperty(ColumnPath ="Priority")]
		public int Priority
		{
			get{return _Priority;}
			set
			{
				_Priority = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:PriorityId")]
		public virtual ICollection<Case> CaseByPriority { get; set; }
		[CProperty(Association ="CaseLifecycle:PriorityId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByPriority { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:CasePriorityId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelByCasePriority { get; set; }
		[CProperty(Association ="ServiceInServicePact:PriorityId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByPriority { get; set; }
		[CProperty(Association ="TimeToPrioritize:CasePriorityId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeByCasePriority { get; set; }
		#endregion
	}
}
