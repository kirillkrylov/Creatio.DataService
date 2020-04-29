using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LookupConflict")]
	public class LookupConflict : BaseEntity
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
		private string _DestinationColumnName;
		[CProperty(ColumnPath ="DestinationColumnName")]
		public string DestinationColumnName
		{
			get{return _DestinationColumnName;}
			set
			{
				_DestinationColumnName = value;
				OnPropertyChanged();
			}
		}
		private Guid _DestinationRecordId;
		[CProperty(ColumnPath ="DestinationRecordId")]
		public Guid DestinationRecordId
		{
			get{return _DestinationRecordId;}
			set
			{
				_DestinationRecordId = value;
				OnPropertyChanged();
			}
		}
		private string _DestinationSchemaName;
		[CProperty(ColumnPath ="DestinationSchemaName")]
		public string DestinationSchemaName
		{
			get{return _DestinationSchemaName;}
			set
			{
				_DestinationSchemaName = value;
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
		private Guid _LookupRecordId;
		[CProperty(ColumnPath ="LookupRecordId")]
		public Guid LookupRecordId
		{
			get{return _LookupRecordId;}
			set
			{
				_LookupRecordId = value;
				OnPropertyChanged();
			}
		}
		private string _LookupSchemaDisplayColumnName;
		[CProperty(ColumnPath ="LookupSchemaDisplayColumnName")]
		public string LookupSchemaDisplayColumnName
		{
			get{return _LookupSchemaDisplayColumnName;}
			set
			{
				_LookupSchemaDisplayColumnName = value;
				OnPropertyChanged();
			}
		}
		private string _LookupSchemaDisplayColumnValue;
		[CProperty(ColumnPath ="LookupSchemaDisplayColumnValue")]
		public string LookupSchemaDisplayColumnValue
		{
			get{return _LookupSchemaDisplayColumnValue;}
			set
			{
				_LookupSchemaDisplayColumnValue = value;
				OnPropertyChanged();
			}
		}
		private string _LookupSchemaName;
		[CProperty(ColumnPath ="LookupSchemaName")]
		public string LookupSchemaName
		{
			get{return _LookupSchemaName;}
			set
			{
				_LookupSchemaName = value;
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
