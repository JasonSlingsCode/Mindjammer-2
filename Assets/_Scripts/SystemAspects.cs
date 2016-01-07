using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SystemAspects : MonoBehaviour
{
    public bool systemIsPresent;

    [Header("Info Panel Display")]

    public Text systemButtonLabel;
    public string systemName;
    public string highConcept;
    public List<string> systemAspects = new List<string>();
    public string stellarBodyType;
    public int SBT_Value;
    public string multipleSystems;
    public int MS_Value;
    public string stellarBodyDetermination;
    public int SBD_Value;
    public string spectralClassification;
    public int SC_Value;
    public string stellarBodyAge;
    public int SBA_Value;

    void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        systemButtonLabel.text = systemName;
    }
}
