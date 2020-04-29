using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DwhDevCR")]
	public class DwhDevCR : BaseEntity
	{
		#region Values
		private DateTime _ActualDueDate;
		[CProperty(ColumnPath ="ActualDueDate")]
		public DateTime ActualDueDate
		{
			get{return _ActualDueDate;}
			set
			{
				_ActualDueDate = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDuration;
		[CProperty(ColumnPath ="ActualDuration")]
		public int ActualDuration
		{
			get{return _ActualDuration;}
			set
			{
				_ActualDuration = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDuration05;
		[CProperty(ColumnPath ="ActualDuration05")]
		public int ActualDuration05
		{
			get{return _ActualDuration05;}
			set
			{
				_ActualDuration05 = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDuration1;
		[CProperty(ColumnPath ="ActualDuration1")]
		public int ActualDuration1
		{
			get{return _ActualDuration1;}
			set
			{
				_ActualDuration1 = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDuration2;
		[CProperty(ColumnPath ="ActualDuration2")]
		public int ActualDuration2
		{
			get{return _ActualDuration2;}
			set
			{
				_ActualDuration2 = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDuration3;
		[CProperty(ColumnPath ="ActualDuration3")]
		public int ActualDuration3
		{
			get{return _ActualDuration3;}
			set
			{
				_ActualDuration3 = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDuration5;
		[CProperty(ColumnPath ="ActualDuration5")]
		public int ActualDuration5
		{
			get{return _ActualDuration5;}
			set
			{
				_ActualDuration5 = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDurationEE;
		[CProperty(ColumnPath ="ActualDurationEE")]
		public int ActualDurationEE
		{
			get{return _ActualDurationEE;}
			set
			{
				_ActualDurationEE = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDurationQT;
		[CProperty(ColumnPath ="ActualDurationQT")]
		public int ActualDurationQT
		{
			get{return _ActualDurationQT;}
			set
			{
				_ActualDurationQT = value;
				OnPropertyChanged();
			}
		}
		private decimal _BugSP;
		[CProperty(ColumnPath ="BugSP")]
		public decimal BugSP
		{
			get{return _BugSP;}
			set
			{
				_BugSP = value;
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
		private string _DescriptionStr;
		[CProperty(ColumnPath ="DescriptionStr")]
		public string DescriptionStr
		{
			get{return _DescriptionStr;}
			set
			{
				_DescriptionStr = value;
				OnPropertyChanged();
			}
		}
		private string _EmployeeLevel;
		[CProperty(ColumnPath ="EmployeeLevel")]
		public string EmployeeLevel
		{
			get{return _EmployeeLevel;}
			set
			{
				_EmployeeLevel = value;
				OnPropertyChanged();
			}
		}
		private bool _EmptyEstimate;
		[CProperty(ColumnPath ="EmptyEstimate")]
		public bool EmptyEstimate
		{
			get{return _EmptyEstimate;}
			set
			{
				_EmptyEstimate = value;
				OnPropertyChanged();
			}
		}
		private Guid _HodId;
		[CProperty(ColumnPath ="HodId")]
		public Guid HodId
		{
			get{return _HodId;}
			set
			{
				_HodId = value;
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
		private string _JiraUrl;
		[CProperty(ColumnPath ="JiraUrl")]
		public string JiraUrl
		{
			get{return _JiraUrl;}
			set
			{
				_JiraUrl = value;
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
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private bool _OverEstimate;
		[CProperty(ColumnPath ="OverEstimate")]
		public bool OverEstimate
		{
			get{return _OverEstimate;}
			set
			{
				_OverEstimate = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerIdId;
		[CProperty(ColumnPath ="OwnerIdId")]
		public Guid OwnerIdId
		{
			get{return _OwnerIdId;}
			set
			{
				_OwnerIdId = value;
				OnPropertyChanged();
			}
		}
		private string _OwnerName;
		[CProperty(ColumnPath ="OwnerName")]
		public string OwnerName
		{
			get{return _OwnerName;}
			set
			{
				_OwnerName = value;
				OnPropertyChanged();
			}
		}
		private string _PeriodMonth;
		[CProperty(ColumnPath ="PeriodMonth")]
		public string PeriodMonth
		{
			get{return _PeriodMonth;}
			set
			{
				_PeriodMonth = value;
				OnPropertyChanged();
			}
		}
		private string _PeriodWeekNumber;
		[CProperty(ColumnPath ="PeriodWeekNumber")]
		public string PeriodWeekNumber
		{
			get{return _PeriodWeekNumber;}
			set
			{
				_PeriodWeekNumber = value;
				OnPropertyChanged();
			}
		}
		private string _PracticeName;
		[CProperty(ColumnPath ="PracticeName")]
		public string PracticeName
		{
			get{return _PracticeName;}
			set
			{
				_PracticeName = value;
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
		private decimal _SkillProgress;
		[CProperty(ColumnPath ="SkillProgress")]
		public decimal SkillProgress
		{
			get{return _SkillProgress;}
			set
			{
				_SkillProgress = value;
				OnPropertyChanged();
			}
		}
		private decimal _SP;
		[CProperty(ColumnPath ="SP")]
		public decimal SP
		{
			get{return _SP;}
			set
			{
				_SP = value;
				OnPropertyChanged();
			}
		}
		private decimal _Sp05;
		[CProperty(ColumnPath ="Sp05")]
		public decimal Sp05
		{
			get{return _Sp05;}
			set
			{
				_Sp05 = value;
				OnPropertyChanged();
			}
		}
		private int _Sp1;
		[CProperty(ColumnPath ="Sp1")]
		public int Sp1
		{
			get{return _Sp1;}
			set
			{
				_Sp1 = value;
				OnPropertyChanged();
			}
		}
		private int _Sp2;
		[CProperty(ColumnPath ="Sp2")]
		public int Sp2
		{
			get{return _Sp2;}
			set
			{
				_Sp2 = value;
				OnPropertyChanged();
			}
		}
		private int _Sp3;
		[CProperty(ColumnPath ="Sp3")]
		public int Sp3
		{
			get{return _Sp3;}
			set
			{
				_Sp3 = value;
				OnPropertyChanged();
			}
		}
		private int _Sp5;
		[CProperty(ColumnPath ="Sp5")]
		public int Sp5
		{
			get{return _Sp5;}
			set
			{
				_Sp5 = value;
				OnPropertyChanged();
			}
		}
		private string _StatusName;
		[CProperty(ColumnPath ="StatusName")]
		public string StatusName
		{
			get{return _StatusName;}
			set
			{
				_StatusName = value;
				OnPropertyChanged();
			}
		}
		private string _TeamName;
		[CProperty(ColumnPath ="TeamName")]
		public string TeamName
		{
			get{return _TeamName;}
			set
			{
				_TeamName = value;
				OnPropertyChanged();
			}
		}
		private int _TeamSize;
		[CProperty(ColumnPath ="TeamSize")]
		public int TeamSize
		{
			get{return _TeamSize;}
			set
			{
				_TeamSize = value;
				OnPropertyChanged();
			}
		}
		private decimal _TeamSkillProgress;
		[CProperty(ColumnPath ="TeamSkillProgress")]
		public decimal TeamSkillProgress
		{
			get{return _TeamSkillProgress;}
			set
			{
				_TeamSkillProgress = value;
				OnPropertyChanged();
			}
		}
		private int _WorkTerm;
		[CProperty(ColumnPath ="WorkTerm")]
		public int WorkTerm
		{
			get{return _WorkTerm;}
			set
			{
				_WorkTerm = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerIdId")]
		public Contact OwnerId { get; set; }
		[CProperty(Navigation ="Contact:HodId")]
		public Contact Hod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
