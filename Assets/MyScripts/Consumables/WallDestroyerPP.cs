using UnityEngine;
using System.Collections;

public class WallDestroyerPP : MonoBehaviour {

    public GameObject coin;
    public int duration;
    private int time;
    private bool isPPActive = false;

	// Use this for initialization
	void Start () {
	       
	}
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter(Collision col) {
            if (col.gameObject.name == "Fence_0" || col.gameObject.name == "Fence_1") {    
                col.gameObject.SetActive(false);
            }
    }


}
