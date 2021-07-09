using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move 
{
    // this is a short way of doing what was done in MoveBase variables
    // that was private variable cached and property (ex.: type and Type)
    // we dont use this there because in there we wanted to expose 
    // the variables in the inspector
    public MoveBase Base { get; set; }
    public int PP { get; set; }

    public Move(MoveBase pBase)
    {
        Base = pBase;
        PP = pBase.Pp;
    }
}
