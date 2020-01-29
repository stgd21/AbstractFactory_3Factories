using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AF_Client : MonoBehaviour
{
    public Slider rangeValues;
    public Slider powerValues;
    public Dropdown allianceSelection;

    [Header("Color determination")]
    public Alliance newAlliance = Alliance.Villain;
    [Header("Archer if greater than 3 (out of 5 total)")]
    public int range = 1;
    [Header("Power will affect the base color")]
    public int newPower = 1;


    private Requirements requirements;
    private ICharacter newCharacter;
    // Start is called before the first frame update
    void Start()
    {
        requirements = new Requirements();
        requirements.alliance = newAlliance;
        requirements.range = range;
        requirements.power = newPower;
    }

    private ICharacter GetCharacter(Requirements requirements)
    {
        CharacterFactory factory = new CharacterFactory(requirements);
        newCharacter = factory.Create();
        return newCharacter;
    }

    public void Create()
    {
        newCharacter = GetCharacter(requirements);
        newCharacter.Spawn();
    }

    public void SetNewRange()
    {
        requirements.range = (int)rangeValues.value;
    }

    public void SetNewPower()
    {
        requirements.power = (int)powerValues.value;
    }

    public void SetNewAlliance()
    {
        switch (allianceSelection.value)
        {
            case 0:
                requirements.alliance = Alliance.Villain;
                break;
            case 1:
                requirements.alliance = Alliance.Hero;
                break;
            case 2:
                requirements.alliance = Alliance.Neutral;
                break;
        }
    }

    public void DestroyAll()
    {
        GameObject[] allCharacters = GameObject.FindGameObjectsWithTag("Character");
        for (int i = 0; i < allCharacters.Length; i++)
            Destroy(allCharacters[i]);
    }
}
