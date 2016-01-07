using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleGridPanel : MonoBehaviour
{
    public bool GridIsShowing;
    public float Speed;
    
    public Vector3 ShowPos;
    public Vector3 HidePos;
    public float Offset;
    
    GameObject infoPanel;
    
    void Start()
    {
        infoPanel = GameObject.Find("InfoPanel");
        ShowPos = infoPanel.transform.position;
        HidePos = new Vector3(Offset, infoPanel.transform.position.y, 0);
    }
    
    public void MenuToggle()
    {
        GridIsShowing = !GridIsShowing;
    }
    
    // Update is called once per frame
    void FixedUpdate ()
    {
        ShowPos = infoPanel.transform.position;
        HidePos = new Vector3(Offset, infoPanel.transform.position.y, 0);
        if (GridIsShowing)
        {
            transform.position = Vector3.Lerp (transform.position, ShowPos, Time.deltaTime * Speed);
        }
        if (!GridIsShowing)
        {
            transform.position = Vector3.Lerp (transform.position, HidePos, Time.deltaTime * Speed);
        }
    }
}
