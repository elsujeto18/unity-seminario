using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEditor;
using System.IO;





public class Video : MonoBehaviour
{
    public RawImage image;
    public VideoPlayer video;
    



    public void Video_onClicked() {
        StartCoroutine("PlayVideo");
    
    }

    IEnumerator PlayVideo()
    {
        video.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(video.isPrepared)
        {
            yield return waitForSeconds;

            break;

        }

        image.texture = video.texture;
        video.Play();
       

    }















   /* string path;
    public RawImage image;

    public void OpenExplorer()
    {
        path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        GetImage();
    }

    void GetImage()
    {
        if(path != null){
            UpdateImage();
        }
    }

    void UpdateImage()
    {
        WWW www = new WWW("file:///" + path);
        image.texture = www.texture;
    }*/



    /*public VideoPlayer video;
    public RawImage image;

    public void LoadVideo(string name)
    {
        string temp = Application.persistentDataPath + name;
        if (video.url == temp) return;

        video.url = temp;
        video.Prepare();
    }*/
}
