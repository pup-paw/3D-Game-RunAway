//NPCCollision.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NPCCollision : MonoBehaviour
{
    public GameObject explosion;
    public int healthValue = 10;
    void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if (player != null)
        {
            Instantiate(explosion, collision.transform.position + Vector3.up, collision.transform.rotation);
            player.ChangeHealth(-1);
            Destroy(collision.gameObject);
        }
        else return;      // Floor Ȥ�� �ٸ� ��ü���� �浹 ����
    }
}
