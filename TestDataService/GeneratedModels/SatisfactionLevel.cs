using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SatisfactionLevel")]
	public class SatisfactionLevel : BaseEntity
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
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
		private int _Point;
		[CProperty(ColumnPath ="Point")]
		public int Point
		{
			get{return _Point;}
			set
			{
				_Point = value;
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
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:SatisfactionLevelId")]
		public virtual ICollection<Case> CaseBySatisfactionLevel { get; set; }
		[CProperty(Association ="CaseLifecycle:SatisfactionLevelId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleBySatisfactionLevel { get; set; }
		[CProperty(Association ="Change:SatisfactionLevelId")]
		public virtual ICollection<Change> ChangeBySatisfactionLevel { get; set; }
		[CProperty(Association ="VwChange:SatisfactionLevelId")]
		public virtual ICollection<VwChange> VwChangeBySatisfactionLevel { get; set; }
		#endregion
	}
}
