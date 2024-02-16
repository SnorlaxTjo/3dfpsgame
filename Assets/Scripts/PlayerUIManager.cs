using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lastObjectHitText;
    [SerializeField] TextMeshProUGUI ammoText;
    [SerializeField] PlayerDataExmaple playerData;

    public static PlayerDataExmaple GlobalPlayerData;

    private void Awake()
    {
        GlobalPlayerData = playerData;
    }

    private void Update()
    {
        lastObjectHitText.text = "Last Object Hit: " + GlobalPlayerData.lastObjectHit;
        ammoText.text = "Ammo: " + GlobalPlayerData.ammo;
    }
}
