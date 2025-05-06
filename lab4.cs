using UnityEngine;

public class LAB3 : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    void Start()
    {
        sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(0, 30, 0);
    }

    public void show()
    {
        sphere.SetActive(true);
    }

    public void hide()
    {
        sphere.SetActive(false);
    }
}