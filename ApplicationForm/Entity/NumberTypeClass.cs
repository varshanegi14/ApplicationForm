using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationForm.Entity
{
    public class NumberTypeClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? Awnser { get; set; }
        public int Questionid { get; set; }
        public Question question;
    }
}