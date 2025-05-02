namespace SpotManager.model;

public class Poste(int id, Local local, int bureau)
{
    int Id { get; set; } = id;
    Local Local { get; set; } = local;
    int Bureau { get; set; } = bureau;
}