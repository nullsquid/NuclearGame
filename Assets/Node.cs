using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Node : MonoBehaviour {
    public bool accessible;

    public Node con1;
    public Node con2;
    public Node con3;

    public int player = 0;
    void OnTriggerStay(Collider other) {
        transform.position = Random.insideUnitCircle * GetComponentInParent<NodeGenerator>().sizeOfBoard;
        
    }

}
