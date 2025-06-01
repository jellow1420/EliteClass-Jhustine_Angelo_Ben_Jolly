public abstract class StudentHero
{
    public string Name { get; set; }
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; }

    public StudentHero(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
    }

    public abstract int Attack();

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }
}