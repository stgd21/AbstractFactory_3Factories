using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillainFactory : ICharacterFactory
{
    public ICharacter Create(Requirements requirements)
    {
        Color powerAddedColor = new Color(requirements.power / 5, 0, 0);
        switch (requirements.range)
        {
            case 1:
            case 2:
            case 3:
                return new Tank(Color.black + powerAddedColor);
            default:
                return new Archer(Color.black + powerAddedColor);
        }
    }
}
