using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����� �� ����� ���������������� ������, ������������ ��� ���������/��������� �������������
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField] private float playerHealth = 100;
    [SerializeField]private AmmoCounter ammoCounter;

    
    /// <summary>
    /// ����� ���������� �������� ������ (��� ����� � ������ ������) 
    /// </summary>
    public void AddHealth(float health)
    {
        playerHealth += health;
        Debug.Log("+ 100 ��");
    }

    /// <summary>
    /// ����� ���������� �������� ������
    /// </summary>
    public void AddAmmo(float ammo)
    {
        ammoCounter.AddAmmo(ammo);
    }
}
