using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlant : MonoBehaviour
{
    GameObject temp;
    public GameObject lavenderseed;
    public GameObject sunflowerseed;
    public GameObject camelliaseed;
    public GameObject daisyseed;

    float x;
    float y;


    // plant sound
    public AudioClip plant;
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        this.audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(115,960);
        y = Random.Range(530,1523);
        
    }

    public void Lavender()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 라벤더 씨앗을 심었습니다 !");
        temp = Instantiate(lavenderseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);
    }

    public void Sunflower()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 해바라기 씨앗을 심었습니다 !");
        temp = Instantiate(sunflowerseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);

    }

    public void Camellia()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 동백꽃 씨앗을 심었습니다 !");
        temp = Instantiate(camelliaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);

    }
    public void Daisy()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 데이지 씨앗을 심었습니다 !");
        temp = Instantiate(daisyseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);

    }

    

}
