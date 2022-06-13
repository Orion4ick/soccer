using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject area;
    [HideInInspector]
    public SoccerMasterController envController;
    public string redGateTag; //will be used to check if collided with purple goal
    public string blueGateTag; //will be used to check if collided with blue goal

    void Start()
    {
        envController = area.GetComponent<SoccerMasterController>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(redGateTag)) //ball touched purple goal
        {
            //Debug.Log("==****ball touched RED GATE");
            envController.GoalTouched(Team.Blue);
        }
        if (col.gameObject.CompareTag(blueGateTag)) //ball touched blue goal
        {
            //Debug.Log("==****ball touched BLUE GATE");
            envController.GoalTouched(Team.Purple);
        }
    }
}
