using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WebService")]
	public class WebService : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="GenerateProxy")]
		public bool GenerateProxy { get; set; }
		[CProperty(ColumnPath ="HTTPAuthTypeId")]
		public Guid HTTPAuthTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Login")]
		public string Login { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Namespace")]
		public string Namespace { get; set; }
		[CProperty(ColumnPath ="Password")]
		public string Password { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Timeout")]
		public int Timeout { get; set; }
		[CProperty(ColumnPath ="WebServiceURLId")]
		public Guid WebServiceURLId { get; set; }
		[CProperty(ColumnPath ="WSDL")]
		public string WSDL { get; set; }
		[CProperty(ColumnPath ="WSDLURL")]
		public string WSDLURL { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="HTTPAuthType:HTTPAuthTypeId")]
		public HTTPAuthType HTTPAuthType { get; set; }
		[CProperty(Navigation ="WebServiceURL:WebServiceURLId")]
		public WebServiceURL WebServiceURL { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="WebServiceURL:WebServiceId")]
		public virtual ICollection<WebServiceURL> WebServiceURLByWebService { get; set; }
		#endregion
	}
}
