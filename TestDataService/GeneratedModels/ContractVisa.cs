using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContractVisa")]
	public class ContractVisa : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DelegatedFromId")]
		public Guid DelegatedFromId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsAllowedToDelegate")]
		public bool IsAllowedToDelegate { get; set; }
		[CProperty(ColumnPath ="IsCanceled")]
		public bool IsCanceled { get; set; }
		[CProperty(ColumnPath ="IsRequiredDigitalSignature")]
		public bool IsRequiredDigitalSignature { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Objective")]
		public string Objective { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SetById")]
		public Guid SetById { get; set; }
		[CProperty(ColumnPath ="SetDate")]
		public DateTime SetDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="VisaOwnerId")]
		public Guid VisaOwnerId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:SetById")]
		public Contact SetBy { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="SysAdminUnit:VisaOwnerId")]
		public SysAdminUnit VisaOwner { get; set; }
		[CProperty(Navigation ="SysAdminUnit:DelegatedFromId")]
		public SysAdminUnit DelegatedFrom { get; set; }
		[CProperty(Navigation ="VisaStatus:StatusId")]
		public VisaStatus Status { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
