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


    // flower inisiate
    GameObject temp;
    public GameObject sunflower;
    public GameObject lavender;
    public GameObject camellia;
    public GameObject daisy;

    public GameObject flowergroup;

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

    public void water()
    {
        audiosource.clip = wateringsound;
        audiosource.Play();
        Debug.Log("물주기 버튼을 눌렀습니다.");
        watering.SetActive(!watering.active);

        lavenders += 0.5f;
        sunflowers += 0.5f;
        camellias += 0.5f;
        daisys += 0.5f;

        if (lavenders >= 1)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = lavenderseed.transform.position;
            temp = Instantiate(lavender, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(GameObject.Find("lavenderseed"));
            Debug.Log("라벤더 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            lavenders = 0;

        }
        if (sunflowers >= 2)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = sunflowerseed.transform.position;
            temp = Instantiate(sunflower, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(GameObject.Find("sunflowerseed"));
            Debug.Log("해바라기 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            sunflowers = 0;

        }
        if (camellias >= 3)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = sunflowerseed.transform.position;
            temp = Instantiate(camellia, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(GameObject.Find("camelliaseed"));
            Debug.Log("동백꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            camellias = 0;

        }
        if (daisys >= 4)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = sunflowerseed.transform.position;
            temp = Instantiate(daisy, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(GameObject.Find("daisyseed"));
            Debug.Log("데이꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            daisys = 0;

        }


    }

    public void move()
    {
        audiosource.clip = clicksound;
        audiosource.Play();
        Debug.Log("당신은 꽃을 이동하고 있습니다 ~");
    //    seedgroup.SetActive(!seedgroup.active);
    }


}
