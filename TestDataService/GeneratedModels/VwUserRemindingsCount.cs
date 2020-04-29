using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwUserRemindingsCount")]
	public class VwUserRemindingsCount : BaseEntity
	{
		#region Values
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
		private int _RemindingsCount;
		[CProperty(ColumnPath ="RemindingsCount")]
		public int RemindingsCount
		{
			get{return _RemindingsCount;}
			set
			{
				_RemindingsCount = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RemindTime;
		[CProperty(ColumnPath ="RemindTime")]
		public DateTime RemindTime
		{
			get{return _RemindTime;}
			set
			{
				_RemindTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysAdminUnitId;
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId
		{
			get{return _SysAdminUnitId;}
			set
			{
				_SysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		private string _TimeZoneId;
		[CProperty(ColumnPath ="TimeZoneId")]
		public string TimeZoneId
		{
			get{return _TimeZoneId;}
			set
			{
				_TimeZoneId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
