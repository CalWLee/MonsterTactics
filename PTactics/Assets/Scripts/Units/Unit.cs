using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Tactics.Battle;

public class Unit : MonoBehaviour {

    private Dictionary<BaseMove, int> movesLearned;

    public string Name;
    public string Nickname;

    public short HP;


	// Use this for initialization
	void Start () {

        BaseMove tackle = new BaseMove("Tackle", PType.Normal, Category.Physical, 35, 50, 100);
        movesLearned.Add(tackle, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
