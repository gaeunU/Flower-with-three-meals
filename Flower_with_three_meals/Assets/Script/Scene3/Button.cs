using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject seedgroup;
    // Start is called before the first frame update

    // button click sound
    public AudioClip clicksound;
    AudioSource audiosource;

    void Start()
    {
        this.audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void plant()
    {
        audiosource.clip = clicksound;
        audiosource.Play();
        Debug.Log("당신은 씨앗을 심었습니다 ~");
        seedgroup.SetActive(!seedgroup.active);
    }

    public void water()
    {
        audiosource.clip = clicksound;
        audiosource.Play();
        Debug.Log("당신은 물을 주고 있습니다 ~");
    }

    public void move()
    {
        audiosource.clip = clicksound;
        audiosource.Play();
        Debug.Log("당신은 꽃을 이동하고 있습니다 ~");
    //    seedgroup.SetActive(!seedgroup.active);
    }


}
