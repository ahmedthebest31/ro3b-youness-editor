using UnityEngine;
using UnityEngine.UI;

public class RandomBackgrounds : MonoBehaviour {

    [SerializeField] Sprite[] images;
    int i = 0;
    [SerializeField] Image background;

    private void Start()
    {
        InvokeRepeating("RandomBackground", 0f, 1f);
    }

    void RandomBackground()
    {
        i = Random.Range(0, images.Length);
        background.sprite = images[i];
    }

    private void Update()
    {
        if (Input.GetButton("Cancel"))
            Application.Quit();
    }

} // end class 