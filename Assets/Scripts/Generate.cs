using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
	public GameObject rocks;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 4f, 2f);
	}
	
	// Update is called once per frame
	void CreateObstacle(){
		Instantiate (rocks);
		//DestroyImmediate (rocks,true);
		//TODO: destroy rocks after getting
	}
//	void update(){
//		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
//		if (screenPosition.x > Screen.height || screenPosition.y < 0)
//		{
//			Destroy(this.rocks);
//		}
//		}
}
