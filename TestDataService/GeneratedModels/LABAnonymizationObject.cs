using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LABAnonymizationObject")]
	public class LABAnonymizationObject : BaseEntity
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
		private Guid _LABColumnUId;
		[CProperty(ColumnPath ="LABColumnUId")]
		public Guid LABColumnUId
		{
			get{return _LABColumnUId;}
			set
			{
				_LABColumnUId = value;
				OnPropertyChanged();
			}
		}
		private string _LABRefColumnName;
		[CProperty(ColumnPath ="LABRefColumnName")]
		public string LABRefColumnName
		{
			get{return _LABRefColumnName;}
			set
			{
				_LABRefColumnName = value;
				OnPropertyChanged();
			}
		}
		private Guid _LABSysSchemaUId;
		[CProperty(ColumnPath ="LABSysSchemaUId")]
		public Guid LABSysSchemaUId
		{
			get{return _LABSysSchemaUId;}
			set
			{
				_LABSysSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private string _LABTableName;
		[CProperty(ColumnPath ="LABTableName")]
		public string LABTableName
		{
			get{return _LABTableName;}
			set
			{
				_LABTableName = value;
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
		[CProperty(Association ="LABObjectFields:LABAnonymizationObjectId")]
		public virtual ICollection<LABObjectFields> LABObjectFieldsByLABAnonymizationObject { get; set; }
		#endregion
	}
}
