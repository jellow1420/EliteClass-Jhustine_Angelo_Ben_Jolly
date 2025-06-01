using System;

public class QuizMasterQuincy : StudentHero
{
    private Random rand = new Random();

    public QuizMasterQuincy(string name) : base(name, 100) { }

    public override int Attack()
    {
        return rand.Next(15, 26); // Random damage between 15 and 25
    }
}