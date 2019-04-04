using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
    public NavMeshAgent agent;
    public int followDist;
    public AudioClip growl;
        
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, this.transform.position) < followDist)
        {
            //Debug.Log("Text: " + Vector3.Distance(player.transform.position, this.transform.position));
            //GameObject ground = GameObject.FindWithTag("Ground");
            //Vector3 vector3 = new Vector3(player.transform.position.x, ground.transform.position.y, player.transform.position.z);
            //agent.SetDestination(player.transform.position);

            RaycastHit hit;
            Physics.Raycast(player.transform.position, Vector3.down, out hit);
            agent.SetDestination(hit.point);
        }

        /*
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }*/
    }

    public void ChasePlayer()
    {
        RaycastHit hit;
        Physics.Raycast(player.transform.position, Vector3.down, out hit);
        agent.SetDestination(hit.point);
    }
}
