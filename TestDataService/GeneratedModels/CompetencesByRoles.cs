using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CompetencesByRoles")]
	public class CompetencesByRoles : BaseEntity
	{
		#region Values
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
		private Guid _EmployeeJobId;
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId
		{
			get{return _EmployeeJobId;}
			set
			{
				_EmployeeJobId = value;
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
		private Guid _RoleId;
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId
		{
			get{return _RoleId;}
			set
			{
				_RoleId = value;
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
		[CProperty(Navigation ="EmployeeJob:RoleId")]
		public EmployeeJob Role { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:EmployeeJobId")]
		public OrgStructureUnit EmployeeJob { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
