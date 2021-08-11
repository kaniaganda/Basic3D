using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; // Vector3 stores three floats

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
