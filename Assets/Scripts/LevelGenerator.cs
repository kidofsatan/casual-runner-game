using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] modules; // ������ �������� �������
    public Transform playerTransform; // ��������� ������
    public float moduleLength = 50f; // ����� ������� ������
    public float spawnAheadDistance = 200f; // ����������, �� ������� ����� ������ �������� ����������

    private float spawnZ = 0f;
    private float safeZone = 100f; // ���� ������������ ��� �������������� ������ ������� �� �����

    void Start()
    {
        // ���������� ��������� ������
        for (int i = 0; i < 5; i++)
        {
            SpawnModule();
        }
    }

    void Update()
    {
        // ��������� ����� ������� �� ���� ����������� ������
        if (playerTransform.position.z > (spawnZ - safeZone))
        {
            SpawnModule();
        }
    }

    void SpawnModule()
    {
        // �������� ��������� ������ �� �������
        GameObject module = Instantiate(modules[Random.Range(0, modules.Length)]);
        module.transform.SetParent(transform);
        module.transform.position = new Vector3(0, 0, spawnZ);
        spawnZ += moduleLength;
    }
}
