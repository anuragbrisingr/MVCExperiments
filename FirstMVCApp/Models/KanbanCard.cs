namespace FirstMVCApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KanbanCard")]
    public partial class KanbanCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KanbanCard()
        {
            KanbanColumns = new HashSet<KanbanColumn>();
        }

        public Guid KanbanCardID { get; set; }

        [Required]
        [StringLength(50)]
        public string KanbanCardTitle { get; set; }

        public string CardCheckList { get; set; }

        public DateTime DeadlineDate { get; set; }

        public float ProgressPercentage { get; set; }

        public Guid? KanbanColumnId { get; set; }

        public virtual KanbanColumn KanbanColumn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KanbanColumn> KanbanColumns { get; set; }
    }
}
