using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessElementToDo")]
	public class SysProcessElementToDo : BaseEntity
	{
		#region Values
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
		private Guid _ElementSchemaUId;
		[CProperty(ColumnPath ="ElementSchemaUId")]
		public Guid ElementSchemaUId
		{
			get{return _ElementSchemaUId;}
			set
			{
				_ElementSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private byte[] _ExecutionData;
		[CProperty(ColumnPath ="ExecutionData")]
		public byte[] ExecutionData
		{
			get{return _ExecutionData;}
			set
			{
				_ExecutionData = value;
				OnPropertyChanged();
			}
		}
		private byte[] _ExtraData;
		[CProperty(ColumnPath ="ExtraData")]
		public byte[] ExtraData
		{
			get{return _ExtraData;}
			set
			{
				_ExtraData = value;
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
		private string _ManagerName;
		[CProperty(ColumnPath ="ManagerName")]
		public string ManagerName
		{
			get{return _ManagerName;}
			set
			{
				_ManagerName = value;
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
		private Guid _ProcessSchemaUId;
		[CProperty(ColumnPath ="ProcessSchemaUId")]
		public Guid ProcessSchemaUId
		{
			get{return _ProcessSchemaUId;}
			set
			{
				_ProcessSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private string _Subject;
		[CProperty(ColumnPath ="Subject")]
		public string Subject
		{
			get{return _Subject;}
			set
			{
				_Subject = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysProcessDataId;
		[CProperty(ColumnPath ="SysProcessDataId")]
		public Guid SysProcessDataId
		{
			get{return _SysProcessDataId;}
			set
			{
				_SysProcessDataId = value;
				OnPropertyChanged();
			}
		}
		private string _Title;
		[CProperty(ColumnPath ="Title")]
		public string Title
		{
			get{return _Title;}
			set
			{
				_Title = value;
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
		#endregion
	}
}
