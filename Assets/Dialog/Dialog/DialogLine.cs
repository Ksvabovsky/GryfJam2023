using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogLine
{
    public Actor actor;
    public string text;

    public DialogLine (Actor actor, string text)
    {
        this.actor = actor;
        this.text = text;
    }

}
