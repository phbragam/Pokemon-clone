using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PokemonType type;

    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
    [SerializeField] MoveCategory category;
    [SerializeField] MoveEffects effects;
    [SerializeField] MoveTarget target;

    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public PokemonType Type { get { return type; } }
    public int Power { get { return power; } }
    public int Accuracy { get { return accuracy; } }
    public int Pp { get { return pp; } }

    public MoveCategory Category { get { return category; } }
    public MoveEffects Effects { get { return effects; } }
    public MoveTarget Target { get { return target; } }


}

[System.Serializable]
public class MoveEffects
{
    [SerializeField] List<StatBoost> boosts;
    [SerializeField] ConditionID status;
    public List<StatBoost> Boosts
    {
        get { return boosts; }
    }

    public ConditionID Status
    {
        get { return status; }
    }
}

[System.Serializable]
public class StatBoost
{
    // the only purpose of this class is to be shown as a list in the inspector
    // so, there is no problem in the variables be public
    public Stat stat;
    public int boost;
}

public enum MoveCategory
{
    Physical, Special, Status
}

// not using a bool to be able to expand when using features like double battles
public enum MoveTarget
{
    Foe, Self
}
