using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaycastScript : MonoBehaviour
{
    int zeroD = 40000;
    int zeroRP = 50;

    int[,,,] array3 = new int[4, 3, 2, 2] {
        {
        {{0,0},{0,0}},
        {{0,0},{0,0}},
        {{0,0},{0,0}}},
        {
        {{0,0},{0,0}},
        {{0,0},{0,0}},
        {{0,0},{0,0}}},
        {
        {{0,0},{0,0}},
        {{0,0},{50,4235}},
        {{0,0},{0,0}}},
        {
        {{0,0},{0,0}},
        {{0,0},{0,0}},
        {{0,0},{0,0}}}};

    int[,,] array2 = new int[4, 3, 2]
        {
        {{0,0},{0,0},{0,0}},
        {{0,0},{0,0},{0,0}},
        {{0,0},{124,58},{0,0}},
        {{0,0},{0,0},{0,0}}
        };

    int[,] array1 = new int[4, 2]
        {{0,0},{0,0},{35,6},{0,0}};

    private void OnMouseDown()
    {
        
        string name = this.gameObject.name;
        if (name.Length == 1 && name == "0")
        {
            SendMessage(zeroD, zeroRP);
        }
        else if (name.Length == 1 && name != "0")
        {
            int x = Convert.ToInt32(name.Substring(0, 1)) - 1;
            SendMessage(array1[x, 0], array1[x, 1]);
        }
        else if (name.Length == 2)
        {
            int x = Convert.ToInt32(name.Substring(0, 1)) - 1;
            int y = Convert.ToInt32(name.Substring(1, 1)) - 1;
            SendMessage(array2[x, y,0], array2[x,y,1]);
        }
        else if (name.Length == 3)
        {
            int x = Convert.ToInt32(name.Substring(0, 1)) - 1;
            int y = Convert.ToInt32(name.Substring(1, 1)) - 1;
            int z = Convert.ToInt32(name.Substring(2, 1)) - 1;
            SendMessage(array3[x, y, z,0], array3[x, y, z,1]);
        }


    }

    public void SendMessage(int dnaPrice, int researchPointsPrice)
    {
        Camera.main.GetComponent<ResearchController>().ShowPanel(dnaPrice, researchPointsPrice);
        
    }
}


#region Koment
/*
        Debug.Log(this.gameObject.name);
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        int childCount = this.gameObject.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform child = this.gameObject.transform.GetChild(i);
            child.gameObject.GetComponent<SpriteRenderer>().color = Color.white;

        }
        */
#endregion