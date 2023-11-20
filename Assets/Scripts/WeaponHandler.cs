using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    [SerializeField] List<Weapon> allHeldWeapons;
    [SerializeField] Weapon currentWeapon;
    [SerializeField] float mouseAxisWeaponSwapBreakpoint;

    float mouseAxisDelta;
    WeaponState currentWeaponState;

    private void Update()
    {
        HandleWeaponSwap();

        if (Input.GetMouseButtonDown(0))
        {
            FireHeldWeapon();
        }
    }

    void HandleWeaponSwap()
    {
        mouseAxisDelta -= Input.mouseScrollDelta.y;
        if (Mathf.Abs(mouseAxisDelta) > mouseAxisWeaponSwapBreakpoint)
        {
            int swapDirectionNumber = (int)Mathf.Sign(mouseAxisDelta);
            mouseAxisDelta -= swapDirectionNumber * mouseAxisWeaponSwapBreakpoint;

            int currentWeaponIndex = (int)currentWeaponState + swapDirectionNumber;
            if (currentWeaponIndex >= (int)WeaponState.total)
            {
                currentWeaponIndex = 0;
            }
            else if (currentWeaponIndex < 0)
            {
                currentWeaponIndex = (int)WeaponState.total - 1;
            }
            Debug.Log(currentWeaponIndex);
            WeaponSwapAnimation(currentWeaponIndex);
        }
    }

    private void WeaponSwapAnimation(int currentWeaponIndex)
    {
        currentWeapon.gameObject.SetActive(false);
        currentWeaponState = (WeaponState)currentWeaponIndex;
        currentWeapon = allHeldWeapons[currentWeaponIndex];
        currentWeapon.gameObject.SetActive(true);
        mouseAxisDelta = 0;
    }

    public void FireHeldWeapon()
    {
        if (currentWeapon != null)
        {
            currentWeapon.Fire();
        }
    }
}
