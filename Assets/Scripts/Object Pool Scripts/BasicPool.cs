using System.Collections.Generic;
using UnityEngine;

public class BasicPool : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    private Queue<GameObject> available = new Queue<GameObject>();
    public List<GameObject> poolObjects;
    public static BasicPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        MakePool(10);
    }

    public GameObject GetFromPool()
    {
        if (available.Count == 0)
            MakePool(5);

        var instance = available.Dequeue();
        instance.SetActive(true);
        return instance;
    }

    private void MakePool(int size)
    {
        for (int i = 0; i < size; i++)
        {
            var instanceToAdd = Instantiate(prefab);
            instanceToAdd.transform.SetParent(transform);
            AddToPool(instanceToAdd);
        }
    }

    public void AddToPool(GameObject instance)
    {
        instance.SetActive(false);
        available.Enqueue(instance);
    }
}