using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foolowcam : MonoBehaviour {

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, .2f, 0);
    }
}
