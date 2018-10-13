using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour {
    public Rigidbody2D rb;
    float move;
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(move * 0.2f, 0, 0);

        
	}
    private void OnCollisionEnter2D(Collision2D collision)
     {
        SceneManager.LoadScene(1);
    }
    private void FixedUpdate()
    {
       transform.position += new Vector3(0,.2f, 0);
    }
}
