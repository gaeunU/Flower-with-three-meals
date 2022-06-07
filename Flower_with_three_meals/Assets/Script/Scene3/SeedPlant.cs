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
    public GameObject Basicgroup;
    public GameObject flowergroup;
    public GameObject watering;
    public GameObject bird;
    public GameObject butterfly;

    float x;
    float y;

    // watering count
    float sunflowers = 0;
    float lavenders = 0;
    float camellias = 0;
    float daisys = 0;

    // flower count
    float lcount = 0;
    float scount = 0;
    float ccount = 0;
    float dcount = 0;
    Vector3 pos;
    // flower inisiate

    public GameObject sunflower;
    public GameObject lavender;
    public GameObject camellia;
    public GameObject daisy;

    // plant sound
    public AudioClip plant;
    public AudioClip wateringsound;
    public AudioClip birdsound;
    AudioSource audiosource;


    // Start is called before the first frame update
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

    public void Lavender()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 라벤더 씨앗을 심었습니다 !");
        temp = Instantiate(lavenderseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);
    }

    public void Sunflower()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 해바라기 씨앗을 심었습니다 !");
        temp = Instantiate(sunflowerseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void Camellia()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 동백꽃 씨앗을 심었습니다 !");
        temp = Instantiate(camelliaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void Daisy()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 데이지 씨앗을 심었습니다 !");
        temp = Instantiate(daisyseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void water()
    {
        audiosource.clip = wateringsound;
        audiosource.Play();
        Debug.Log("물주기 버튼을 눌렀습니다.");
        watering.SetActive(!watering.active);
        Destroy(Basicgroup);



        if (lavenderseed)
            lavenders += 0.5f;
        if (sunflowerseed)
            sunflowers += 0.5f;
        if (camelliaseed)
            camellias += 0.5f;
        if (daisyseed)
            daisys += 0.5f;
        Debug.Log("lavender : " + lavenders + "sun : " + sunflowers + "camellia : " + camellias + "daisy : " + daisys);

        // 만약 라벤더 씨앗이 활성화 되어있ㄱ
        if (lavenderseed && lavenders >= 1 && lcount == 0)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);
            temp = Instantiate(lavender, new Vector3(x, y, 0), Quaternion.identity);
            Debug.Log("라벤더 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            
            // 참새 보이기
            bird.SetActive(!bird.active);
            audiosource.clip = birdsound;
            audiosource.Play();
            Invoke("birdFalse", 3.0f);

            //     Destroy(bird);


            lavenders = 0;
            lcount += 1;
        }

        if (sunflowerseed && sunflowers >= 2 && scount == 0)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = sunflowerseed.transform.position;
            temp = Instantiate(sunflower, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(sunflowerseed);
            Debug.Log("해바라기 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            sunflowers = 0;
            scount += 1;

        }
        if (camelliaseed && camellias >= 3 && ccount == 0)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = sunflowerseed.transform.position;
            temp = Instantiate(camellia, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(camelliaseed);
            Debug.Log("동백꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            camellias = 0;
            ccount += 1;

            // 참새 보이기
            butterfly.SetActive(!butterfly.active);
            audiosource.clip = birdsound;
            audiosource.Play();
            Invoke("butterflyFalse", 3.0f);

        }
        if (daisyseed && daisys >= 4 && dcount == 0)
        {
            x = Random.Range(115, 960);
            y = Random.Range(530, 1523);

            pos = sunflowerseed.transform.position;
            temp = Instantiate(daisy, new Vector3(x, y, 0), Quaternion.identity);
            Destroy(daisyseed);
            Debug.Log("데이지꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            daisys = 0;
            dcount += 1;

        }


    }

    void birdFalse()
    {
        bird.SetActive(false);
    }
    void butterflyFalse()
    {
        butterfly.SetActive(false);
    }


}
