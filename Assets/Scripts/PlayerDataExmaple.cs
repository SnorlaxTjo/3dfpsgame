using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData")]
public class PlayerDataExmaple : ScriptableObject
{
    public string lastObjectHit = "";
    public int ammo = 0;
}
