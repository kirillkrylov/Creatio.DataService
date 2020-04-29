using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSectionDesignerModuleInfo")]
	public class VwSectionDesignerModuleInfo : BaseEntity
	{
		#region Values
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
		private string _CaptionOld;
		[CProperty(ColumnPath ="CaptionOld")]
		public string CaptionOld
		{
			get{return _CaptionOld;}
			set
			{
				_CaptionOld = value;
				OnPropertyChanged();
			}
		}
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private string _DefaultCaption;
		[CProperty(ColumnPath ="DefaultCaption")]
		public string DefaultCaption
		{
			get{return _DefaultCaption;}
			set
			{
				_DefaultCaption = value;
				OnPropertyChanged();
			}
		}
		private string _DefaultHeader;
		[CProperty(ColumnPath ="DefaultHeader")]
		public string DefaultHeader
		{
			get{return _DefaultHeader;}
			set
			{
				_DefaultHeader = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityFolderId;
		[CProperty(ColumnPath ="EntityFolderId")]
		public Guid EntityFolderId
		{
			get{return _EntityFolderId;}
			set
			{
				_EntityFolderId = value;
				OnPropertyChanged();
			}
		}
		private string _EntityFolderName;
		[CProperty(ColumnPath ="EntityFolderName")]
		public string EntityFolderName
		{
			get{return _EntityFolderName;}
			set
			{
				_EntityFolderName = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityInFolderId;
		[CProperty(ColumnPath ="EntityInFolderId")]
		public Guid EntityInFolderId
		{
			get{return _EntityInFolderId;}
			set
			{
				_EntityInFolderId = value;
				OnPropertyChanged();
			}
		}
		private string _EntityInFolderName;
		[CProperty(ColumnPath ="EntityInFolderName")]
		public string EntityInFolderName
		{
			get{return _EntityInFolderName;}
			set
			{
				_EntityInFolderName = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityInTagId;
		[CProperty(ColumnPath ="EntityInTagId")]
		public Guid EntityInTagId
		{
			get{return _EntityInTagId;}
			set
			{
				_EntityInTagId = value;
				OnPropertyChanged();
			}
		}
		private string _EntityInTagName;
		[CProperty(ColumnPath ="EntityInTagName")]
		public string EntityInTagName
		{
			get{return _EntityInTagName;}
			set
			{
				_EntityInTagName = value;
				OnPropertyChanged();
			}
		}
		private string _EntityName;
		[CProperty(ColumnPath ="EntityName")]
		public string EntityName
		{
			get{return _EntityName;}
			set
			{
				_EntityName = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityTagId;
		[CProperty(ColumnPath ="EntityTagId")]
		public Guid EntityTagId
		{
			get{return _EntityTagId;}
			set
			{
				_EntityTagId = value;
				OnPropertyChanged();
			}
		}
		private string _EntityTagName;
		[CProperty(ColumnPath ="EntityTagName")]
		public string EntityTagName
		{
			get{return _EntityTagName;}
			set
			{
				_EntityTagName = value;
				OnPropertyChanged();
			}
		}
		private string _Header;
		[CProperty(ColumnPath ="Header")]
		public string Header
		{
			get{return _Header;}
			set
			{
				_Header = value;
				OnPropertyChanged();
			}
		}
		private string _HeaderOld;
		[CProperty(ColumnPath ="HeaderOld")]
		public string HeaderOld
		{
			get{return _HeaderOld;}
			set
			{
				_HeaderOld = value;
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
		private Guid _Image32Id;
		[CProperty(ColumnPath ="Image32Id")]
		public Guid Image32Id
		{
			get{return _Image32Id;}
			set
			{
				_Image32Id = value;
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
		private Guid _SectionDetailId;
		[CProperty(ColumnPath ="SectionDetailId")]
		public Guid SectionDetailId
		{
			get{return _SectionDetailId;}
			set
			{
				_SectionDetailId = value;
				OnPropertyChanged();
			}
		}
		private string _SectionDetailName;
		[CProperty(ColumnPath ="SectionDetailName")]
		public string SectionDetailName
		{
			get{return _SectionDetailName;}
			set
			{
				_SectionDetailName = value;
				OnPropertyChanged();
			}
		}
		private Guid _SectionSchemaId;
		[CProperty(ColumnPath ="SectionSchemaId")]
		public Guid SectionSchemaId
		{
			get{return _SectionSchemaId;}
			set
			{
				_SectionSchemaId = value;
				OnPropertyChanged();
			}
		}
		private string _SectionSchemaName;
		[CProperty(ColumnPath ="SectionSchemaName")]
		public string SectionSchemaName
		{
			get{return _SectionSchemaName;}
			set
			{
				_SectionSchemaName = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleCaptionLczId;
		[CProperty(ColumnPath ="SysModuleCaptionLczId")]
		public Guid SysModuleCaptionLczId
		{
			get{return _SysModuleCaptionLczId;}
			set
			{
				_SysModuleCaptionLczId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleEntityId;
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId
		{
			get{return _SysModuleEntityId;}
			set
			{
				_SysModuleEntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleHeaderLczId;
		[CProperty(ColumnPath ="SysModuleHeaderLczId")]
		public Guid SysModuleHeaderLczId
		{
			get{return _SysModuleHeaderLczId;}
			set
			{
				_SysModuleHeaderLczId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeColumnId;
		[CProperty(ColumnPath ="TypeColumnId")]
		public Guid TypeColumnId
		{
			get{return _TypeColumnId;}
			set
			{
				_TypeColumnId = value;
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
		private string _WorkspaceName;
		[CProperty(ColumnPath ="WorkspaceName")]
		public string WorkspaceName
		{
			get{return _WorkspaceName;}
			set
			{
				_WorkspaceName = value;
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
