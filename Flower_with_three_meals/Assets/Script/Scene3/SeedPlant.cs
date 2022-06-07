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
    public GameObject bird1;
    public GameObject bird2;
    public GameObject butterfly1;
    public GameObject butterfly2;

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

        GameObject lseed = GameObject.FindGameObjectWithTag("lavenderseed");
        GameObject sseed = GameObject.FindGameObjectWithTag("sunflowerseed");
        GameObject cseed = GameObject.FindGameObjectWithTag("camelliaseed");
        GameObject dseed = GameObject.FindGameObjectWithTag("daisyseed");

        if (lavenderseed)
        {
            lavenders += 1f;
        }
        if (sunflowerseed)
        {
            sunflowers += 1f;
        }
        if (camelliaseed)
        {
            camellias += 1f;
        }
        if (daisyseed)
        {
            daisys += 1f;
        }

        Debug.Log("lavender : " + lavenders + "sun : " + sunflowers + "camellia : " + camellias + "daisy : " + daisys);

        // 만약 라벤더 씨앗이 활성화 되어있있다면..
        if (lavenderseed && lavenders >= 1 && lcount == 0)
        {

            pos = lseed.transform.position;
            temp = Instantiate(lavender, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Debug.Log("라벤더 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            Destroy(lseed);

            // 참새 보이기
            bird1.SetActive(!bird1.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

            lavenders = 0;
            lcount += 1;
        }

        if (sunflowerseed && sunflowers >= 2 && scount == 0)
        {
            
            
            pos = sseed.transform.position;
            temp = Instantiate(sunflower, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Destroy(sseed);

            Debug.Log("해바라기 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            sunflowers = 0;
            scount += 1;

            // 참새 보이기
            butterfly1.SetActive(!butterfly1.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

        }
        if (camelliaseed && camellias >= 3 && ccount == 0)
        {
           
            pos = cseed.transform.position;
            temp = Instantiate(camellia, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Destroy(cseed);
            Debug.Log("동백꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            camellias = 0;
            ccount += 1;

            // 나비 보이기
            bird2.SetActive(!bird2.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

        }
        if (daisyseed && daisys >= 4 && dcount == 0)
        {
           
            pos = dseed.transform.position;
            temp = Instantiate(daisy, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Destroy(dseed);
            Debug.Log("데이지꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            daisys = 0;
            dcount += 1;

            // 나비 보이기
            butterfly2.SetActive(!butterfly2.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

        }

        // 3초 후 사라져
        Invoke("animalfalse", 3.0f);

    }

    void animalfalse()
    {
        if (bird1.active == true)
        {
            bird1.SetActive(false);
        }
        else if (bird2.active == true)
        {
            bird2.SetActive(false);
        }
        else if (butterfly1.active == true)
        {
            butterfly1.SetActive(false);
        }
        else if (butterfly2.active == true)
        {
            butterfly2.SetActive(false);
        }else if(watering.active == true)
        {
            watering.SetActive(false);
        }
    }
    
}
