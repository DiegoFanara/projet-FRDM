namespace SpotManager.model;

public class Professeur(string id, string nom, string sha256) : IUtilisateur
{
    public string Id { get; set; } = id;
    public string Nom { get; set; } = nom;
    public string Sha256 { get; set; } = sha256;
}