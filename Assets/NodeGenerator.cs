using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class NodeGenerator : MonoBehaviour {
    public List<Node> allNodes = new List<Node>();
    public List<Node> connectedNodes = new List<Node>();
    public List<Vector3> nodePositions = new List<Vector3>();
    public Node nodePrefab;
    int numberOfNodes;
    public float sizeOfBoard;
    public List<int> randNumberList = new List<int>();
    public void GenerateNodes() {
        
        for(int i = 0; i< numberOfNodes; i++) {
            Node newNode = Instantiate(nodePrefab, Random.insideUnitCircle * sizeOfBoard + (new Vector2(nodePrefab.GetComponent<Renderer>().bounds.size.x * 2, nodePrefab.GetComponent<Renderer>().bounds.size.y * 2)), Quaternion.identity) as Node;
            
            
            nodePositions.Add(newNode.transform.position);
            int id = i;
            allNodes.Add(newNode);
            newNode.transform.parent = gameObject.transform;
            newNode.name = id.ToString();
            //CreateNeighbors(newNode);
            
        }
        for(int j = 0; j < allNodes.Count; j++) {
            CreateNeighbors(allNodes[j], j);
        }


    }
    
    void CreateNeighbors(Node curNode, int curIndex) {
        randNumberList.Clear();
        int randNum;
        for (int i = 0; i < allNodes.Count; i++) {
            if(i != curIndex) {
                randNumberList.Add(i);
                //not accurate
                //Debug.Log(randNumberList.Count);
            }
        }

        randNum = Random.Range(0, randNumberList.Count);
        curNode.con1 = allNodes[randNum];
        randNumberList.RemoveAt(randNum);
        Debug.Log("randnumber has " + randNumberList.Count);

        randNum = Random.Range(0, randNumberList.Count);
        curNode.con2 = allNodes[randNum];
        randNumberList.RemoveAt(randNum);
        Debug.Log("randnumber has " + randNumberList.Count);


        randNum = Random.Range(0, randNumberList.Count);
        curNode.con3 = allNodes[randNum];
        randNumberList.RemoveAt(randNum);
        Debug.Log("randnumber has " + randNumberList.Count);



    }

    

    void Start() {
        numberOfNodes = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>().HowManyTerritories;
        sizeOfBoard = 10 + (GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>().HowManyTerritories * .2f);
        Camera.main.orthographicSize = 15 + (GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>().HowManyTerritories * .2f);
        GenerateNodes();
        GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManager>().AssignPlayers();

    }
}
