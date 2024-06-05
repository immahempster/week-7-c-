public class Domino : IComparable<Domino>
{
    public int Side1 { get; set; }
    public int Side2 { get; set; }

    public int Score
    {
        get { return Side1 + Side2; }
    }

    public Domino(int side1, int side2)
    {
        Side1 = side1;
        Side2 = side2;
    }

    public int CompareTo(Domino other)
    {
        return Score.CompareTo(other.Score);
    }

    public override string ToString()
    {
        return $"Domino: {Side1} - {Side2}";
    }
}