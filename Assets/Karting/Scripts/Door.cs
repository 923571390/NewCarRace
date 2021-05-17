using KartGame.KartSystems;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public GameObject kart;
    public GameObject door;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPostion = door.transform.position;
        kart.transform.position = newPostion;
    }
}
