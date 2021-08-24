//NPCMove.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;    // �׺���̼� ������Ʈ 
    Transform objectToChase;              // �߰��� ��ġ

    public void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        objectToChase = GameObject.FindGameObjectWithTag("Player").transform;     // �÷��̾� ��ġ��
        if (_navMeshAgent == null)
        {
            Debug.LogError("Nav Mesh Agent component not found attached to " + gameObject.name);
        }
        else _navMeshAgent.SetDestination(objectToChase.position);            // �÷��̾ ���� �̵�
    }

    public void Update()
    {
        objectToChase = GameObject.FindGameObjectWithTag("Player").transform;
        _navMeshAgent.SetDestination(objectToChase.position);
    }
}
