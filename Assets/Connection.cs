using UnityEngine;
using System.Collections;

public class Connection : MonoBehaviour {
    Node parentNode;
    // Use this for initialization
    void Start() {
        parentNode = GetComponentInParent<Node>();
        gameObject.GetComponent<LineRenderer>().SetWidth(.09f, .09f);
        FindConnections();
    }

    void FindConnections() {
        
        if (parentNode.con1) {
            gameObject.GetComponent<LineRenderer>().SetPosition(0, gameObject.transform.position);
            gameObject.GetComponent<LineRenderer>().SetPosition(1, parentNode.con1.transform.position);
        }
        if (parentNode.con2) {
            gameObject.GetComponent<LineRenderer>().SetPosition(2, gameObject.transform.position);
            gameObject.GetComponent<LineRenderer>().SetPosition(3, parentNode.con2.transform.position);
        }
        if (parentNode.con2) {
            gameObject.GetComponent<LineRenderer>().SetPosition(4, gameObject.transform.position);
            gameObject.GetComponent<LineRenderer>().SetPosition(5, parentNode.con3.transform.position);
        }

    }
}
