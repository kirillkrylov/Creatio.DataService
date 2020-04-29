using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleAnalyticsReport")]
	public class SysModuleAnalyticsReport : BaseEntity
	{
		#region Values
		private bool _AutoPreview;
		[CProperty(ColumnPath ="AutoPreview")]
		public bool AutoPreview
		{
			get{return _AutoPreview;}
			set
			{
				_AutoPreview = value;
				OnPropertyChanged();
			}
		}
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
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
		private string _HelpContextId;
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId
		{
			get{return _HelpContextId;}
			set
			{
				_HelpContextId = value;
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
		private Guid _LogoId;
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId
		{
			get{return _LogoId;}
			set
			{
				_LogoId = value;
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
		private string _ModuleSchemaName;
		[CProperty(ColumnPath ="ModuleSchemaName")]
		public string ModuleSchemaName
		{
			get{return _ModuleSchemaName;}
			set
			{
				_ModuleSchemaName = value;
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
		private Guid _SysModuleId;
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId
		{
			get{return _SysModuleId;}
			set
			{
				_SysModuleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysOptionsPageSchemaUId;
		[CProperty(ColumnPath ="SysOptionsPageSchemaUId")]
		public Guid SysOptionsPageSchemaUId
		{
			get{return _SysOptionsPageSchemaUId;}
			set
			{
				_SysOptionsPageSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysSchemaUId;
		[CProperty(ColumnPath ="SysSchemaUId")]
		public Guid SysSchemaUId
		{
			get{return _SysSchemaUId;}
			set
			{
				_SysSchemaUId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:LogoId")]
		public SysImage Logo { get; set; }
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleReportType:TypeId")]
		public SysModuleReportType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysModuleAnalyticsReportLczOld:RecordId")]
		public virtual ICollection<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOldByRecord { get; set; }
		#endregion
	}
}
