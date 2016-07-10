using UnityEngine;
using System.Collections;

public class Crushable : MonoBehaviour {
    private static float MinDot = Mathf.Cos(45);      // consider "crushed" at this angle
    private bool crushed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (!crushed) {
            // check if crushable has been "turned"
            //print(Vector3.Dot(transform.up, Vector3.up));
            if (Vector3.Dot(transform.up, Vector3.up) <= MinDot) {
                print("CRUSHED!");
                SetCrushed();
            }
        }
	}

    /// <summary>
    /// Flags this crushable as "crushed"
    /// </summary>
    public void SetCrushed() {
        if (crushed) return;

        crushed = true;
        
    }
}
