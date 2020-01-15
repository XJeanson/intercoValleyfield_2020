using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvements : MonoBehaviour {

    public float playerSpeed;

    private Animator anim;
    private char playerState;
	
    // Use this for initialization
	void Start () {

        playerSpeed = 2f;
        anim = GetComponent<Animator>();
        playerState = 'R';
    }

	// Update is called once per frame
	void Update () {

        // Movements to the right
    if (Input.GetAxisRaw("Horizontal") > 0)
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime, 0f, 0f));
            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("standing", 0f);
            playerState = 'R';

    }

 

        // Movements to the left
    if ( Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime, 0f, 0f));
            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("standing", 0f);
            playerState = 'L';
        }

        // Standing to the right
    if (Input.GetAxisRaw("Horizontal") == 0 && playerState == 'R')
        {
            anim.SetFloat("standing", 1f);
            anim.SetFloat("MoveX", 0f);
        }
        // Standing to the left
    if(Input.GetAxisRaw("Horizontal")==0 && playerState == 'L')
        {
            anim.SetFloat("standing", -1f);
            anim.SetFloat("MoveX", 0f);
        }

}
}
