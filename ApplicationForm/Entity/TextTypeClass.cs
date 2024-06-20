using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationForm.Entity
{
    public class TextTypeClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Awnser { get; set; }
        public int Questionid { get; set; }
        public Question question;
    }
}