using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//What is the best way to get this onto a gameObject?
public class Archer : MonoBehaviour, ICharacter {
    Color colorToBe;

    public Archer(Color newColor)
    {
        colorToBe = newColor;
    }
    public void Spawn()
    {
        GameObject spawn = Instantiate(Resources.Load<GameObject>("Archer"));
        spawn.GetComponent<Renderer>().material.SetColor("_Color", colorToBe);
    }
}
