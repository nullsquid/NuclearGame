using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerManager : MonoBehaviour {
    public NodeGenerator gen;
    public List<Node> noPlayerAssigned;
    public List<Node> playerAssigned;
    public int numOfPlayers;
    public int territoriesPerPlayer;
    private int howManyTerritories;
    public int HowManyTerritories {
        get { return howManyTerritories; }
    }
    public void AssignPlayers() {
        //gen = GameObject.Find("NodeGenerator").GetComponent<NodeGenerator>();
        for(int i = 0; i < gen.allNodes.Count; i++) {
            if(gen.allNodes[i].player == 0) {
                noPlayerAssigned.Add(gen.allNodes[i]);
            }
            
            
            
        }
        for(int j = 0; j < noPlayerAssigned.Count; j++) {
            
           
        }
        
        
    }
    // Use this for initialization
    void Start() {
        Setup();
        //AssignPlayers();

    }
	
	// Update is called once per frame
	void Setup() {
        if (numOfPlayers <= 1) {
            numOfPlayers = 2;
        }
        if(territoriesPerPlayer < 1) {
            territoriesPerPlayer = 1;
        }
        howManyTerritories = numOfPlayers * territoriesPerPlayer;
        
        
    }
}
