using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanPaint : MonoBehaviour {

    public Transform[] SpwanPoint;
    public GameObject Paint;
    public int SelectPointNo;
    public Transform SpwanPointTransform;
    public float spwantime = 1f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spwantime -= Time.deltaTime;
        
        if (spwantime <= 0)
        {
            SelectPointNo = Random.Range(0, SpwanPoint.Length);
            SpwanPointTransform = SpwanPoint[SelectPointNo];
            Instantiate(Paint, SpwanPointTransform.position, Quaternion.identity);
            spwantime = 3;
        }
    }
}
