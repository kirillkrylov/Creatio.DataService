using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GameTitle")]
	public class GameTitle : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ContactGameProfile:TitleId")]
		public virtual ICollection<ContactGameProfile> ContactGameProfileByTitle { get; set; }
		[CProperty(Association ="ContactGameTitle:GameTitleId")]
		public virtual ICollection<ContactGameTitle> ContactGameTitleByGameTitle { get; set; }
		#endregion
	}
}
