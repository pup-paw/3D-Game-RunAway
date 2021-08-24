using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCollectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if(player != null)
        {
            GameController.instance.score++;
            GameController.instance.UpdateScore();
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
