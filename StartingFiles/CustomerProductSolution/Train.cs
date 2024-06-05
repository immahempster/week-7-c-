public abstract class Train : IEnumerable<Domino>
{
    protected List<Domino> dominos;

    public Train()
    {
        dominos = new List<Domino>();
    }

    public Train(int engineValue)
    {
        dominos = new List<Domino>();
        // set the engine value
    }

    public int Count
    {
        get { return dominos.Count; }
    }

    public int EngineValue
    {
        get { return dominos[0].Side1; }
    }

    public bool IsEmpty
    {
        get { return dominos.Count == 0; }
    }

    public Domino LastDomino
    {
        get { return dominos[dominos.Count - 1]; }
    }

    public int PlayableValue
    {
        get { return LastDomino.Side2; }
    }

    public Domino GetDomino(int index)
    {
        return dominos[index];
    }

    public abstract bool IsPlayable(Hand hand, Domino domino);

    public void PlayDomino(Hand hand, Domino domino)
    {
        if (IsPlayable(hand, domino))
        {
            dominos.Add(domino);
        }
        else
        {
            throw new Exception("Domino is not playable");
        }
    }

    public IEnumerator<Domino> GetEnumerator()
    {
        return dominos.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        string output = "";
        foreach (Domino domino in dominos)
        {
            output += domino.ToString() + "\n";
        }
        return output;
    }
}