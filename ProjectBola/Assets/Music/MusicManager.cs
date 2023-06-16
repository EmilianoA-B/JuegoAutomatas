using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    private static MusicManager _instance;

    public static MusicManager Instance
    {
        get { return _instance; }
    }

    private AudioSource music;
    public AudioClip[] songs;
    public float volume;
    private float songsPlayed;
    private bool[] beenPlayed;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
                DontDestroyOnLoad(_instance);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {

        beenPlayed = new bool[songs.Length];

        music = GetComponent<AudioSource>();
        if (!music.isPlaying)
        {
            changeSong(Random.Range(0, songs.Length));
        }
    }
    private void Update()
    {
        music.volume = volume;

        if (Input.GetKeyDown(KeyCode.N))
            changeSong(Random.Range(0, songs.Length));

        if (!music.isPlaying)
        {
            changeSong(Random.Range(0, songs.Length));
        }

        if(songsPlayed == songs.Length)
        {
            songsPlayed = 0;
            for(int i =0; i <songs.Length; i++)
            {
                if (i == songs.Length)
                    break;
                else
                    beenPlayed[i] = false;
            }
        }
    }

    public void changeSong(int songPicked)
    {
        if (!beenPlayed[songPicked])
        {
            songsPlayed++;
            beenPlayed[songPicked] = true;
            music.clip = songs[songPicked];
            music.Play();
        }
        else
            music.Stop();

    }
}
