using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize;
    private Queue<GameObject> pool;
    void Start()
    {
        pool = new Queue<GameObject>();
        for(int i = 0; i < poolSize; i++)
        {
            GameObject spawnedPrefab = Instantiate(prefab);
            spawnedPrefab.SetActive(false);
            pool.Enqueue(spawnedPrefab);
        }
    }

    public GameObject GetObject()
    {
        if(pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            GameObject obj = Instantiate(prefab);
            return obj;
        }
    }

    public void ReturnObject(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
