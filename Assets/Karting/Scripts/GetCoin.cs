using UnityEngine;

/// <summary>
/// This class inherits from TargetObject and represents a PickupObject.
/// </summary>
public class GetCoin : TargetObject
{
    
    private void Start()
    {
        //Register();
        CollectVFXSpawnPoint = gameObject.transform;
    }
    void OnTriggerEnter(Collider other)
    {
        AudioUtility.CreateSFX(CollectSound, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        ddd.coin++;
        Destroy(gameObject);
    }
}
