using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "UserSessionsNew")]
	public class UserSessionsNew : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Count")]
		public int Count { get; set; }
		[CProperty(ColumnPath ="DatabaseName")]
		public string DatabaseName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="SessionDate")]
		public DateTime SessionDate { get; set; }
		[CProperty(ColumnPath ="UserName")]
		public string UserName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
