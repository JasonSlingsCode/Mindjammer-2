using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BACKUP_SystemGeneratorScript : MonoBehaviour
{
    /*
    int debugCounter;
    
    [Header("Info Panel Display")]
    
    public InputField
        systemName;
    public Text highConcept;
    [Header("Stellar Body Type")]
    
    public Text
        SBT_Header;
    public Dropdown SBT_Menu;
    public Text SBT_Label;
    [Header("Multiple Systems")]
    
    public Text
        MS_Header;
    public Dropdown MS_Menu;
    public Text MS_Label;
    [Header("Stellar Body Determination")]
    
    public Text
        SBD_Header;
    public Dropdown SBD_Menu;
    public Text SBD_Label;
    [Header("Spectral Classification")]
    
    public Text
        SC_Header;
    public Dropdown SC_Menu;
    public Text SC_Label;
    [Header("Stellar Body Age")]
    
    public Text
        SBA_Header;
    public Dropdown SBA_Menu;
    public Text SBA_Label;
    [Header("H-Zone Orbital Distance")]
    
    public Text
        HZ_OD_Header;
    public GameObject HZ_OD_ValueSettings;
    public Text HZ_OD_Min;
    public Text HZ_OD_Max;
    [Header("H-Zone Orbital Period")]
    
    public Text
        HZ_OP_Header;
    public GameObject HZ_OP_ValueSettings;
    public Text HZ_OP_Min;
    public Text HZ_OP_Max;
    [Header("Planetary System Type")]
    
    public Text
        PST_Header;
    public Dropdown PST_Menu;
    public Text PST_Label;
    [Header("Planetary Bodies")]
    
    public Text
        PB_Header;
    public GameObject PB_ValueSettings;
    [Header("System Resources")]
    
    public Text
        SR_Header;
    [Header("System Aspects")]
    
    public Text
        SA_Header;
    
    [Header("Local System")]
    
    public GameObject
        localSystem;
    public Text localSystemLabel;
    public string localSystemName;
    InfoPanelController infoPanel;
    SystemAspects localSystemAspects;
    
    [Header("Definitions")]
    public List<string>
        stellarBodyTypes = new List<string>()
    {
        "No System",
        "Pre-Stellar Object",
        "Star",
        "Post-Stellar Object",
        "Exotic Stellar Object"
    };
    public List<string> multipleSystems = new List<string>()
    {
        "Unknown",
        "Single",
        "Binary",
        "Multiple"
    };
    public List <string> preStellarBodyDeterminations = new List<string>()
    {
        "Unknown",
        "Interstellar Cloud",
        "H II Region",
        "Molecular Cloud",
        "Molecular Cloud",
        "Protostar",
        "Protostar",
        "Eruptive Variable",
        "Eruptive Variable",
        "Eruptive Variable"
    };
    public List <string> stellarBodyDeterminations = new List<string>()
    {
        "Unknown",
        "Hot Subdwarf",
        "Pre-Main Sequence Star",
        "Cool Subdwarf",
        "Substellar Object",
        "Main Sequence Star",
        "Main Sequence Star",
        "Subgiant",
        "Giant",
        "Supergiant"
    };
    public List <string> postStellarBodyDeterminations = new List<string>()
    {
        "Unknown",
        "Stellar Core",
        "Collapsing Star",
        "Planetary Nebula",
        "Planetary Nebula",
        "White Dwarf",
        "White Dwarf",
        "Neutron Star",
        "Electro-weak Star",
        "Stellar Black Hole"
    };
    public List <string> exoticStellarBodyDeterminations = new List<string>()
    {
        "Unknown",
        "Dark Matter Star",
        "Asymptotic Giant",
        "Asymptotic Giant",
        "Eruptive Variable",
        "Pulsating Variable",
        "Pulsating Variable",
        "Eruptive Variable",
        "Eruptive Variable",
        "Black Star"
    };
    public List<string> spectralClassifications = new List<string>()
    {
        "Unknown",
        "Class O",
        "Class B",
        "Class A",
        "Class F",
        "Class G",
        "Class K",
        "Class M",
        "Class S",
        "Class C",
        "Class L",
        "Class T",
        "Class Y",
        "N/A"
    };
    public List<string> stellarBodyAges = new List<string>()
    {
        "Unknown",
        "Extremely Young",
        "Very Young",
        "Young",
        "Maturing",
        "Mature",
        "Aging",
        "Old",
        "Very Old",
        "Ancient"
    };
    
    // METHODS
    void Awake()
    {
        infoPanel = GetComponent<InfoPanelController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (localSystemAspects != null)
        {
            // Adjusts the High Concept text on the info panel to reflect options chosen.
            if (localSystemAspects.SBD_Value == 0)
                highConcept.text = localSystemAspects.stellarBodyAge + localSystemAspects.multipleSystems + localSystemAspects.spectralClassification + localSystemAspects.stellarBodyType;
            else if (localSystemAspects.SBD_Value > 0)
                highConcept.text = localSystemAspects.stellarBodyAge + localSystemAspects.multipleSystems + localSystemAspects.spectralClassification + localSystemAspects.stellarBodyDetermination;
            
            localSystemAspects.SBT_Value = SBT_Menu.value;
            localSystemAspects.SBD_Value = SBD_Menu.value;
            localSystemAspects.SC_Value = SC_Menu.value;
            localSystemAspects.MS_Value = MS_Menu.value;
            
            localSystemAspects.systemName = systemName.text;
            localSystemAspects.highConcept = highConcept.text;
            
            switch (localSystemAspects.SBT_Value)
            {
                case 0:
                    localSystemAspects.MS_Value = 0;
                    MS_Header.gameObject.SetActive(false);
                    MS_Menu.gameObject.SetActive(false);
                    SC_Menu.value = 0;
                    localSystemAspects.spectralClassification = "";
                    break;
                default:
                    MS_Header.gameObject.SetActive(true);
                    MS_Menu.gameObject.SetActive(true);
                    break;
            }
            if (localSystemAspects.SBT_Value != 2 && localSystemAspects.SBT_Value != 0)
            {
                SC_Menu.value = 14;
                localSystemAspects.spectralClassification = "";
            }
            
            switch (localSystemAspects.MS_Value)
            {
                case 0:
                    localSystemAspects.SBD_Value = 0;
                    SBD_Menu.captionText = SBD_Menu.captionText;
                    SBD_Header.gameObject.SetActive(false);
                    SBD_Menu.gameObject.SetActive(false);
                    break;
                default:
                    SBD_Header.gameObject.SetActive(true);
                    SBD_Menu.gameObject.SetActive(true);
                    break;
            }
            
            switch (localSystemAspects.SBD_Value)
            {
                case 0:
                    localSystemAspects.SBD_Value = 0;
                    SBD_Menu.captionText = SBD_Menu.captionText;
                    localSystemAspects.stellarBodyDetermination = "";
                    break;
                default:
                    break;
            }
            
            if (localSystemAspects.SBT_Value == 2 && localSystemAspects.SBD_Value > 0)
            {
                SC_Header.gameObject.SetActive(true);
                SC_Menu.gameObject.SetActive(true);
            } else 
            {
                SC_Header.gameObject.SetActive(false);
                SC_Menu.gameObject.SetActive(false);
            }
        }
    }
    
    // Use this for initialization
    public void StartGeneration()
    {
        debugCounter = 0;
        debugCounter++;
        print (debugCounter + ".) Generation Started.");
        
        localSystem = infoPanel.ActiveButton;
        localSystemLabel = infoPanel.ButtonLabel;
        localSystemName = infoPanel.ButtonLabel.text;
        systemName.text = localSystemName;
        localSystemAspects = localSystem.GetComponent<SystemAspects>();
        SBT_Menu.value = localSystemAspects.SBT_Value;
        SBD_Menu.options.Clear();
        switch (localSystemAspects.SBT_Value)
        {
            case 0: // NONE
                localSystemAspects.stellarBodyType = SBT_Menu.captionText.text + " ";
                localSystemAspects.systemIsPresent = false;
                MS_Header.gameObject.SetActive(false);
                MS_Menu.gameObject.SetActive(false);
                SBD_Header.gameObject.SetActive(false);
                SBD_Menu.gameObject.SetActive(false);
                SC_Header.gameObject.SetActive(false);
                SC_Menu.gameObject.SetActive(false);
                SBA_Header.gameObject.SetActive(false);
                SBA_Menu.gameObject.SetActive(false);
                HZ_OD_Header.gameObject.SetActive(false);
                HZ_OD_ValueSettings.SetActive(false);
                HZ_OP_Header.gameObject.SetActive(false);
                HZ_OP_ValueSettings.SetActive(false);
                PST_Header.gameObject.SetActive(false);
                PST_Menu.gameObject.SetActive(false);
                PB_Header.gameObject.SetActive(false);
                PB_ValueSettings.SetActive(false);
                SR_Header.gameObject.SetActive(false);
                SA_Header.gameObject.SetActive(false);
                break;
            case 1: // PRE-STELLAR
                localSystemAspects.systemIsPresent = true;
                foreach (string option in preStellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                break;
            case 2: // STAR
                localSystemAspects.systemIsPresent = true;
                foreach (string option in stellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                break;
            case 3: // POST-STELLAR
                localSystemAspects.systemIsPresent = true;
                foreach (string option in postStellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                break;
            case 4: // EXOTIC
                localSystemAspects.systemIsPresent = true;
                foreach (string option in exoticStellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                break;
            default:
                break;
        }
        
        SBD_Menu.value = localSystemAspects.SBD_Value;
        SC_Menu.value = localSystemAspects.SC_Value;
        MS_Menu.value = localSystemAspects.MS_Value;
    }
    
    public void StellarBodyType(int stellarBodyTypeSelection)
    {
        debugCounter++;
        print (debugCounter + ".) Stellar Body Type changed.");
        
        switch (stellarBodyTypeSelection)
        {
            case 0: // NONE
                localSystemAspects.SBT_Value = stellarBodyTypeSelection;
                SBD_Menu.options.Clear();
                SBD_Menu.captionText = SBD_Menu.captionText;
                localSystemAspects.systemIsPresent = false;
                localSystemAspects.stellarBodyType = SBT_Menu.captionText.text + " ";
                
                MS_Menu.value = 0;
                SBD_Menu.value = 0;
                SC_Menu.value = 0;
                
                break;
            case 1: // PRE-STELLAR
                localSystemAspects.SBT_Value = stellarBodyTypeSelection;
                SBD_Menu.captionText = SBD_Menu.captionText;
                SBD_Menu.options.Clear();
                localSystemAspects.systemIsPresent = true;
                foreach (string option in preStellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                SBD_Menu.value = 0;
                SBD_Menu.captionText = SBD_Menu.captionText;
                localSystemAspects.stellarBodyType = SBT_Menu.captionText.text + " ";
                break;
            case 2: // STAR
                localSystemAspects.SBT_Value = stellarBodyTypeSelection;
                SBD_Menu.captionText = SBD_Menu.captionText;
                SBD_Menu.options.Clear();
                localSystemAspects.systemIsPresent = true;
                foreach (string option in stellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                SBD_Menu.value = 0;
                SBD_Menu.captionText = SBD_Menu.captionText;
                localSystemAspects.stellarBodyType = SBT_Menu.captionText.text + " ";
                SC_Menu.value = 0;
                break;
            case 3: // POST-STELLAR
                localSystemAspects.SBT_Value = stellarBodyTypeSelection;
                SBD_Menu.captionText = SBD_Menu.captionText;
                SBD_Menu.options.Clear();
                localSystemAspects.systemIsPresent = true;
                foreach (string option in postStellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                SBD_Menu.value = 0;
                SBD_Menu.captionText = SBD_Menu.captionText;
                localSystemAspects.stellarBodyType = SBT_Menu.captionText.text + " ";
                break;
            case 4: // EXOTIC
                localSystemAspects.SBT_Value = stellarBodyTypeSelection;
                SBD_Menu.captionText = SBD_Menu.captionText;
                SBD_Menu.options.Clear();
                localSystemAspects.systemIsPresent = true;
                foreach (string option in exoticStellarBodyDeterminations)
                {
                    SBD_Menu.options.Add(new Dropdown.OptionData(option));
                }
                SBD_Menu.value = 0;
                SBD_Menu.captionText = SBD_Menu.captionText;
                localSystemAspects.stellarBodyType = SBT_Menu.captionText.text + " ";
                break;
        }
    }
    
    public void MultipleSystems (int multipleSystemSelection)
    {
        debugCounter++;
        print (debugCounter + ".) Multiple Systems changed.");
        
        switch (multipleSystemSelection)
        {
            case 0: // UNKNOWN
                localSystemAspects.MS_Value = multipleSystemSelection;
                localSystemAspects.multipleSystems = "";
                break;
            case 1: // SINGLE
                localSystemAspects.MS_Value = multipleSystemSelection;
                localSystemAspects.multipleSystems = MS_Menu.captionText.text + " ";
                break;
            case 2: // BINARY
                localSystemAspects.MS_Value = multipleSystemSelection;
                localSystemAspects.multipleSystems = MS_Menu.captionText.text + " ";
                break;
            case 3: // MULTIPLE
                localSystemAspects.MS_Value = multipleSystemSelection;
                localSystemAspects.multipleSystems = MS_Menu.captionText.text + " ";
                break;
        }
    }
    
    public void StellarBodyDetermination (int stellarBodyDeterminationSelection)
    {
        debugCounter++;
        print (debugCounter + ".) Stellar Body Determination changed.");
        
        switch (stellarBodyDeterminationSelection)
        {
            case 0:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = "";
                break;
            case 1:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 2:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 3:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 4:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 5:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 6:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 7:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 8:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
            case 9:
                localSystemAspects.SBD_Value = stellarBodyDeterminationSelection;
                localSystemAspects.stellarBodyDetermination = SBD_Menu.captionText.text + " ";
                break;
        }
        
        switch (localSystemAspects.SBT_Value)
        {
            case 2:
                break;
            default:
                SBA_Header.gameObject.SetActive(true);
                SBA_Menu.gameObject.SetActive(true);
                break;
        }
    }
    
    public void SpectralClassification(int spectralClassificationSelection)
    {
        debugCounter++;
        print (debugCounter + ".) Spectral Classification changed.");
        
        switch (spectralClassificationSelection)
        {
            case 0: // UNKNOWN
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = "";
                break;
            case 1: // CLASS O
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 2: // CLASS B
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 3:// CLASS A
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 4: // CLASS F
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 5: // CLASS G
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 6: // CLASS K
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 7: // CLASS M
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 8: // CLASS S
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 9: // CLASS C
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 10: // CLASS L
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 11: // CLASS T
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 12: // CLASS Y
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 13: // CLASS Z
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            case 14: // NON-MAIN SEQUENCE
                localSystemAspects.SC_Value = spectralClassificationSelection;
                localSystemAspects.spectralClassification = SC_Menu.captionText.text + " ";
                break;
            default:
                break;
        }
        
        switch (localSystemAspects.SBT_Value)
        {
            case 2:
                SBA_Header.gameObject.SetActive(true);
                SBA_Menu.gameObject.SetActive(true);
                break;
            default:
                break;
        }
        
    }
    */
}