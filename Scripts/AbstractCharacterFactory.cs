using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCharacterFactory
{
    //public abstract ICharacterFactory HeroFactory();
    //public abstract ICharacterFactory VillainFactory();

    public abstract ICharacter Create();
}
