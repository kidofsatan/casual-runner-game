using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCounter : MonoBehaviour
{
    [SerializeField]private Player player;
    [SerializeField]private float currentAmmo = 30;

    private void Awake()
    {
        
    }

    public void AddAmmo(float ammo)
    {
        currentAmmo += ammo;
    }

    public void UseAmmo()
    {
        currentAmmo -= 1;
    }
}
