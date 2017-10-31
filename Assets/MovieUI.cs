using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(RawImage))]
[RequireComponent(typeof(AudioSource))]

public class MovieUI : MonoBehaviour{
    [SerializeField] string m_moviePath;

    MovieTexture m_movieTexture = null;

    RawImage m_rawImage = null;
    AudioSource m_audioSource = null;
    bool isSkip = false;

    bool isEnd = false;
    int count = 0;

    public bool IsPlaying{
        get { return m_movieTexture != null && m_movieTexture.isPlaying; }
    }

    public void Play(){
        if (IsPlaying){
            Stop();
        }

        m_movieTexture = (MovieTexture)Resources.Load<MovieTexture>(m_moviePath);

        if (m_movieTexture == null){
            Debug.LogError("movie is nothing:" + m_moviePath);
            return;
        }

        m_movieTexture.loop = false;

        m_rawImage.material.mainTexture = m_movieTexture;
        m_audioSource.clip = m_movieTexture.audioClip;

        m_movieTexture.Play();
        m_audioSource.Play();
    }

    public void Stop(){
        if (!IsPlaying){
            return;
        }
        m_movieTexture.Stop();
        m_audioSource.Stop();

        m_movieTexture.Play();
        m_audioSource.Play();

        m_movieTexture.Stop();
        m_audioSource.Stop();
    }

    public void setIsSkip(bool _isSkip){
        this.isSkip = _isSkip;
    }

    public void initMovie(string _path){
        m_moviePath = _path;
        m_rawImage = this.GetComponent<RawImage>();
        m_audioSource = this.GetComponent<AudioSource>();
        Play();
    }

    void Start(){
    }

    void Update(){
        if ((!m_movieTexture.isPlaying && m_movieTexture != null) || 
            (this.isSkip && Input.GetMouseButtonUp(0)) ){
            m_movieTexture.Stop();
            m_audioSource.Stop();
            m_movieTexture.Play();
            m_audioSource.Play();
            isEnd = true;

            // TODO: 非表示処理が実行されない
            GameObject movie_jks = GameObject.Find("movie_jks");
            Renderer rend = movie_jks.GetComponent<Renderer>();
            rend.enabled = false;
            foreach(Transform child in movie_jks.transform){
                GameObject obj = child.gameObject;
                obj.GetComponent<Renderer>().enabled = false;
            }
        }

        if(isEnd){
            count++;
        }

        if(count > 5){
            m_movieTexture.Stop();
            GameObject movie_jks = GameObject.Find("movie_jks");
            GameObject.Destroy(movie_jks);
        }
    }
}