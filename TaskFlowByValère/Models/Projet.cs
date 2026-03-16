using System.ComponentModel.DataAnnotations;

namespace TaskFlowByValere.Models
{
    public class Projet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [Display(Name = "Nom du projet")]
        public string Nom { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; } = DateTime.Now;

        [Display(Name = "Statut")]
        public string Statut { get; set; } = "En cours";

        // Relation : un projet a plusieurs tickets
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}