using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] modules; // Массив префабов модулей
    public Transform playerTransform; // Трансформ игрока
    public float moduleLength = 50f; // Длина каждого модуля
    public float spawnAheadDistance = 200f; // Расстояние, на котором новые модули начинают спавниться

    private float spawnZ = 0f;
    private float safeZone = 100f; // Зона безопасности для предотвращения выхода модулей из сцены

    void Start()
    {
        // Генерируем начальные модули
        for (int i = 0; i < 5; i++)
        {
            SpawnModule();
        }
    }

    void Update()
    {
        // Генерация новых модулей по мере продвижения игрока
        if (playerTransform.position.z > (spawnZ - safeZone))
        {
            SpawnModule();
        }
    }

    void SpawnModule()
    {
        // Выбираем случайный модуль из массива
        GameObject module = Instantiate(modules[Random.Range(0, modules.Length)]);
        module.transform.SetParent(transform);
        module.transform.position = new Vector3(0, 0, spawnZ);
        spawnZ += moduleLength;
    }
}
