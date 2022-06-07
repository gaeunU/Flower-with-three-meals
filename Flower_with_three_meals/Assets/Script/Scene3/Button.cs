using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject seedgroup;
    public GameObject watering;


    // seed
    public GameObject sunflowerseed;
    public GameObject lavenderseed;

    // watering count
    float sunflowers = 0;
    float lavenders = 0;
    float camellias = 0;
    float daisys = 0;


    float x;
    float y;
    Vector3 pos;

    private SeedPlant script;


    // Start is called before the first frame update

    // button click sound
    public AudioClip clicksound;
    public AudioClip wateringsound;
    AudioSource audiosource;
    
    void Start()
    {
        this.audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(115, 960);
        y = Random.Range(530, 1523);
    }

    public void plant()
    {
        audiosource.clip = clicksound;
        audiosource.Play();
        Debug.Log("꽃심기 버튼을 눌렀습니다.");
        seedgroup.SetActive(!seedgroup.active);
    }

    public void move()
    {
        audiosource.clip = clicksound;
        audiosource.Play();
        Debug.Log("당신은 꽃을 이동하고 있습니다 ~");
    //    seedgroup.SetActive(!seedgroup.active);
    }


}
