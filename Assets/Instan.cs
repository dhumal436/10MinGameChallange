using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour {

    public GameObject enimy;
    int ypos=0;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            ypos += 5;
            Vector3 pos = new Vector3(Random.Range(-5, 5), ypos, 0);
            Instantiate(enimy, pos, Quaternion.identity);
        }
    }

}
