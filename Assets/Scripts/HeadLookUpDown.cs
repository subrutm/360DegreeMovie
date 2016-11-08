using UnityEngine;
using System.Collections;

public class HeadLookUpDown : MonoBehaviour {
    public float velocity = 0.7f;
    public float maxHeight = 20.0f;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update () {
        Debug.Log("HeadLookUpDown::Update");

        float MoveY = 1.0f * velocity * Time.deltaTime;
        float newY = transform.localPosition.y + MoveY;

        if (newY >= 0f && newY < maxHeight) {
            Camera.main.transform.localPosition = new Vector3(transform.position.x, newY, transform.position.z);
        }
    }
}
