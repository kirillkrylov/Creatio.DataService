using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleReport")]
	public class SysModuleReport : BaseEntity
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
		private bool _ConvertInPDF;
		[CProperty(ColumnPath ="ConvertInPDF")]
		public bool ConvertInPDF
		{
			get{return _ConvertInPDF;}
			set
			{
				_ConvertInPDF = value;
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
		private byte[] _File;
		[CProperty(ColumnPath ="File")]
		public byte[] File
		{
			get{return _File;}
			set
			{
				_File = value;
				OnPropertyChanged();
			}
		}
		private string _FileName;
		[CProperty(ColumnPath ="FileName")]
		public string FileName
		{
			get{return _FileName;}
			set
			{
				_FileName = value;
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
		private string _MacrosList;
		[CProperty(ColumnPath ="MacrosList")]
		public string MacrosList
		{
			get{return _MacrosList;}
			set
			{
				_MacrosList = value;
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
		private bool _ShowInCard;
		[CProperty(ColumnPath ="ShowInCard")]
		public bool ShowInCard
		{
			get{return _ShowInCard;}
			set
			{
				_ShowInCard = value;
				OnPropertyChanged();
			}
		}
		private bool _ShowInSection;
		[CProperty(ColumnPath ="ShowInSection")]
		public bool ShowInSection
		{
			get{return _ShowInSection;}
			set
			{
				_ShowInSection = value;
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
		private Guid _SysReportSchemaUId;
		[CProperty(ColumnPath ="SysReportSchemaUId")]
		public Guid SysReportSchemaUId
		{
			get{return _SysReportSchemaUId;}
			set
			{
				_SysReportSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeColumnValue;
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue
		{
			get{return _TypeColumnValue;}
			set
			{
				_TypeColumnValue = value;
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
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleReportType:TypeId")]
		public SysModuleReportType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Contract:PrintableId")]
		public virtual ICollection<Contract> ContractByPrintable { get; set; }
		[CProperty(Association ="DefaultReport:SysModuleReportId")]
		public virtual ICollection<DefaultReport> DefaultReportBySysModuleReport { get; set; }
		[CProperty(Association ="Invoice:PrintableId")]
		public virtual ICollection<Invoice> InvoiceByPrintable { get; set; }
		[CProperty(Association ="SysModuleReportInPackage:SysModuleReportId")]
		public virtual ICollection<SysModuleReportInPackage> SysModuleReportInPackageBySysModuleReport { get; set; }
		[CProperty(Association ="SysModuleReportLczOld:RecordId")]
		public virtual ICollection<SysModuleReportLczOld> SysModuleReportLczOldByRecord { get; set; }
		[CProperty(Association ="SysModuleReportTable:SysModuleReportId")]
		public virtual ICollection<SysModuleReportTable> SysModuleReportTableBySysModuleReport { get; set; }
		#endregion
	}
}
