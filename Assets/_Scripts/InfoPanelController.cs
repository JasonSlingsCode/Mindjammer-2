using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoPanelController : MonoBehaviour
{
    [Header("Info Panel Text")]
    public Text
        SystemName;
    public Text SystemType;
    [Header("Active Button")]
    public GameObject
        ActiveButton;
    public Text ButtonLabel;
    public string ButtonLabelText;

    void Awake()
    {

    }

    public void InfoPanelSetup(string ButtonClicked)
    {
        // find the button which activated the info panel
        ActiveButton = GameObject.Find(ButtonClicked);

        GameObject buttonLabel = GameObject.Find(ButtonClicked + "/Text");
        ButtonLabel = buttonLabel.GetComponent<Text>();

        // rename the info panel's "System Name" header with the button's name
        SystemName.text = ButtonLabel.text;
    }

    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (ButtonLabel != null)
            ButtonLabelText = ButtonLabel.text;
    }
}
