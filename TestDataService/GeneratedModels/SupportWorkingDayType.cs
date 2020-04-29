using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportWorkingDayType")]
	public class SupportWorkingDayType : BaseEntity
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
		private DateTime _From;
		[CProperty(ColumnPath ="From")]
		public DateTime From
		{
			get{return _From;}
			set
			{
				_From = value;
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
		private bool _IsAvailable;
		[CProperty(ColumnPath ="IsAvailable")]
		public bool IsAvailable
		{
			get{return _IsAvailable;}
			set
			{
				_IsAvailable = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDuty;
		[CProperty(ColumnPath ="IsDuty")]
		public bool IsDuty
		{
			get{return _IsDuty;}
			set
			{
				_IsDuty = value;
				OnPropertyChanged();
			}
		}
		private bool _IsNight;
		[CProperty(ColumnPath ="IsNight")]
		public bool IsNight
		{
			get{return _IsNight;}
			set
			{
				_IsNight = value;
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
		private DateTime _To;
		[CProperty(ColumnPath ="To")]
		public DateTime To
		{
			get{return _To;}
			set
			{
				_To = value;
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
		[CProperty(Association ="SupportSchedule:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportSchedule> SupportScheduleBySupportWorkingDayType { get; set; }
		[CProperty(Association ="SupportScheduleLog:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportScheduleLog> SupportScheduleLogBySupportWorkingDayType { get; set; }
		[CProperty(Association ="SupportUnit:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportUnit> SupportUnitBySupportWorkingDayType { get; set; }
		[CProperty(Association ="SupportUnitLog:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportUnitLog> SupportUnitLogBySupportWorkingDayType { get; set; }
		#endregion
	}
}
