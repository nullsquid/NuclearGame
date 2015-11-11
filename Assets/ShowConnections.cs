using UnityEngine;
using System.Collections;

public class ShowConnections : MonoBehaviour {

	void OnDrawGizmos() {
        if(GetComponent<Node>().con1.GetComponent<Node>().accessible == false) {
            Gizmos.color = Color.red;
        }
        else {
            Gizmos.color = Color.green;
        }
        if (GetComponent<Node>().con2.GetComponent<Node>().accessible == false) {
            Gizmos.color = Color.red;
        }
        else {
            Gizmos.color = Color.green;
        }
        if (GetComponent<Node>().con3.GetComponent<Node>().accessible == false) {
            Gizmos.color = Color.red;
        }
        else {
            Gizmos.color = Color.green;
        }

        Gizmos.DrawLine(gameObject.transform.position, GetComponent<Node>().con1.transform.position);
        Gizmos.DrawLine(gameObject.transform.position, GetComponent<Node>().con2.transform.position);
        Gizmos.DrawLine(gameObject.transform.position, GetComponent<Node>().con3.transform.position);
    }
}
