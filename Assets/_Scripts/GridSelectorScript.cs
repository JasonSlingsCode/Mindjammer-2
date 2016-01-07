using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GridSelectorScript : MonoBehaviour
{

    public GameObject gridButton;
    public List<Transform>buttonList = new List<Transform>();
    public int octantGridCount = 100;
    public Vector2 octantGridSize;
    public Vector2 octantGridSpacing;
    public int subsectorGridCount = 400;
    public Vector2 subsectorGridSize;
    public Vector2 subsectorGridSpacing;
    GridLayoutGroup gridLayout;
    int columnCount;
    string gridSet;

    void Awake()
    {
        foreach (Transform child in transform)
        {
            buttonList.Add(child);
        }
    }

    // Use this for initialization
    void Start()
    {
        SetupGrid(0);
    }
    
    // Update is called once per frame
    void Update()
    {
        switch (gridSet)
        {
            case "Octant": // OCTANT
                gridLayout.cellSize = octantGridSize;
                gridLayout.spacing = octantGridSpacing;
                break;
            case "Subsector": // SUBSECTOR
                gridLayout.cellSize = subsectorGridSize;
                gridLayout.spacing = subsectorGridSpacing;
                break;
            default:
                break;
        }
    }

    public void SetupGrid(int gridSetupSelection)
    {
        foreach (Transform button in buttonList)
        {
            button.gameObject.SetActive(false);
        }
        gridLayout = GetComponent<GridLayoutGroup>();
        int gridSetupCount;
        switch (gridSetupSelection)
        {
            case 0: // OCTANT
                gridSet = "Octant";
                gridSetupCount = octantGridCount;
                gridLayout.cellSize = octantGridSize;
                gridLayout.spacing = octantGridSpacing;
                gridLayout.constraintCount = 10;
                for (int i = 0; i < gridSetupCount; i++)
                {
                    buttonList [i].gameObject.SetActive(true);
                    string buttonText = buttonList [i].GetComponentInChildren<Text>().text = "System " + (i + 1);
                }
                break;
            case 1: // SUBSECTOR
                gridSet = "Subsector";
                gridSetupCount = subsectorGridCount;
                gridLayout.cellSize = subsectorGridSize;
                gridLayout.spacing = subsectorGridSpacing;
                gridLayout.constraintCount = 20;
                for (int i = 0; i < gridSetupCount; i++)
                {
                    buttonList [i].gameObject.SetActive(true);
                    string buttonText = buttonList [i].GetComponentInChildren<Text>().text = "System " + (i + 1);
                }
                break;
            default:
                break;
        }
    }
}
