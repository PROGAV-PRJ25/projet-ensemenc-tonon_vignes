// =======================================================================
// Classe Terrain
// -----------------------------------------------------------------------
// Cette classe abstraite centralise la logique principale des terrains
// Elle gère :
//   - Les propriétés d'humidité, d'exposition, de drainage et de fertilité
//   - Les méthodes pour arroser et afficher l'état du terrain
//   - Les règles de validation pour chaque propriété
// =======================================================================
public abstract class Terrain
{
    protected int _tauxHumidite;
    protected int _tauxExposition;
    public int TauxHumidite
    {
        get
        {
            return _tauxHumidite;
        }
        set
        {
            if (value > 100)
                _tauxHumidite = 100;
            else if (value < 0)
                _tauxHumidite = 0;
            else
                _tauxHumidite = value;
        }
    }
    // taux d'humidité sur 100, fournit la plante en eau
    // pour les fleurs arbres et arbustes, entre 21 et 40%
    // pour les légumes entre 40 et 80% (idéal 60)
    public int TauxExposition
    {
        get
        {
            return _tauxExposition;
        }
        set
        {
            if (value > 100)
                _tauxExposition = 100;
            else if (value < 0)
                _tauxExposition = 0;
            else
                _tauxExposition = value;
        }
    }
    public int Drainage { get; set; }
    // indique la quantité d'eau perdue durant une semaine
    private int _fertilite;
    public int Fertilite
    {
        get
        {
            return _fertilite;
        }
        set
        {
            if (value > 10)
                _fertilite = 10;
            else if (value < 0)
                _fertilite = 0;
            else
                _fertilite = value;
        }
    }
    public void Arroser(int quantiteEau)
    {
        TauxHumidite = TauxHumidite + quantiteEau > 100 ? 100 : TauxHumidite + quantiteEau;
    }
    public override string ToString()
    {
        string reponse = $"- Humidité: {TauxHumidite}%\n";
        reponse += $"- Exposition: {TauxExposition}%\n";
        reponse += $"- Fertilité: {Fertilite}";
        return reponse;
    }
}
public class TerrainArgileux : Terrain
{
    public TerrainArgileux()
    {

        TauxHumidite = 50;
        Drainage = 10;
        Fertilite = 0;
        TauxExposition = 50;

    }

}



