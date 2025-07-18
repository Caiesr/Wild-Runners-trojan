using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject cam;
    public float parallaxEffect;
 
    void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + lenght) startpos += lenght * 2;
        else if (temp < startpos - lenght) startpos -= lenght * 2;
    }
}
