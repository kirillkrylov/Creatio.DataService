using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysEntitySchemaReference")]
	public class SysEntitySchemaReference : BaseEntity
	{
		#region Values
		private string _ColumnCaption;
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption
		{
			get{return _ColumnCaption;}
			set
			{
				_ColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnName;
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName
		{
			get{return _ColumnName;}
			set
			{
				_ColumnName = value;
				OnPropertyChanged();
			}
		}
		private Guid _ColumnUId;
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId
		{
			get{return _ColumnUId;}
			set
			{
				_ColumnUId = value;
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
		private Guid _ReferenceSchemaId;
		[CProperty(ColumnPath ="ReferenceSchemaId")]
		public Guid ReferenceSchemaId
		{
			get{return _ReferenceSchemaId;}
			set
			{
				_ReferenceSchemaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysSchemaId;
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId
		{
			get{return _SysSchemaId;}
			set
			{
				_SysSchemaId = value;
				OnPropertyChanged();
			}
		}
		private int _UsageType;
		[CProperty(ColumnPath ="UsageType")]
		public int UsageType
		{
			get{return _UsageType;}
			set
			{
				_UsageType = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:ReferenceSchemaId")]
		public SysSchema ReferenceSchema { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
