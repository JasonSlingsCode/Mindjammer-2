using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleInputField : MonoBehaviour
{
    bool toggleOn;
    public Text placeholderText;
    public Text changedText;
    public float speed;
    public GameObject target;
    // Use this for initialization
    void Start()
    {
    
    }
    
    // Update is called once per frame
    void Update()
    {
        if (toggleOn)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x, target.transform.position.y), Time.deltaTime * speed);
            placeholderText.text = "Enter Text...";
            changedText.text = "";
        } else if (!toggleOn)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x, -200), Time.deltaTime * speed);
            placeholderText.text = "Enter Text...";
            changedText.text = "";
        }
    }

    public void ShowInputField()
    {
        toggleOn = !toggleOn;
    }
}
