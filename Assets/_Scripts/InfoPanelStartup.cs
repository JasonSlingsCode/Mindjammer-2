using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoPanelStartup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void InfoPanelInit()
    {
        InfoPanelController infoPanel = GameObject.Find("InfoPanel").GetComponent<InfoPanelController>();
        string buttonName = this.gameObject.name;
        infoPanel.InfoPanelSetup(buttonName);
    }
}
