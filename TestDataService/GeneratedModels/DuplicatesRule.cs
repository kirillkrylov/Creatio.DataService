using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DuplicatesRule")]
	public class DuplicatesRule : BaseEntity
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
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
		private Guid _ObjectId;
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId
		{
			get{return _ObjectId;}
			set
			{
				_ObjectId = value;
				OnPropertyChanged();
			}
		}
		private string _ProcedureName;
		[CProperty(ColumnPath ="ProcedureName")]
		public string ProcedureName
		{
			get{return _ProcedureName;}
			set
			{
				_ProcedureName = value;
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
		private string _RuleBody;
		[CProperty(ColumnPath ="RuleBody")]
		public string RuleBody
		{
			get{return _RuleBody;}
			set
			{
				_RuleBody = value;
				OnPropertyChanged();
			}
		}
		private Guid _SearchObjectId;
		[CProperty(ColumnPath ="SearchObjectId")]
		public Guid SearchObjectId
		{
			get{return _SearchObjectId;}
			set
			{
				_SearchObjectId = value;
				OnPropertyChanged();
			}
		}
		private bool _UseAtSave;
		[CProperty(ColumnPath ="UseAtSave")]
		public bool UseAtSave
		{
			get{return _UseAtSave;}
			set
			{
				_UseAtSave = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwDuplicatesRuleType:ObjectId")]
		public VwDuplicatesRuleType Object { get; set; }
		[CProperty(Navigation ="VwDuplicatesRuleType:SearchObjectId")]
		public VwDuplicatesRuleType SearchObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DuplicatesRuleInFolder:DuplicatesRuleId")]
		public virtual ICollection<DuplicatesRuleInFolder> DuplicatesRuleInFolderByDuplicatesRule { get; set; }
		[CProperty(Association ="DuplicatesRuleInTag:EntityId")]
		public virtual ICollection<DuplicatesRuleInTag> DuplicatesRuleInTagByEntity { get; set; }
		#endregion
	}
}
