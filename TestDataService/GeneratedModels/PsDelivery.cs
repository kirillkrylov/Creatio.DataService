using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsDelivery")]
	public class PsDelivery : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectEnvironmentId")]
		public Guid ProjectEnvironmentId { get; set; }
		[CProperty(ColumnPath ="ProjectSolutionId")]
		public Guid ProjectSolutionId { get; set; }
		[CProperty(ColumnPath ="ReleaseDate")]
		public DateTime ReleaseDate { get; set; }
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId { get; set; }
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Version")]
		public string Version { get; set; }
		[CProperty(ColumnPath ="VersionBuild")]
		public int VersionBuild { get; set; }
		[CProperty(ColumnPath ="VersionMajor")]
		public int VersionMajor { get; set; }
		[CProperty(ColumnPath ="VersionMinor")]
		public int VersionMinor { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProjectSolution:ProjectSolutionId")]
		public ProjectSolution ProjectSolution { get; set; }
		[CProperty(Navigation ="PsDelivery:ReleaseId")]
		public PsDelivery Release { get; set; }
		[CProperty(Navigation ="PsDeliveryResult:ResultId")]
		public PsDeliveryResult Result { get; set; }
		[CProperty(Navigation ="PsDeliveryStatus:StatusId")]
		public PsDeliveryStatus Status { get; set; }
		[CProperty(Navigation ="PsDeliveryType:TypeId")]
		public PsDeliveryType Type { get; set; }
		[CProperty(Navigation ="PsProjectEnvironment:ProjectEnvironmentId")]
		public PsProjectEnvironment ProjectEnvironment { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PsDelivery:ReleaseId")]
		public virtual ICollection<PsDelivery> PsDeliveryByRelease { get; set; }
		[CProperty(Association ="PsDeliveryActivity:PsDeliveryId")]
		public virtual ICollection<PsDeliveryActivity> PsDeliveryActivityByPsDelivery { get; set; }
		[CProperty(Association ="PsDeliveryCheck:PsDeliveryId")]
		public virtual ICollection<PsDeliveryCheck> PsDeliveryCheckByPsDelivery { get; set; }
		[CProperty(Association ="PsDeliveryFile:PsDeliveryId")]
		public virtual ICollection<PsDeliveryFile> PsDeliveryFileByPsDelivery { get; set; }
		[CProperty(Association ="PsDeliveryVisa:PsDeliveryId")]
		public virtual ICollection<PsDeliveryVisa> PsDeliveryVisaByPsDelivery { get; set; }
		#endregion
	}
}
