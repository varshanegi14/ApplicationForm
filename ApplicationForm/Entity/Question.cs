using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApplicationForm.Entity
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Text { get; set; }
        public QuestionType QuestionType { get; set; }
        public TextTypeClass? TextTypesclass { get; set; } = new();
        public BooleanTypeClass? Booltypeclass { get; set; } = new();
        public DropDownClass? DropDownClass { get; set; } = new();
        public MCQTypeClass? MCQTypeClass { get; set; } = new();
        public DateTypeClass? DateTypeClass { get; set; } = new();
        public NumberTypeClass? NumberTypeClass { get; set; } = new();
        public int FormId { get; set; }
        public FormNumber FormNumber { get; set; } = new();
    }
    public enum QuestionType
    {
        TextType,
        BoolType,
        DropDownType,
        MCQType,
        DateType,
        NumberType
    }

}
