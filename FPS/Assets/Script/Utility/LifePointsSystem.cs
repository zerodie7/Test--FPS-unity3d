using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePointsSystem : MonoBehaviour
{
    public int LifePoints = 5;
    public Texture activeHearts;
    public Texture inactiveHearts;
    private Texture[] heartsArray;

    //Interface
    public bool drawElements = true;
    [HideInInspector]
    public Vector2 guiStart = new Vector2(0, 0);
    private float divisiveFactor;
    [HideInInspector]
    public float width;
    [HideInInspector]
    public float height;
    private int lastActiveHeart;
    private int maxLifePoints;


    private void Start()
    {
        GameObject temporal = GameObject.FindGameObjectWithTag("Player");
        heartsArray = new Texture2D[LifePoints];
        maxLifePoints = LifePoints;
        FillHeartsArray();

        width = activeHearts.width / divisiveFactor;
        height = activeHearts.height / divisiveFactor;

    }

    void FillHeartsArray()
    {
        for (int i = 0; i < maxLifePoints; i++)
        {
            heartsArray[i] = activeHearts;
        }
        lastActiveHeart = maxLifePoints - 1;
        LifePoints = maxLifePoints;
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnGUI()
    {
        if (!drawElements)
        {
            return;
        }
        for (int i = 0; i < maxLifePoints; i++)
        {
            GUI.DrawTexture
            (new Rect(guiStart.x + (width * i) + 5.0f * i, guiStart.y, width, height), heartsArray[i], ScaleMode.ScaleToFit);
        }
    }

    void IncreaseHeartsfromGUI()
    {
        for (int i = 0; i < LifePoints; i++)
        {
            heartsArray[i] = activeHearts;
        }
    }

    void ReduceHeartsfromGUI()
    {
        for (; lastActiveHeart >= LifePoints; lastActiveHeart--)
        {
            heartsArray[lastActiveHeart] = inactiveHearts;
        }
    }

    
}
