public class Hand : List<Domino>
{
    public Hand() : base()
    {
    }

    public Hand(IEnumerable<Domino> dominos) : base(dominos)
    {
    }

    public void Sort()
    {
        this.Sort((d1, d2) => d1.Score.CompareTo(d2.Score));
    }

    public bool ContainsDomino(Domino domino)
    {
        return this.Any(d => d.Side1 == domino.Side1 && d.Side2 == domino.Side2);
    }

    public void AddDomino(Domino domino)
    {
        this.Add(domino);
    }

    public void RemoveDomino(Domino domino)
    {
        this.Remove(domino);
    }
}