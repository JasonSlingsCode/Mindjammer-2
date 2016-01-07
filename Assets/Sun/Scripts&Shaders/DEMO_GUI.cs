using UnityEngine;
using System.Collections;

public class DEMO_GUI : MonoBehaviour {
	private float contrast;
	private float brightness;
	private float edge_brightness;
	private float contrast_old;
	private float saturation;
	private float saturation_old;
	private float brightness_old;
	private float edge_brightness_old;
    private float color_red;
    private float color_green;
    private float color_blue;
    private float color_red_old;
    private float color_green_old;
    private float color_blue_old;


	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
		contrast = this.GetComponent<Renderer>().material.GetFloat("_Contrast");
		brightness = this.GetComponent<Renderer>().material.GetFloat("_Brightness");
		edge_brightness = this.GetComponent<Renderer>().material.GetFloat("_Contour");
		saturation = this.GetComponent<Renderer>().material.GetFloat("_Saturation");
        color_red = this.GetComponent<Renderer>().material.color.r;
        color_green = this.GetComponent<Renderer>().material.color.g;
        color_blue  = this.GetComponent<Renderer>().material.color.b;
	}

	void OnGUI(){
		GUI.Label(new Rect(50,30,200,20),"Contrast");
		GUI.Label(new Rect(50,80,200,20),"Brightness");
		GUI.Label(new Rect(50,130,200,20),"Saturation");
		GUI.Label(new Rect(50,180,200,20),"Edge_brightness");
        GUI.Label(new Rect(50,230,200,20),"Color (Red)");
        GUI.Label(new Rect(50,280,200,20),"Color (Green)");
        GUI.Label(new Rect(50,330,200,20),"Color (Blue)");
		contrast = GUI.HorizontalSlider(new Rect(50,50,200,20),contrast,0f,3f);
		brightness = GUI.HorizontalSlider(new Rect(50,100,200,20),brightness,0f,1f);
		saturation = GUI.HorizontalSlider(new Rect(50,150,200,20),saturation,0f,1f);
		edge_brightness = GUI.HorizontalSlider(new Rect(50,200,200,20),edge_brightness,0f,1f);
        color_red = GUI.HorizontalSlider(new Rect(50,250,200,20),color_red,0,1);
        color_green = GUI.HorizontalSlider(new Rect(50,300,200,20),color_green,0,1);
        color_blue = GUI.HorizontalSlider(new Rect(50,350,200,20),color_blue,0,1);


	}
	// Update is called once per frame
	void FixedUpdate () {
		if (contrast !=contrast_old)
		{
			this.GetComponent<Renderer>().material.SetFloat("_Contrast",contrast);
			contrast_old = contrast;
		}
		if (brightness !=brightness_old)
		{
			this.GetComponent<Renderer>().material.SetFloat("_Brightness",brightness);
			brightness_old = brightness;
		}
		if (edge_brightness != edge_brightness_old)
		{
			this.GetComponent<Renderer>().material.SetFloat("_Contour",edge_brightness);
			edge_brightness_old = edge_brightness;
		}
		if (saturation != saturation_old)
		{
			this.GetComponent<Renderer>().material.SetFloat("_Saturation",saturation);
			saturation_old = saturation;
		}
        if (saturation != saturation_old)
        {
            this.GetComponent<Renderer>().material.SetFloat("_Saturation",saturation);
            saturation_old = saturation;
        }
        if (color_red != color_red_old)
        {
            this.GetComponent<Renderer>().material.color = new Color(color_red, color_green, color_blue);
            color_red_old = color_red;
        }
        if (color_green != color_green_old)
        {
            this.GetComponent<Renderer>().material.color = new Color(color_red, color_green, color_blue);
            color_green_old = color_green;
        }
        if (color_blue != color_blue_old)
        {
            this.GetComponent<Renderer>().material.color = new Color(color_red, color_green, color_blue);
            color_blue_old = color_blue;
        }
	}
}
