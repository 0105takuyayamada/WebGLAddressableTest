using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;

public class LoadPrefab : MonoBehaviour
{
    [SerializeField] AssetReference addressables;

    void Start()
    {
        addressables.LoadAssetAsync<GameObject>().Completed += obj =>
        {
            Instantiate(obj.Result, transform.position, Quaternion.identity);
            addressables.ReleaseAsset();
        };
    }
}