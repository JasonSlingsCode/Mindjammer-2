using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleInfoPanel : MonoBehaviour
{
    public bool MenuIsShowing;
    public float Speed;
    
    public Vector3 ShowPos;
    public Vector3 HidePos;
    public float Offset;

    GameObject infoPanel;
    GameObject theStar;
    Vector3 starShowPos;
    Vector3 starHidePos;

    GameObject theGrid;
    Vector3 gridShowPos;
    Vector3 gridHidePos;
    
    void Awake()
    {
        infoPanel = GameObject.Find("InfoPanel");
        theStar = GameObject.Find("StarPrefab");
        ShowPos = infoPanel.transform.position;
        HidePos = new Vector3(Offset, infoPanel.transform.position.y, 0);
        starShowPos = theStar.transform.position;
        starHidePos = new Vector3(-20, theStar.transform.position.y, 0);
        theGrid = GameObject.Find("GridPanel");
        gridShowPos = theGrid.transform.position;
        gridHidePos = new Vector3(theGrid.transform.position.x, Offset * 2, 0);
    }
    
    public void MenuToggle()
    {
        MenuIsShowing = !MenuIsShowing;
    }
    
    // Update is called once per frame
    void FixedUpdate ()
    {
        ShowPos = infoPanel.transform.position;
        HidePos = new Vector3(Offset, infoPanel.transform.position.y, 0);
        if (MenuIsShowing)
        {
            transform.position = Vector3.Lerp (transform.position, ShowPos, Time.deltaTime * Speed);

            theStar.transform.position = Vector3.Lerp(theStar.transform.position, starShowPos, Time.deltaTime * Speed * 0.5f);

            theGrid.transform.position = Vector3.Lerp(theGrid.transform.position, gridHidePos, Time.deltaTime * Speed / 2);
        }
        if (!MenuIsShowing)
        {
            transform.position = Vector3.Lerp (transform.position, HidePos, Time.deltaTime * Speed);

            theStar.transform.position = Vector3.Lerp(theStar.transform.position, starHidePos, Time.deltaTime * Speed * 0.5f);

            theGrid.transform.position = Vector3.Lerp(theGrid.transform.position, gridShowPos, Time.deltaTime * Speed / 2);
        }
    }
}
