using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPrAdditionalData")]
	public class SysPrAdditionalData : BaseEntity
	{
		#region Values
		private string _Data;
		[CProperty(ColumnPath ="Data")]
		public string Data
		{
			get{return _Data;}
			set
			{
				_Data = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateTime;
		[CProperty(ColumnPath ="DateTime")]
		public DateTime DateTime
		{
			get{return _DateTime;}
			set
			{
				_DateTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityRecordId;
		[CProperty(ColumnPath ="EntityRecordId")]
		public Guid EntityRecordId
		{
			get{return _EntityRecordId;}
			set
			{
				_EntityRecordId = value;
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
		private Guid _SysProcessUId;
		[CProperty(ColumnPath ="SysProcessUId")]
		public Guid SysProcessUId
		{
			get{return _SysProcessUId;}
			set
			{
				_SysProcessUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
