using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public Image Bar;
    public float fill;
    public Button but;
    public int money;
    public float fps;
    public Text moneyText;
    public GameObject zomb;
    public float fillpersecond;

    public int spawnlvl;
    public int spawncd;

    void Start()
    {

        fill = 0f;
        fps = 0.02f;
        Bar.fillAmount = fill;
        fillpersecond = 0.01f;
        money = PlayerPrefs.GetInt("money", money);
        Bar.fillAmount = PlayerPrefs.GetFloat("fill", Bar.fillAmount);
        spawnlvl = PlayerPrefs.GetInt("spawnlvl", spawnlvl);
        spawncd = PlayerPrefs.GetInt("spawncd", spawncd);
        fps = PlayerPrefs.GetFloat("fps", fps);
        fillpersecond = PlayerPrefs.GetFloat("fillpersecond", fillpersecond);

        if (spawncd == 0)
        {
            fps = 0.03f;
            fillpersecond = 0.05f;
        }

        if (spawncd == 1)
        {
            fps = 0.05f;
            fillpersecond = 0.07f;
        }

        if (spawncd == 2)
        {
            fps = 0.06f;
            fillpersecond = 0.08f;
        }

        if (spawncd == 3)
        {
            fps = 0.07f;
            fillpersecond = 0.09f;
        }

        if (spawncd == 4)
        {
            fps = 0.08f;
            fillpersecond = 0.1f;
        }
    }

    // Update is called once per frame                                                                                        
    void Update()                                                                                                             
    {
        
            zomb.transform.position = new Vector3(9.58f, -2.85f, -3.918083f);

            moneyText.text = money.ToString();

            Bar.fillAmount += Time.deltaTime * fillpersecond;
            PlayerPrefs.SetFloat("fill", Bar.fillAmount);
        if (Bar.fillAmount >= 1f)
            {
                spawn();
                Bar.fillAmount = 0f;
            }
        

        
    }

    public void ButtonClick ()
    {
        
        Bar.fillAmount += fps;
        PlayerPrefs.SetFloat("fill", Bar.fillAmount);
        
    }

    public void plusmoney()
    {
        money++;
        PlayerPrefs.SetInt("money", money);
    }

    void spawn()
    {
        if (spawnlvl == 0)
        {
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
        }

        if (spawnlvl == 1)
        {
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
        }

        if (spawnlvl == 2)
        {
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
        }

        if (spawnlvl == 3)
        {
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
        }

        if (spawnlvl == 4)
        {
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
            Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
        }
       
        //Instantiate(zomb, new Vector3(Random.Range(-2.07f, 2.07f), Random.Range(0.75f, -0.66f), -3.918083f), new Quaternion(0, 0, 0, 0));
    


    }

    public void nextscene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }



}
