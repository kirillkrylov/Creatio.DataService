using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsDelivery")]
	public class PsDelivery : BaseEntity
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
		private DateTime _DeliveryDate;
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate
		{
			get{return _DeliveryDate;}
			set
			{
				_DeliveryDate = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
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
		private Guid _ProjectEnvironmentId;
		[CProperty(ColumnPath ="ProjectEnvironmentId")]
		public Guid ProjectEnvironmentId
		{
			get{return _ProjectEnvironmentId;}
			set
			{
				_ProjectEnvironmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProjectSolutionId;
		[CProperty(ColumnPath ="ProjectSolutionId")]
		public Guid ProjectSolutionId
		{
			get{return _ProjectSolutionId;}
			set
			{
				_ProjectSolutionId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ReleaseDate;
		[CProperty(ColumnPath ="ReleaseDate")]
		public DateTime ReleaseDate
		{
			get{return _ReleaseDate;}
			set
			{
				_ReleaseDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReleaseId;
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId
		{
			get{return _ReleaseId;}
			set
			{
				_ReleaseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResultId;
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId
		{
			get{return _ResultId;}
			set
			{
				_ResultId = value;
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
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Version;
		[CProperty(ColumnPath ="Version")]
		public string Version
		{
			get{return _Version;}
			set
			{
				_Version = value;
				OnPropertyChanged();
			}
		}
		private int _VersionBuild;
		[CProperty(ColumnPath ="VersionBuild")]
		public int VersionBuild
		{
			get{return _VersionBuild;}
			set
			{
				_VersionBuild = value;
				OnPropertyChanged();
			}
		}
		private int _VersionMajor;
		[CProperty(ColumnPath ="VersionMajor")]
		public int VersionMajor
		{
			get{return _VersionMajor;}
			set
			{
				_VersionMajor = value;
				OnPropertyChanged();
			}
		}
		private int _VersionMinor;
		[CProperty(ColumnPath ="VersionMinor")]
		public int VersionMinor
		{
			get{return _VersionMinor;}
			set
			{
				_VersionMinor = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProjectSolution:ProjectSolutionId")]
		public ProjectSolution ProjectSolution { get; set; }
		[CProperty(Navigation ="PsDelivery:ReleaseId")]
		public PsDelivery Release { get; set; }
		[CProperty(Navigation ="PsDeliveryResult:ResultId")]
		public PsDeliveryResult Result { get; set; }
		[CProperty(Navigation ="PsDeliveryStatus:StatusId")]
		public PsDeliveryStatus Status { get; set; }
		[CProperty(Navigation ="PsDeliveryType:TypeId")]
		public PsDeliveryType Type { get; set; }
		[CProperty(Navigation ="PsProjectEnvironment:ProjectEnvironmentId")]
		public PsProjectEnvironment ProjectEnvironment { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PsDelivery:ReleaseId")]
		public virtual ICollection<PsDelivery> PsDeliveryByRelease { get; set; }
		[CProperty(Association ="PsDeliveryActivity:PsDeliveryId")]
		public virtual ICollection<PsDeliveryActivity> PsDeliveryActivityByPsDelivery { get; set; }
		[CProperty(Association ="PsDeliveryCheck:PsDeliveryId")]
		public virtual ICollection<PsDeliveryCheck> PsDeliveryCheckByPsDelivery { get; set; }
		[CProperty(Association ="PsDeliveryFile:PsDeliveryId")]
		public virtual ICollection<PsDeliveryFile> PsDeliveryFileByPsDelivery { get; set; }
		[CProperty(Association ="PsDeliveryVisa:PsDeliveryId")]
		public virtual ICollection<PsDeliveryVisa> PsDeliveryVisaByPsDelivery { get; set; }
		#endregion
	}
}
