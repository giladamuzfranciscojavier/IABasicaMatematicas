using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.LightAnchor;

public class RobberMove : MonoBehaviour
{

    public GameObject cop;
    Vector3 direction;
    float speed = 2f;

    void Update()
    {
        direction = new Vector3(transform.position.x - cop.transform.position.x, 0, transform.position.z - cop.transform.position.z);        

        Debug.DrawRay(this.transform.position, transform.forward * 10, Color.green, Time.deltaTime);
        Debug.DrawRay(this.transform.position, (cop.transform.position - transform.position).normalized*10, Color.red, Time.deltaTime);

        if (direction.magnitude < 10)
        {
            transform.rotation = Quaternion.LookRotation(transform.position - cop.transform.position);
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
