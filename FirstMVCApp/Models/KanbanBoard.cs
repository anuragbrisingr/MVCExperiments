namespace FirstMVCApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KanbanBoard")]
    public partial class KanbanBoard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KanbanBoard()
        {
            KanbanColumns = new HashSet<KanbanColumn>();
        }

        public Guid KanbanBoardID { get; set; }

        [Required]
        [StringLength(25)]
        public string KanbanBoardName { get; set; }

        public virtual ICollection<KanbanColumn> KanbanColumns { get; set; }
    }
}
