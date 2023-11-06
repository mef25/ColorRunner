using UnityEngine;
using UnityEngine.SceneManagement;

public class player : admob2
{
    public AudioSource audioSource, audio;
    bool oyunbittimi=false;
    public CharacterController characterController;
    private float speed =15f;
   
    
    
    void Start()
    {
        LoadLoadInterstitialAd();
        
        
        Application.targetFrameRate = 60;
        characterController = GetComponent<CharacterController>();
        if (GetComponent<Transform>().position.z > 75)//3-4
            speed = 20f;
        if (GetComponent<Transform>().position.z > 275)//5-6-7
            speed = 25f;
        if (GetComponent<Transform>().position.z > 610)//8-9
            speed = 30f;
        if (GetComponent<Transform>().position.z > 1200)//10
            speed = 35f;
        
       
    }


    void Update()
    {
        Vector3 ileri = new Vector3(0, 0, 1);
        characterController.Move(ileri * Time.deltaTime * speed);
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (parmak.phase == TouchPhase.Moved)
            {
                Vector3 hareket = new Vector3(parmak.deltaPosition.x, 0, 0);
                characterController.Move(hareket * Time.deltaTime * 1);

            }

        }

    }
               
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sagduvar")
        {
            audio.Play();
            oyunbittimi = false;
        }
        else if (other.gameObject.tag == "solduvar")
        {
            audioSource.Play();
            speed = 0f;
            GetComponent<Animator>().speed = 0;
            oyunbittimi = true;
            Invoke("hata", 1f);
        }
        else if (other.gameObject.tag == "Finish")
        {
            speed = 0f;
            GetComponent<Animator>().speed = 0;
            oyunbittimi = true;
            ShowInterstitialAd();
            sonrakilevelkontrolu();
            Invoke("levelsecimi", 2f);
        }
        
        
    }
    public void sonrakilevelkontrolu()
    {
        string currentlevel = PlayerPrefs.GetString("suankisecilenlevel");
        int currentlevelid = int.Parse(currentlevel.Split("LEVEL")[1]);
        int nextlevel = PlayerPrefs.GetInt("level") + 1;
        if (currentlevelid == PlayerPrefs.GetInt("seviyeSayýsý"))
            Debug.Log("Finish");
        else
        {
            if (nextlevel - currentlevelid == 1)
                PlayerPrefs.SetInt("level", nextlevel);
            else
                Debug.Log("Restart Level");
        }
    }
    private void hata()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        oyunbittimi = false;
    }
    private void levelsecimi()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   

 
}
