using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject forward;
    public GameObject backward;
    private void Start()
    {
        if(ddd.stage<4) ddd.stage++;
        else
        {
            backward.SetActive(true);
            forward.SetActive(false);
        }
    }

}
