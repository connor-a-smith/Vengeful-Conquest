﻿using UnityEngine;
using System.Collections;

public class ArmyDataScript : MonoBehaviour {

	/* Soldier constants */
    private static int partySoldierCount = 5;
    
    /* Soldier Indeces */
    private static int soldier1 = 0;
    private static int soldier2 = 1;
    private static int soldier3 = 2;
    private static int soldier4 = 3;
    private static int soldier5 = 4;
    
	/* Party Soldier Array */
	public GameObject[] partySoldiers = new GameObject[partySoldierCount];
	
	void Awake() {
	
    }
	
	void Start() {
	
	}


}