using UnityEngine;
using System.Collections;

public class Crushable : MonoBehaviour {
    public GameObject OnCrushEnable;

    /// <summary>
    /// Crushables need to surpass this angle to be considered "crushed"
    /// </summary>
    private static readonly float MinAngle = 60;
    private static readonly float MinDot = Mathf.Cos(Mathf.Deg2Rad * MinAngle);
    private bool crushed = false;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	    if (!crushed) {
            // check if crushable has been "turned"
            if (Vector3.Dot(transform.up, Vector3.up) <= MinDot) {
                //print("CRUSHED!");
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
        if (OnCrushEnable != null) {
            OnCrushEnable.SetActive(true);
        }
    }
}
