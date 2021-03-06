﻿
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class ECSManager : MonoBehaviour
{
    public static EntityManager manager;
    public GameObject virusPrefab;

    public int numVirus = 500;
    BlobAssetStore store;
    // Start is called before the first frame update
    void Start()
    {
        store = new BlobAssetStore();
        manager = World.DefaultGameObjectInjectionWorld.EntityManager;
        var settings = GameObjectConversionSettings.FromWorld(World.DefaultGameObjectInjectionWorld, store);
        Entity virus = GameObjectConversionUtility.ConvertGameObjectHierarchy(virusPrefab, settings);
        for (int i = 0; i < numVirus; i++)
        {
            var instance = manager.Instantiate(virus);
            float x = UnityEngine.Random.Range(-50, 50);
            float y = UnityEngine.Random.Range(-50, 50);
            float z = UnityEngine.Random.Range(-50, 50);

            float3 position = new float3(x, y, z);
            manager.SetComponentData(instance, new Translation { Value = position });
            float rspeed = UnityEngine.Random.Range(1, 10)/ 10.0f;
            manager.SetComponentData(instance, new FloatData { speed = 0.1f });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDestroy()
    {
        store.Dispose();    
    }
}
