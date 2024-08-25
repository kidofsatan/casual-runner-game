using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Класс, используемый объектом-улучшением или дебафом
/// </summary>
public class UpgradeModule : MonoBehaviour
{
    public Upgrade upgrade;
    public TextMeshProUGUI upgradeText;

    private void Start()
    {
        upgradeText.text = upgrade.value.ToString();
    }
}
