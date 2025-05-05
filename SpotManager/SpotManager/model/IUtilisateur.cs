namespace SpotManager.model;

public interface IUtilisateur
{
    string Id { get; set; }
    string Nom { get; set; }
    string Sha256 { get; set; }
}