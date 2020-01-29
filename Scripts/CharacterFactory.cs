using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : AbstractCharacterFactory
{
    //public override ICharacterFactory HeroFactory()
    //{
    //    return new HeroFactory();
    //}

    //public override ICharacterFactory VillainFactory()
    //{
    //    return new VillainFactory();
    //}

    private readonly ICharacterFactory _factory;
    private readonly Requirements _requirements;

    public CharacterFactory(Requirements requirements)
    {
        switch (requirements.alliance)
        {
            case Alliance.Hero:
                _factory = new HeroFactory();
                break;
            case Alliance.Villain:
                _factory = new VillainFactory();
                break;
            case Alliance.Neutral:
                _factory = new NeutralFactory();
                break;
        }
       // _factory = requirements.isEvil ? (ICharacterFactory)new VillainFactory() : new HeroFactory();
        _requirements = requirements;
    }

    public override ICharacter Create()
    {
        return _factory.Create(_requirements);
    }
}
