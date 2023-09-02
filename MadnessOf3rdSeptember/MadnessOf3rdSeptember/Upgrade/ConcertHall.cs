﻿namespace MadnessOf3rdSeptember.Upgrade;

public class ConcertHall : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public ConcertHall()
    {
        Name = "ConcertHall";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 2;
        Description =
            "Концертный зал 'Календарь': Организовывай концерты Шуфутинского, чтобы собрать аплодисменты, которые ускоряют перевороты календаря.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = (CurrentCost + StartCost) * 200 / 150;
    }
}