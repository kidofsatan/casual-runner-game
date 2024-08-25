using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UpgradeType
{
    Health,
    Ammo,
    Shield
}

[CreateAssetMenu ]
public class Upgrade : ScriptableObject
{
    public UpgradeType upgradeType;
    public float value;
}
