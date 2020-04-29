using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportUnitLog")]
	public class SupportUnitLog : BaseEntity
	{
		#region Values
		private bool _Active;
		[CProperty(ColumnPath ="Active")]
		public bool Active
		{
			get{return _Active;}
			set
			{
				_Active = value;
				OnPropertyChanged();
			}
		}
		private Guid _CalendarId;
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId
		{
			get{return _CalendarId;}
			set
			{
				_CalendarId = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _ParentSupportUnitId;
		[CProperty(ColumnPath ="ParentSupportUnitId")]
		public Guid ParentSupportUnitId
		{
			get{return _ParentSupportUnitId;}
			set
			{
				_ParentSupportUnitId = value;
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
		private Guid _SupportUnitId;
		[CProperty(ColumnPath ="SupportUnitId")]
		public Guid SupportUnitId
		{
			get{return _SupportUnitId;}
			set
			{
				_SupportUnitId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportUnitTypeId;
		[CProperty(ColumnPath ="SupportUnitTypeId")]
		public Guid SupportUnitTypeId
		{
			get{return _SupportUnitTypeId;}
			set
			{
				_SupportUnitTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportWorkingDayTypeId;
		[CProperty(ColumnPath ="SupportWorkingDayTypeId")]
		public Guid SupportWorkingDayTypeId
		{
			get{return _SupportWorkingDayTypeId;}
			set
			{
				_SupportWorkingDayTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SupportUnit:SupportUnitId")]
		public SupportUnit SupportUnit { get; set; }
		[CProperty(Navigation ="SupportUnit:ParentSupportUnitId")]
		public SupportUnit ParentSupportUnit { get; set; }
		[CProperty(Navigation ="SupportUnitType:SupportUnitTypeId")]
		public SupportUnitType SupportUnitType { get; set; }
		[CProperty(Navigation ="SupportWorkingDayType:SupportWorkingDayTypeId")]
		public SupportWorkingDayType SupportWorkingDayType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
