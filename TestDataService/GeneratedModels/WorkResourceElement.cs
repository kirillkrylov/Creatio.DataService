using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WorkResourceElement")]
	public class WorkResourceElement : BaseEntity
	{
		#region Values
		private decimal _ActualWork;
		[CProperty(ColumnPath ="ActualWork")]
		public decimal ActualWork
		{
			get{return _ActualWork;}
			set
			{
				_ActualWork = value;
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
		private decimal _ExternalRate;
		[CProperty(ColumnPath ="ExternalRate")]
		public decimal ExternalRate
		{
			get{return _ExternalRate;}
			set
			{
				_ExternalRate = value;
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
		private decimal _InternalRate;
		[CProperty(ColumnPath ="InternalRate")]
		public decimal InternalRate
		{
			get{return _InternalRate;}
			set
			{
				_InternalRate = value;
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
		private decimal _PlanningWork;
		[CProperty(ColumnPath ="PlanningWork")]
		public decimal PlanningWork
		{
			get{return _PlanningWork;}
			set
			{
				_PlanningWork = value;
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
		private Guid _ProjectId;
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId
		{
			get{return _ProjectId;}
			set
			{
				_ProjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProjectResourceElementId;
		[CProperty(ColumnPath ="ProjectResourceElementId")]
		public Guid ProjectResourceElementId
		{
			get{return _ProjectResourceElementId;}
			set
			{
				_ProjectResourceElementId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="ProjectResourceElement:ProjectResourceElementId")]
		public ProjectResourceElement ProjectResourceElement { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
