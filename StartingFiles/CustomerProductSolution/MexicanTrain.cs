public class MexicanTrain : Train
{
    public MexicanTrain() : base()
    {
    }

    public MexicanTrain(int engineValue) : base(engineValue)
    {
    }

    public override bool IsPlayable(Hand hand, Domino domino)
    {
        // Check if the domino can be played on the train
        if (dominos.Count == 0)
        {
            // If the train is empty, any domino can be played
            return true;
        }
        else
        {
            // Check if the domino's sides match the last domino in the train
            Domino lastDomino = dominos[dominos.Count - 1];
            return (domino.Side1 == lastDomino.Side2 || domino.Side2 == lastDomino.Side2);
        }
    }
}