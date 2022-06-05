using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yogurt.Domain.Entities
{
    public class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id_Usuario { get; set; }

        public EntityBase()
        {
            Id_Usuario = Guid.NewGuid();
        }
    }
}
