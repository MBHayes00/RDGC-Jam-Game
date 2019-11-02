using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    //Variables
    [SerializeField]
    private GameObject[] collectionImages;
    public bool[] collectTest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayCollection();
    }

    /// <summary>
    /// Plays the game 
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Displays the collectables that have been collected
    /// </summary>
    void DisplayCollection()
    {
        //Displays first collectable
        if (collectTest[0])
            collectionImages[0].SetActive(true);

        //Displays second collectable
        if (collectTest[1])
            collectionImages[1].SetActive(true);

        //Displays third collectable
        if (collectTest[2])
            collectionImages[2].SetActive(true);

        //Display fourth collectable
        if (collectTest[3])
            collectionImages[3].SetActive(true);


    }
}
