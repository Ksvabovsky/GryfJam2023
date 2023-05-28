using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    public string name;
    public int portraitTag;
    public int SFXTag;
    public bool isMainChar;

    public Actor(string name, int portraitTag, int SFX, bool isMainChar=false)
    {
        this.name = name;
        this.portraitTag = portraitTag;
        this.isMainChar = isMainChar;
        this.SFXTag = SFX;
    }
}
