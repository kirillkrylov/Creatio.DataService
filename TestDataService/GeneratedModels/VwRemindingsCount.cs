using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwRemindingsCount")]
	public class VwRemindingsCount : BaseEntity
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
		private int _EmailsCount;
		[CProperty(ColumnPath ="EmailsCount")]
		public int EmailsCount
		{
			get{return _EmailsCount;}
			set
			{
				_EmailsCount = value;
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
		private int _VisaCount;
		[CProperty(ColumnPath ="VisaCount")]
		public int VisaCount
		{
			get{return _VisaCount;}
			set
			{
				_VisaCount = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
