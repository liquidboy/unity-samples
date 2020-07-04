using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
