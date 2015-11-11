using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerManager : MonoBehaviour {
    public NodeGenerator gen;
    public int numOfPlayers;
    public int territoriesPerPlayer;
    private int howManyTerritories;
    public int HowManyTerritories {
        get { return howManyTerritories; }
    }
    void AssignPlayers() {
        gen = GameObject.Find("NodeGenerator").GetComponent<NodeGenerator>();
        for (int i = 0; i < numOfPlayers; i++) {
            for(int j = 0; j < territoriesPerPlayer; j++) {
                gen.allNodes[j].player = i;
            }
        }
    }
    // Use this for initialization
    void Start () {
        Setup();
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
