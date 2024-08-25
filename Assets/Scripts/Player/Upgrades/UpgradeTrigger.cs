using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Коллайдер задет");
        if (other.CompareTag("Player"))
            {
            UpgradeModule module = GetComponent<UpgradeModule>();
            Player upgrader = other.GetComponent<Player>();
            Debug.Log(module, upgrader);
            if (module != null && module.upgrade != null && upgrader != null)
                {
                Debug.Log("Upgrade найден");
                ApplyUpgrade(module.upgrade, upgrader);
                }
            }
    }

    void ApplyUpgrade(Upgrade upgrade, Player playerUpgrader)
    {
        switch (upgrade.upgradeType)
        {
            case UpgradeType.Health:
                playerUpgrader.AddHealth(upgrade.value);
                break;
            case UpgradeType.Ammo:
                playerUpgrader.AddAmmo(upgrade.value);
                break;
        }
    }
}
