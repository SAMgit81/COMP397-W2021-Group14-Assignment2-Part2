using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;

    private void Start()
    {
        SelectWeapon();
    }

    private void Update()
    {
/*        int previousSelectedWeapon = selectedWeapon;
        if (Input.GetButton("A"))
        {
            selectedWeapon = 0;
        }

        if (Input.GetButton("B") && transform.childCount >= 2)
        {
            selectedWeapon = 1;
        }
        if (Input.GetButton("C") && transform.childCount >= 3)
        {
            selectedWeapon = 2;
        }*/    
    }

    public void OnAbuttonPressed()
    {
        int previousSelectedWeapon = selectedWeapon;
        if (previousSelectedWeapon != selectedWeapon)
        {
            selectedWeapon = 0;
            SelectWeapon();
        }
    }

    public void OnBbuttonPressed()
    {
        int previousSelectedWeapon = selectedWeapon;
        if (previousSelectedWeapon != selectedWeapon)
        {
            selectedWeapon = 1;
            SelectWeapon();
        }

    }
    public void OnCbuttonPressed()
    {
        int previousSelectedWeapon = selectedWeapon;
        if (previousSelectedWeapon != selectedWeapon)
        {
            selectedWeapon = 2;
            SelectWeapon();
        }

    }
    void SelectWeapon()
    {
        int i = 0;

        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(true);
            i++;
        }
    }
}
