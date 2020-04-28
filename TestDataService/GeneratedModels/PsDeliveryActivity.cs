using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsDeliveryActivity")]
	public class PsDeliveryActivity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath ="AddInVersion")]
		public string AddInVersion { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="JiraComponent")]
		public string JiraComponent { get; set; }
		[CProperty(ColumnPath ="JiraEpic")]
		public string JiraEpic { get; set; }
		[CProperty(ColumnPath ="JiraEpicName")]
		public string JiraEpicName { get; set; }
		[CProperty(ColumnPath ="JiraIncidentNumber")]
		public string JiraIncidentNumber { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PsDeliveryId")]
		public Guid PsDeliveryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PsDelivery:PsDeliveryId")]
		public PsDelivery PsDelivery { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
