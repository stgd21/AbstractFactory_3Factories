using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralFactory : ICharacterFactory
{
    public ICharacter Create(Requirements requirements)
    {
        Color powerAddedColor = new Color(requirements.power / 5, 0, 0);
        switch (requirements.range)
        {
            case 1:
            case 2:
            case 3:
                return new Tank(Color.green + powerAddedColor);
            default:
                return new Archer(Color.green + powerAddedColor);
        }
    }
}