﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextureChange : MonoBehaviour {
    public List<Material> materials; 
    //public Texture2D texture;
    private MeshRenderer currentRenderer;
    int pNum;
    int tNum;
	// Use this for initialization
	void Start () {
        pNum = gameObject.GetComponent<PlayerControls>().playerNum;
        print("Starting Player: " + pNum);
        tNum = PlayerPrefs.GetInt("p"+pNum+"ball");
        currentRenderer = gameObject.GetComponent<MeshRenderer>();
        if(tNum != -2)
        {
            print("Player " + pNum + " Color: " + tNum);
            currentRenderer.material = materials[tNum];
        }
        //if (texture != null)
        //{
        //    texture = new Texture2D(1024, 1024);
        //    currentRenderer.material.SetColor("_Color", Color.white);
        //    currentRenderer.material.SetTexture("_MainTex", texture);
        //}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
}
