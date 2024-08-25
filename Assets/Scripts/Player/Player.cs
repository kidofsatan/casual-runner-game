using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс со всеми характеристиками игрока, используемый для улучшения/ухудшения характеристик
/// </summary>
public class Player : MonoBehaviour
{
    [SerializeField] private float playerHealth = 100;
    [SerializeField]private AmmoCounter ammoCounter;

    
    /// <summary>
    /// Метод добавления здоровья игроку (как будто я завтра забуду) 
    /// </summary>
    public void AddHealth(float health)
    {
        playerHealth += health;
        Debug.Log("+ 100 хп");
    }

    /// <summary>
    /// Метод добавления патронов игроку
    /// </summary>
    public void AddAmmo(float ammo)
    {
        ammoCounter.AddAmmo(ammo);
    }
}
