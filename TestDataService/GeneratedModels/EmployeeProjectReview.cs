using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeProjectReview")]
	public class EmployeeProjectReview : BaseEntity
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
		private Guid _ImprovementId;
		[CProperty(ColumnPath ="ImprovementId")]
		public Guid ImprovementId
		{
			get{return _ImprovementId;}
			set
			{
				_ImprovementId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InteractionWithManagerId;
		[CProperty(ColumnPath ="InteractionWithManagerId")]
		public Guid InteractionWithManagerId
		{
			get{return _InteractionWithManagerId;}
			set
			{
				_InteractionWithManagerId = value;
				OnPropertyChanged();
			}
		}
		private string _ManagerComment;
		[CProperty(ColumnPath ="ManagerComment")]
		public string ManagerComment
		{
			get{return _ManagerComment;}
			set
			{
				_ManagerComment = value;
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
		private string _Project;
		[CProperty(ColumnPath ="Project")]
		public string Project
		{
			get{return _Project;}
			set
			{
				_Project = value;
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
		[CProperty(Navigation ="CI:ImprovementId")]
		public CI Improvement { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmployeeProjectStatus:StatusId")]
		public EmployeeProjectStatus Status { get; set; }
		[CProperty(Navigation ="InteractionWithManager:InteractionWithManagerId")]
		public InteractionWithManager InteractionWithManager { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
