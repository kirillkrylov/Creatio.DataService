using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TimeUnit")]
	public class TimeUnit : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		#endregion

		#region Associations
		[CProperty(Association ="Case:ProcessingTimeUnitId")]
		public virtual ICollection<Case> CaseByProcessingTimeUnit { get; set; }
		[CProperty(Association ="CasePriority:ReactionTimeUnitId")]
		public virtual ICollection<CasePriority> CasePriorityByReactionTimeUnit { get; set; }
		[CProperty(Association ="CasePriority:SolutionTimeUnitId")]
		public virtual ICollection<CasePriority> CasePriorityBySolutionTimeUnit { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:ReactionTimeUnitId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelByReactionTimeUnit { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:SolutionTimeUnitId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelBySolutionTimeUnit { get; set; }
		[CProperty(Association ="ServiceInServicePact:ReactionTimeUnitId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByReactionTimeUnit { get; set; }
		[CProperty(Association ="ServiceInServicePact:SolutionTimeUnitId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactBySolutionTimeUnit { get; set; }
		[CProperty(Association ="ServiceItem:ReactionTimeUnitId")]
		public virtual ICollection<ServiceItem> ServiceItemByReactionTimeUnit { get; set; }
		[CProperty(Association ="ServiceItem:SolutionTimeUnitId")]
		public virtual ICollection<ServiceItem> ServiceItemBySolutionTimeUnit { get; set; }
		[CProperty(Association ="TimeToPrioritize:ReactionTimeUnitId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeByReactionTimeUnit { get; set; }
		[CProperty(Association ="TimeToPrioritize:SolutionTimeUnitId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeBySolutionTimeUnit { get; set; }
		#endregion
	}
}
