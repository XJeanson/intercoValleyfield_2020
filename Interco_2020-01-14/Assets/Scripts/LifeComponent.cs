using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeComponent : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;
    public AudioClip deathSound;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        if (gameObject.GetComponent<AudioSource>() != null)
        {
            AudioSource.PlayClipAtPoint(deathSound, transform.position, 10f);
        }
        GameObject.Destroy(gameObject);
    }

    public void Heal()
    {

    }


}
