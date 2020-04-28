using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSectionDesignerModuleInfo")]
	public class VwSectionDesignerModuleInfo : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CaptionOld")]
		public string CaptionOld { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId { get; set; }
		[CProperty(ColumnPath ="DefaultCaption")]
		public string DefaultCaption { get; set; }
		[CProperty(ColumnPath ="DefaultHeader")]
		public string DefaultHeader { get; set; }
		[CProperty(ColumnPath ="EntityFolderId")]
		public Guid EntityFolderId { get; set; }
		[CProperty(ColumnPath ="EntityFolderName")]
		public string EntityFolderName { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath ="EntityInFolderId")]
		public Guid EntityInFolderId { get; set; }
		[CProperty(ColumnPath ="EntityInFolderName")]
		public string EntityInFolderName { get; set; }
		[CProperty(ColumnPath ="EntityInTagId")]
		public Guid EntityInTagId { get; set; }
		[CProperty(ColumnPath ="EntityInTagName")]
		public string EntityInTagName { get; set; }
		[CProperty(ColumnPath ="EntityName")]
		public string EntityName { get; set; }
		[CProperty(ColumnPath ="EntityTagId")]
		public Guid EntityTagId { get; set; }
		[CProperty(ColumnPath ="EntityTagName")]
		public string EntityTagName { get; set; }
		[CProperty(ColumnPath ="Header")]
		public string Header { get; set; }
		[CProperty(ColumnPath ="HeaderOld")]
		public string HeaderOld { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Image32Id")]
		public Guid Image32Id { get; set; }
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId { get; set; }
		[CProperty(ColumnPath ="SectionDetailId")]
		public Guid SectionDetailId { get; set; }
		[CProperty(ColumnPath ="SectionDetailName")]
		public string SectionDetailName { get; set; }
		[CProperty(ColumnPath ="SectionSchemaId")]
		public Guid SectionSchemaId { get; set; }
		[CProperty(ColumnPath ="SectionSchemaName")]
		public string SectionSchemaName { get; set; }
		[CProperty(ColumnPath ="SysModuleCaptionLczId")]
		public Guid SysModuleCaptionLczId { get; set; }
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId { get; set; }
		[CProperty(ColumnPath ="SysModuleHeaderLczId")]
		public Guid SysModuleHeaderLczId { get; set; }
		[CProperty(ColumnPath ="TypeColumnId")]
		public Guid TypeColumnId { get; set; }
		[CProperty(ColumnPath ="WorkspaceId")]
		public Guid WorkspaceId { get; set; }
		[CProperty(ColumnPath ="WorkspaceName")]
		public string WorkspaceName { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
