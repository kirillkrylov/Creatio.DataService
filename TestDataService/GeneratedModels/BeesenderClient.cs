using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderClient")]
	public class BeesenderClient : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="Country")]
		public string Country { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FirstName")]
		public string FirstName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId { get; set; }
		[CProperty(ColumnPath ="Language")]
		public string Language { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NickName")]
		public string NickName { get; set; }
		[CProperty(ColumnPath ="PhotoSrc")]
		public string PhotoSrc { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SecondName")]
		public string SecondName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChat:ClientId")]
		public virtual ICollection<BeesenderChat> BeesenderChatByClient { get; set; }
		[CProperty(Association ="BeesenderChatMessage:ClientId")]
		public virtual ICollection<BeesenderChatMessage> BeesenderChatMessageByClient { get; set; }
		#endregion
	}
}
