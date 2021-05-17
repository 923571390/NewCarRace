using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour {

    public GameObject TheMarker;
    public GameObject[] Marks;
    public int MarkTracker;

    void Start() {
        JustTrack(MarkTracker);
    }

    public void JustTrack(int i)
    {
        TheMarker.transform.position = Marks[i].transform.position;
        TheMarker.transform.rotation = Marks[i].transform.rotation;
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DreamCar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == Marks.Length)
            {
                MarkTracker = 0;
            }
            JustTrack(MarkTracker);
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
