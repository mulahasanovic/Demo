using UnityEngine;
using System.Collections;

public class cubeInterfaceScript : MonoBehaviour {

	private MeshRenderer cubeRend;

	private float positionx = 2.5f;
	private float positiony = 2.5f;
	private float positionz = 2.5f;

	private float rotationx = 0;
	private float rotationy = 0;
	private float rotationz = 0;

	private float sizex = 1;
	private float sizey = 1;
	private float sizez = 1;

	void Start () {

		//Pause on start
		Time.timeScale = 0.0f;
	}

	void Update () {
		gameObject.transform.position = new Vector3 (positionx, positiony, positionz);
		gameObject.transform.eulerAngles = new Vector3 (rotationx, rotationy, rotationz);
		gameObject.transform.localScale = new Vector3 (sizex, sizey, sizez);
	}

	//Change color
	void OnCollisionEnter(Collision collisionInfo)
	{
		cubeRend = gameObject.GetComponent<MeshRenderer> ();
		cubeRend.material.color = Color.blue; 
	}

	//Unpause on play
	public void Play(){
		Time.timeScale = 1.0f;
	}
	
	public void Reset(){
		Application.LoadLevel(0);
	}

	public void Quit(){
		Application.Quit();
	}

	//Position
	public void ChangePositionX(float newpos){
		positionx = newpos * 5;
	}
	public void ChangePositionY(float newpos){
		positiony = newpos * 5;
	}
	public void ChangePositionZ(float newpos){
		positionz = newpos * 5;
	}

	//Rotation
	public void ChangeRotationX(float newrot){
		rotationx = newrot * 90;
	}
	public void ChangeRotationY(float newrot){
		rotationy = newrot * 90;
	}
	public void ChangeRotationZ(float newrot){
		rotationz = newrot * 90;
	}

	//Size
	public void ChangeSizeX(float newsize){
		if (newsize == 0)
			newsize = 0.01f;
		sizex = newsize * 3;
	}
	public void ChangeSizeY(float newsize){
		if (newsize == 0)
			newsize = 0.01f;
		sizey = newsize * 3;
	}
	public void ChangeSizeZ(float newsize){
		if (newsize == 0)
			newsize = 0.01f;
		sizez = newsize * 3;
	}
}