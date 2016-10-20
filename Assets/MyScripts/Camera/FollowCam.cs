using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

    public GameObject cam;
    public Transform player;
	// Update is called once per frame
	void Update () {
        cam.transform.position = new Vector3(player.position.x, cam.transform.position.y, player.position.z - 100);
	}
}
