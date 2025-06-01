using System;

public class DebuggerDana : StudentHero
{
    private Random rand = new Random();

    public DebuggerDana(string name) : base(name, 100) { }

    public override int Attack()
    {
        return rand.Next(10, 21); // Random damage between 10 and 20
    }
}