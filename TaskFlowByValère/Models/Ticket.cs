using System.ComponentModel.DataAnnotations;

namespace TaskFlowForValere.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le titre est obligatoire")]
        [Display(Name = "Titre")]
        public string Titre { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Priorité")]
        public string Priorite { get; set; } = "Normale";

        [Display(Name = "Statut")]
        public string Statut { get; set; } = "À faire";

        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; } = DateTime.Now;

        // Clé étrangère vers Projet
        public int ProjetId { get; set; }
        public Projet? Projet { get; set; }

        // Assigné à quel utilisateur
        [Display(Name = "Assigné à")]
        public string? AssigneA { get; set; }
    }
}