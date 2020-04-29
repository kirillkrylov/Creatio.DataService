using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeCompetence")]
	public class EmployeeCompetence : BaseEntity
	{
		#region Values
		private decimal _Actual;
		[CProperty(ColumnPath ="Actual")]
		public decimal Actual
		{
			get{return _Actual;}
			set
			{
				_Actual = value;
				OnPropertyChanged();
			}
		}
		private Guid _CompetenceId;
		[CProperty(ColumnPath ="CompetenceId")]
		public Guid CompetenceId
		{
			get{return _CompetenceId;}
			set
			{
				_CompetenceId = value;
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
		private string _EmployeeComment;
		[CProperty(ColumnPath ="EmployeeComment")]
		public string EmployeeComment
		{
			get{return _EmployeeComment;}
			set
			{
				_EmployeeComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
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
		private decimal _Percentage;
		[CProperty(ColumnPath ="Percentage")]
		public decimal Percentage
		{
			get{return _Percentage;}
			set
			{
				_Percentage = value;
				OnPropertyChanged();
			}
		}
		private decimal _Plan;
		[CProperty(ColumnPath ="Plan")]
		public decimal Plan
		{
			get{return _Plan;}
			set
			{
				_Plan = value;
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
		[CProperty(Navigation ="Competence:CompetenceId")]
		public Competence Competence { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="InteractionWithManager:InteractionWithManagerId")]
		public InteractionWithManager InteractionWithManager { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
