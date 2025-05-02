namespace SpotManager.model;

public class Reservation(int id, IUtilisateur utilisateur, Poste poste, long tempsDebut, long tempsFin, int priorite)
{
    int Id { get; set; } = id;
    IUtilisateur Utilisateur { get; set; } = utilisateur;
    Poste Poste { get; set; } = poste;
    long TempsDebut { get; set; } = tempsDebut;
    long TempsFin { get; set; } = tempsFin;
    int Priorite { get; set; } = priorite;
}