using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera_Action : MonoBehaviour
{
    
    GameObject player;
    public float offsetX = 0f;
    public float offsetY = 3f;
    public float offsetZ = -8f;

    Vector3 cameraPosition;
    public float followSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = Vector3.Lerp(transform.position, cameraPosition, followSpeed * Time.deltaTime);
    }
}
