
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerRotation : MonoBehaviour 
{
   
    private RectTransform rectTrans;

	void Start () 
	{
       
        rectTrans = GetComponent<RectTransform>();
	}
	
	void Update () 
	{
        rectTrans.eulerAngles = Camera.main.transform.eulerAngles;
	}
}
