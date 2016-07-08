
// TODO: Let Camera follow projectile
// TODO: Cooldown between two shots
// TODO: Cancel cooldown if current projectile has already stopped moving or is out of scene

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
public class ShootArea2D : MonoBehaviour {
    public Rigidbody2D ProjectilePrefab;
    public float Force = 3;
    public float Angle = 45;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var projectile = (GameObject)Instantiate(ProjectilePrefab, pos, Quaternion.identity);
        var body = projectile.GetComponent<Rigidbody2D>();

        
        var direction = Quaternion.Euler(0, 0, -Angle) * Vector3.up;
        body.AddForce(Force * direction * body.mass);
        body.AddTorque(-Random.Range(1f, 400) * body.mass);
    }
}
