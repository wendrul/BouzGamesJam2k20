﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    private bool shouldSnap;
    private bool isMoving;
    private bool over;
    private bool snapInv;
	private GameObject Mat;
    private float centerx;
    private float centery;
    private float startPosX;
    private float startPosY;
    private Vector3 startPos;
    private Vector3 resetPosition;
    private Transform runePosition;
    private Transform materialPosition;
	public int stacks;
	public bool snapBin;
    private Runes rune;
    private Mat material;
    
    static float snapDistance = 1.7f;
    private Transform[] runePositions;

    private void Start()
    {
        material = GetComponent<Mat>();
        resetPosition = this.transform.localPosition;
        runePositions = new Transform[4];
        runePositions[0] = GameObject.Find("Rune0").transform;
        runePositions[1] = GameObject.Find("Rune1").transform;
        runePositions[2] = GameObject.Find("Rune2").transform;
        runePositions[3] = GameObject.Find("Rune3").transform;
    }

    private void OnElementAdd()
    {
        rune.Element = new Element(material, rune.id);
        rune.IsOccupied = true;
    }

    private void Update()
    {
        if (isMoving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
        if (shouldSnap && !isMoving)
        {
            OnElementAdd();
            this.transform.position = new Vector3(runePosition.transform.position.x, runePosition.transform.position.y, this.transform.position.z);
        }
    }

    private void OnMouseOver()
    {
        if (over == false)
        {
            over = true;
            this.transform.Find("Memo").gameObject.SetActive(true);
        }
    }
    

    private void OnMouseExit()
    {
        if (over == true)
        {
            over = false;
            this.transform.Find("Memo").gameObject.SetActive(false);
        }
    }

    private void GetClosestRune()
    {
        foreach (Transform rp in runePositions)
        {
            float dist = (rp.position - gameObject.transform.localPosition).magnitude;
            if (dist < snapDistance)
            {
                shouldSnap = true;
                runePosition = rp.gameObject.transform;
                rune = rp.gameObject.GetComponent<Runes>();
                break;
            }
        }
        //rune = null;
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetClosestRune();
            if(rune != null && rune.IsOccupied)
            {
                rune.IsOccupied = false;
                rune.Element = null;
            }
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); 
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            startPos = new Vector3(startPosX, startPosY);

            isMoving = true;
            shouldSnap = false;
        }
    }
    
    public void AddStack()
	{
		stacks++;
	}

    private void OnMouseUp()
    {
        isMoving = false;
        GetClosestRune();
    }
}