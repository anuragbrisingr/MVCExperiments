namespace FirstMVCApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KanbanColumn")]
    public partial class KanbanColumn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KanbanColumn()
        {
            KanbanCards = new HashSet<KanbanCard>();
        }

        public Guid KanbanColumnID { get; set; }

        [Required]
        [StringLength(25)]
        public string KanbanColumnName { get; set; }

        public Guid? KanbanCardId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KanbanCard> KanbanCards { get; set; }

        public virtual KanbanCard KanbanCard { get; set; }
    }
}
