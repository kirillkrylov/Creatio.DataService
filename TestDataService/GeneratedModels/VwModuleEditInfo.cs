using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwModuleEditInfo")]
	public class VwModuleEditInfo : BaseEntity
	{
		#region Values
		private Guid _ActionKindCaptionLczId;
		[CProperty(ColumnPath ="ActionKindCaptionLczId")]
		public Guid ActionKindCaptionLczId
		{
			get{return _ActionKindCaptionLczId;}
			set
			{
				_ActionKindCaptionLczId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CultureId;
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId
		{
			get{return _CultureId;}
			set
			{
				_CultureId = value;
				OnPropertyChanged();
			}
		}
		private string _DefaultPageCaption;
		[CProperty(ColumnPath ="DefaultPageCaption")]
		public string DefaultPageCaption
		{
			get{return _DefaultPageCaption;}
			set
			{
				_DefaultPageCaption = value;
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
		private string _ModuleCode;
		[CProperty(ColumnPath ="ModuleCode")]
		public string ModuleCode
		{
			get{return _ModuleCode;}
			set
			{
				_ModuleCode = value;
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
		private string _PageCaptionLcz;
		[CProperty(ColumnPath ="PageCaptionLcz")]
		public string PageCaptionLcz
		{
			get{return _PageCaptionLcz;}
			set
			{
				_PageCaptionLcz = value;
				OnPropertyChanged();
			}
		}
		private Guid _PageCaptionLczId;
		[CProperty(ColumnPath ="PageCaptionLczId")]
		public Guid PageCaptionLczId
		{
			get{return _PageCaptionLczId;}
			set
			{
				_PageCaptionLczId = value;
				OnPropertyChanged();
			}
		}
		private string _PageCaptionLczOld;
		[CProperty(ColumnPath ="PageCaptionLczOld")]
		public string PageCaptionLczOld
		{
			get{return _PageCaptionLczOld;}
			set
			{
				_PageCaptionLczOld = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
				OnPropertyChanged();
			}
		}
		private Guid _RecordId;
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId
		{
			get{return _RecordId;}
			set
			{
				_RecordId = value;
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
		private Guid _WorkspaceId;
		[CProperty(ColumnPath ="WorkspaceId")]
		public Guid WorkspaceId
		{
			get{return _WorkspaceId;}
			set
			{
				_WorkspaceId = value;
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
